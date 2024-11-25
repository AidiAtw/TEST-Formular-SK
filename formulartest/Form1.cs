namespace formulartest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVymazat_Click(object sender, EventArgs e)
        {
            textBoxJmenoPrijmeni.Text = string.Empty;
            textBoxEmail.Text = "@";
            textBoxHeslo.Text = string.Empty;

            checkBoxSport.Checked = true;
            checkBoxInternet.Checked = true;
            checkBoxHudba.Checked = false;
            checkBoxDivadlo.Checked = false;
            checkBoxKnihy.Checked = false;
            checkBoxZvirata.Checked = false;

            radioButtonMuz.Checked = true;
            radioButtonZena.Checked = false;

            listBoxJazyk.SelectedIndex = 0;
        }

        private void comboBoxJazyk_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxJazyk.SelectedIndex = comboBoxJazykk.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxJazyk.SelectedIndex = 0;
        }

        private void listBox1Jazyk_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxJazykk.SelectedIndex = listBoxJazyk.SelectedIndex;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string jmenoprijmeni = textBoxJmenoPrijmeni.Text;
            string email = textBoxEmail.Text;
            string heslo = textBoxHeslo.Text;

            if (jmenoprijmeni.Length < 6)
            {
                MessageBox.Show("Platnì vyplòte kolonku Jména a Pøíjmení");
                return;
            }
            else if (email.Length < 6)
            {
                MessageBox.Show("Platnì vyplòte kolonku e-mailu");
                return;
            }
            if (heslo.Length < 6)
            {
                MessageBox.Show("Platnì vyplòte kolonku hesla");
                return;
            }
            else {
            richTextBoxVystup.Text += "\n" + textBoxJmenoPrijmeni.Text + " ; " + textBoxEmail.Text;
            MessageBox.Show("Data byla odeslána");
            }
        }

        private void textBoxJmenoPrijmeni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
