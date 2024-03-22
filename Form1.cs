using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Clubtag_winform_CRUD;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clubtag_winform_CRUD
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("EndpointUrl");

        private static string ReadSetting(string keyName)
        {
            string result = null;
            try
            {
                var value = ConfigurationManager.AppSettings;
                result = value[keyName];
            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tagokfrissitese();
        }

        private async void tagokfrissitese()
        {
           Tagok.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var tagsag = Tagsag.FromJson(jsonString);
                    foreach (Tagsag tag in tagsag)
                    {
                        Tagok.Items.Add(tag);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Tagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tagsag tag = (Tagsag)Tagok.SelectedItem;
            textBox_id.Text = tag.Id.ToString();
            textBox_nev.Text = tag.Fullname.ToString();
            textBox_erdeklodes.Text = tag.Interest.ToString();
            comboBox_ertekeles.Text = tag.Rating.ToString();
            dateTimePicker_date.Value = DateTime.Parse(tag.Entry);
        }

        private void button_uj_Click(object sender, EventArgs e)
        {
            Tagsag tagsag = new Tagsag();
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Név megadása kötelező!");
                textBox_nev.Focus();
                return;
            }
            tagsag.Fullname = textBox_nev.Text;
            tagsag.Entry = dateTimePicker_date.Value.ToLongTimeString();
            tagsag.Rating = (long)comboBox_ertekeles.SelectedValue;
            tagsag.Interest = textBox_erdeklodes.Text;

            var json = JsonConvert.SerializeObject(tag);
            var data = new StringContent(json,Encoding.UTF8,"application/json");
            var response = client.PostAsync(endPoint,data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres felvitel!");
                tagokfrissitese();
            }
            else
            {
                MessageBox.Show("Sikertelen felvitel!");
            }

            textBox_id.Text = string.Empty;
            textBox_nev.Text = string.Empty;
            comboBox_ertekeles.SelectedValue = "";
            textBox_erdeklodes.Text = string.Empty;
            dateTimePicker_date.Checked = false;
        }

        private void button_olvas_Click(object sender, EventArgs e)
        {
            tagokfrissitese();
        }

        private void button_modosit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_id.Text))
            {
                MessageBox.Show("Nincs kiválasztott tag!");
                return;
            }
            if (textBox_nev.Text.Length < 2)
            {
                MessageBox.Show("Név megadása kötelező!");
                textBox_nev.Focus();
                return;
            }
            if (!dateTimePicker_date.Checked)
            {
                MessageBox.Show("Adjon meg dátumot!");
                return;
            }

            Tagsag tagsag = new Tagsag();
            tagsag.Id = long.Parse(textBox_id.Text);
            tagsag.Fullname = textBox_nev.Text;
            tagsag.Entry = dateTimePicker_date.Value.ToLongTimeString();
            tagsag.Rating = (long)comboBox_ertekeles.SelectedValue;
            tagsag.Interest = textBox_erdeklodes.Text;

            var json = JsonConvert.SerializeObject(tagsag);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string endPointUpdate = $"{endPoint}/{tagsag.Id}";
            var response = client.PutAsync(endPointUpdate, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres módsítás!");
                tagokfrissitese();
            }
            else
            {
                MessageBox.Show("Sikertelen módosítás!");
            }

            textBox_id.Text = string.Empty;
            textBox_nev.Text = string.Empty;
            comboBox_ertekeles.SelectedValue = "";
            textBox_erdeklodes.Text = string.Empty;
            dateTimePicker_date.Checked = false;
        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Valóban törölni szeretné?") == DialogResult.OK)
            {
                Tagsag tagsag = new Tagsag();
                tagsag.Id = long.Parse(textBox_id.Text);
                string endPointUpdate = $"{endPoint}/{tagsag.Id}";
                var response = client.DeleteAsync(endPointUpdate).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres törlés!");
                    tagokfrissitese();
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés!");
                }

                textBox_id.Text = string.Empty;
                textBox_nev.Text = string.Empty;
                comboBox_ertekeles.SelectedValue = "";
                textBox_erdeklodes.Text = string.Empty;
                dateTimePicker_date.Checked = false;
            }
        }
    }
}
