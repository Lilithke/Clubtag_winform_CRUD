namespace Clubtag_winform_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tagok = new System.Windows.Forms.ListBox();
            this.groupBox1_kivalasztott_tag = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_belepes = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ertekeles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_erdeklodes = new System.Windows.Forms.TextBox();
            this.button_uj = new System.Windows.Forms.Button();
            this.button_olvas = new System.Windows.Forms.Button();
            this.button_modosit = new System.Windows.Forms.Button();
            this.button_torles = new System.Windows.Forms.Button();
            this.groupBox1_kivalasztott_tag.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tagok
            // 
            this.Tagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tagok.FormattingEnabled = true;
            this.Tagok.ItemHeight = 16;
            this.Tagok.Location = new System.Drawing.Point(0, 0);
            this.Tagok.Name = "Tagok";
            this.Tagok.Size = new System.Drawing.Size(221, 575);
            this.Tagok.TabIndex = 0;
            this.Tagok.SelectedIndexChanged += new System.EventHandler(this.Tagok_SelectedIndexChanged);
            // 
            // groupBox1_kivalasztott_tag
            // 
            this.groupBox1_kivalasztott_tag.Controls.Add(this.textBox_erdeklodes);
            this.groupBox1_kivalasztott_tag.Controls.Add(this.label5);
            this.groupBox1_kivalasztott_tag.Controls.Add(this.textBox_nev);
            this.groupBox1_kivalasztott_tag.Controls.Add(this.label4);
            this.groupBox1_kivalasztott_tag.Controls.Add(this.label3);
            this.groupBox1_kivalasztott_tag.Controls.Add(this.comboBox_ertekeles);
            this.groupBox1_kivalasztott_tag.Controls.Add(this.label2);
            this.groupBox1_kivalasztott_tag.Controls.Add(this.dateTimePicker_date);
            this.groupBox1_kivalasztott_tag.Controls.Add(this.label_belepes);
            this.groupBox1_kivalasztott_tag.Controls.Add(this.textBox_id);
            this.groupBox1_kivalasztott_tag.Controls.Add(this.label1);
            this.groupBox1_kivalasztott_tag.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1_kivalasztott_tag.Location = new System.Drawing.Point(221, 0);
            this.groupBox1_kivalasztott_tag.Name = "groupBox1_kivalasztott_tag";
            this.groupBox1_kivalasztott_tag.Size = new System.Drawing.Size(758, 249);
            this.groupBox1_kivalasztott_tag.TabIndex = 1;
            this.groupBox1_kivalasztott_tag.TabStop = false;
            this.groupBox1_kivalasztott_tag.Text = "Kiválasztott Tag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(135, 36);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 1;
            // 
            // label_belepes
            // 
            this.label_belepes.AutoSize = true;
            this.label_belepes.Location = new System.Drawing.Point(37, 81);
            this.label_belepes.Name = "label_belepes";
            this.label_belepes.Size = new System.Drawing.Size(58, 16);
            this.label_belepes.TabIndex = 2;
            this.label_belepes.Text = "Belépés";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Checked = false;
            this.dateTimePicker_date.Location = new System.Drawing.Point(135, 75);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.ShowCheckBox = true;
            this.dateTimePicker_date.Size = new System.Drawing.Size(226, 22);
            this.dateTimePicker_date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Értékelés";
            // 
            // comboBox_ertekeles
            // 
            this.comboBox_ertekeles.FormattingEnabled = true;
            this.comboBox_ertekeles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_ertekeles.Location = new System.Drawing.Point(135, 109);
            this.comboBox_ertekeles.Name = "comboBox_ertekeles";
            this.comboBox_ertekeles.Size = new System.Drawing.Size(121, 24);
            this.comboBox_ertekeles.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "1-5 (rossz- nagyon jó)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teljes név";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(135, 149);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(100, 22);
            this.textBox_nev.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Érdeklődés";
            // 
            // textBox_erdeklodes
            // 
            this.textBox_erdeklodes.Location = new System.Drawing.Point(135, 189);
            this.textBox_erdeklodes.Name = "textBox_erdeklodes";
            this.textBox_erdeklodes.Size = new System.Drawing.Size(100, 22);
            this.textBox_erdeklodes.TabIndex = 10;
            // 
            // button_uj
            // 
            this.button_uj.Location = new System.Drawing.Point(261, 301);
            this.button_uj.Name = "button_uj";
            this.button_uj.Size = new System.Drawing.Size(75, 23);
            this.button_uj.TabIndex = 2;
            this.button_uj.Text = "Új";
            this.button_uj.UseVisualStyleBackColor = true;
            this.button_uj.Click += new System.EventHandler(this.button_uj_Click);
            // 
            // button_olvas
            // 
            this.button_olvas.Location = new System.Drawing.Point(389, 301);
            this.button_olvas.Name = "button_olvas";
            this.button_olvas.Size = new System.Drawing.Size(75, 23);
            this.button_olvas.TabIndex = 3;
            this.button_olvas.Text = "Olvas";
            this.button_olvas.UseVisualStyleBackColor = true;
            this.button_olvas.Click += new System.EventHandler(this.button_olvas_Click);
            // 
            // button_modosit
            // 
            this.button_modosit.Location = new System.Drawing.Point(521, 301);
            this.button_modosit.Name = "button_modosit";
            this.button_modosit.Size = new System.Drawing.Size(75, 23);
            this.button_modosit.TabIndex = 4;
            this.button_modosit.Text = "Módosít";
            this.button_modosit.UseVisualStyleBackColor = true;
            this.button_modosit.Click += new System.EventHandler(this.button_modosit_Click);
            // 
            // button_torles
            // 
            this.button_torles.Location = new System.Drawing.Point(642, 301);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(75, 23);
            this.button_torles.TabIndex = 5;
            this.button_torles.Text = "Törlés";
            this.button_torles.UseVisualStyleBackColor = true;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 575);
            this.Controls.Add(this.button_torles);
            this.Controls.Add(this.button_modosit);
            this.Controls.Add(this.button_olvas);
            this.Controls.Add(this.button_uj);
            this.Controls.Add(this.groupBox1_kivalasztott_tag);
            this.Controls.Add(this.Tagok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1_kivalasztott_tag.ResumeLayout(false);
            this.groupBox1_kivalasztott_tag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Tagok;
        private System.Windows.Forms.GroupBox groupBox1_kivalasztott_tag;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label_belepes;
        private System.Windows.Forms.ComboBox comboBox_ertekeles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_erdeklodes;
        private System.Windows.Forms.Button button_uj;
        private System.Windows.Forms.Button button_olvas;
        private System.Windows.Forms.Button button_modosit;
        private System.Windows.Forms.Button button_torles;
    }
}

