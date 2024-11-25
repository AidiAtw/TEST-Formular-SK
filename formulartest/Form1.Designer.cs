namespace formulartest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxJmenoPrijmeni = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxHeslo = new TextBox();
            label4 = new Label();
            richTextBoxVystup = new RichTextBox();
            label5 = new Label();
            checkBoxSport = new CheckBox();
            checkBoxInternet = new CheckBox();
            checkBoxDivadlo = new CheckBox();
            checkBoxHudba = new CheckBox();
            checkBoxZvirata = new CheckBox();
            checkBoxKnihy = new CheckBox();
            label6 = new Label();
            radioButtonMuz = new RadioButton();
            radioButtonZena = new RadioButton();
            label7 = new Label();
            listBoxJazyk = new ListBox();
            comboBoxJazykk = new ComboBox();
            buttonOK = new Button();
            buttonVymazat = new Button();
            SuspendLayout();
            // 
            // textBoxJmenoPrijmeni
            // 
            textBoxJmenoPrijmeni.Location = new Point(205, 23);
            textBoxJmenoPrijmeni.Name = "textBoxJmenoPrijmeni";
            textBoxJmenoPrijmeni.Size = new Size(249, 23);
            textBoxJmenoPrijmeni.TabIndex = 0;
            textBoxJmenoPrijmeni.TextChanged += textBoxJmenoPrijmeni_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Jméno a Příjmení:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "e-mail:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(205, 52);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(249, 23);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.Text = "@";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "heslo:";
            // 
            // textBoxHeslo
            // 
            textBoxHeslo.Location = new Point(205, 81);
            textBoxHeslo.Name = "textBoxHeslo";
            textBoxHeslo.PasswordChar = '*';
            textBoxHeslo.Size = new Size(249, 23);
            textBoxHeslo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Text:";
            // 
            // richTextBoxVystup
            // 
            richTextBoxVystup.Enabled = false;
            richTextBoxVystup.Location = new Point(12, 139);
            richTextBoxVystup.Name = "richTextBoxVystup";
            richTextBoxVystup.Size = new Size(442, 103);
            richTextBoxVystup.TabIndex = 7;
            richTextBoxVystup.Text = "text area";
            richTextBoxVystup.TextChanged += richTextBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 254);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "koníčky";
            // 
            // checkBoxSport
            // 
            checkBoxSport.AutoSize = true;
            checkBoxSport.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxSport.Checked = true;
            checkBoxSport.CheckState = CheckState.Checked;
            checkBoxSport.Location = new Point(12, 272);
            checkBoxSport.Name = "checkBoxSport";
            checkBoxSport.Size = new Size(53, 19);
            checkBoxSport.TabIndex = 9;
            checkBoxSport.Text = "sport";
            checkBoxSport.UseVisualStyleBackColor = true;
            // 
            // checkBoxInternet
            // 
            checkBoxInternet.AutoSize = true;
            checkBoxInternet.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxInternet.Checked = true;
            checkBoxInternet.CheckState = CheckState.Checked;
            checkBoxInternet.Location = new Point(12, 297);
            checkBoxInternet.Name = "checkBoxInternet";
            checkBoxInternet.Size = new Size(67, 19);
            checkBoxInternet.TabIndex = 10;
            checkBoxInternet.Text = "internet";
            checkBoxInternet.UseVisualStyleBackColor = true;
            // 
            // checkBoxDivadlo
            // 
            checkBoxDivadlo.AutoSize = true;
            checkBoxDivadlo.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxDivadlo.Location = new Point(85, 297);
            checkBoxDivadlo.Name = "checkBoxDivadlo";
            checkBoxDivadlo.Size = new Size(65, 19);
            checkBoxDivadlo.TabIndex = 12;
            checkBoxDivadlo.Text = "divadlo";
            checkBoxDivadlo.UseVisualStyleBackColor = true;
            // 
            // checkBoxHudba
            // 
            checkBoxHudba.AutoSize = true;
            checkBoxHudba.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxHudba.Location = new Point(71, 272);
            checkBoxHudba.Name = "checkBoxHudba";
            checkBoxHudba.Size = new Size(60, 19);
            checkBoxHudba.TabIndex = 11;
            checkBoxHudba.Text = "hudba";
            checkBoxHudba.UseVisualStyleBackColor = true;
            // 
            // checkBoxZvirata
            // 
            checkBoxZvirata.AutoSize = true;
            checkBoxZvirata.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxZvirata.Location = new Point(156, 297);
            checkBoxZvirata.Name = "checkBoxZvirata";
            checkBoxZvirata.Size = new Size(60, 19);
            checkBoxZvirata.TabIndex = 13;
            checkBoxZvirata.Text = "zvirata";
            checkBoxZvirata.UseVisualStyleBackColor = true;
            // 
            // checkBoxKnihy
            // 
            checkBoxKnihy.AutoSize = true;
            checkBoxKnihy.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxKnihy.Location = new Point(137, 272);
            checkBoxKnihy.Name = "checkBoxKnihy";
            checkBoxKnihy.Size = new Size(55, 19);
            checkBoxKnihy.TabIndex = 14;
            checkBoxKnihy.Text = "knihy";
            checkBoxKnihy.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 325);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 15;
            label6.Text = "pohlaví:";
            // 
            // radioButtonMuz
            // 
            radioButtonMuz.AutoSize = true;
            radioButtonMuz.CheckAlign = ContentAlignment.MiddleRight;
            radioButtonMuz.Checked = true;
            radioButtonMuz.Location = new Point(12, 343);
            radioButtonMuz.Name = "radioButtonMuz";
            radioButtonMuz.Size = new Size(48, 19);
            radioButtonMuz.TabIndex = 16;
            radioButtonMuz.TabStop = true;
            radioButtonMuz.Text = "muž";
            radioButtonMuz.UseVisualStyleBackColor = true;
            // 
            // radioButtonZena
            // 
            radioButtonZena.AutoSize = true;
            radioButtonZena.CheckAlign = ContentAlignment.MiddleRight;
            radioButtonZena.Location = new Point(66, 343);
            radioButtonZena.Name = "radioButtonZena";
            radioButtonZena.Size = new Size(49, 19);
            radioButtonZena.TabIndex = 17;
            radioButtonZena.TabStop = true;
            radioButtonZena.Text = "žena";
            radioButtonZena.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 404);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 18;
            label7.Text = "Jazyk:";
            // 
            // listBoxJazyk
            // 
            listBoxJazyk.FormattingEnabled = true;
            listBoxJazyk.ItemHeight = 15;
            listBoxJazyk.Items.AddRange(new object[] { "český", "ruský", "anglický" });
            listBoxJazyk.Location = new Point(252, 377);
            listBoxJazyk.Name = "listBoxJazyk";
            listBoxJazyk.Size = new Size(120, 94);
            listBoxJazyk.TabIndex = 19;
            listBoxJazyk.SelectedIndexChanged += listBox1Jazyk_SelectedIndexChanged;
            // 
            // comboBoxJazykk
            // 
            comboBoxJazykk.FormattingEnabled = true;
            comboBoxJazykk.Items.AddRange(new object[] { "český", "ruský", "anglický" });
            comboBoxJazykk.Location = new Point(55, 401);
            comboBoxJazykk.Name = "comboBoxJazykk";
            comboBoxJazykk.Size = new Size(84, 23);
            comboBoxJazykk.TabIndex = 20;
            comboBoxJazykk.SelectedIndexChanged += comboBoxJazyk_SelectedIndexChanged;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(12, 467);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(31, 23);
            buttonOK.TabIndex = 21;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonVymazat
            // 
            buttonVymazat.Location = new Point(48, 467);
            buttonVymazat.Name = "buttonVymazat";
            buttonVymazat.Size = new Size(65, 23);
            buttonVymazat.TabIndex = 22;
            buttonVymazat.Text = "Vymazat";
            buttonVymazat.UseVisualStyleBackColor = true;
            buttonVymazat.Click += buttonVymazat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 512);
            Controls.Add(buttonVymazat);
            Controls.Add(buttonOK);
            Controls.Add(comboBoxJazykk);
            Controls.Add(listBoxJazyk);
            Controls.Add(label7);
            Controls.Add(radioButtonZena);
            Controls.Add(radioButtonMuz);
            Controls.Add(label6);
            Controls.Add(checkBoxKnihy);
            Controls.Add(checkBoxZvirata);
            Controls.Add(checkBoxDivadlo);
            Controls.Add(checkBoxHudba);
            Controls.Add(checkBoxInternet);
            Controls.Add(checkBoxSport);
            Controls.Add(label5);
            Controls.Add(richTextBoxVystup);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxHeslo);
            Controls.Add(label2);
            Controls.Add(textBoxEmail);
            Controls.Add(label1);
            Controls.Add(textBoxJmenoPrijmeni);
            Name = "Form1";
            Text = "TEST-Formular-Slovak";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxJmenoPrijmeni;
        private Label label1;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxHeslo;
        private Label label4;
        private RichTextBox richTextBoxVystup;
        private Label label5;
        private CheckBox checkBoxSport;
        private CheckBox checkBoxInternet;
        private CheckBox checkBoxDivadlo;
        private CheckBox checkBoxHudba;
        private CheckBox checkBoxZvirata;
        private CheckBox checkBoxKnihy;
        private Label label6;
        private RadioButton radioButtonMuz;
        private RadioButton radioButtonZena;
        private Label label7;
        private ListBox listBoxJazyk;
        private ComboBox comboBoxJazykk;
        private Button buttonOK;
        private Button buttonVymazat;
    }
}
