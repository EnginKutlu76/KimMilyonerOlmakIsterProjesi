using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimMilyonerOlmakIster
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Yerçekimini kim bulmuştur";
            btnA.Text = "Einstein";
            btnB.Text = "ibni sina";
            btnC.Text = "Newton";
            btnD.Text = "Marie Cruie";
            lbl1000.BackColor = Color.Green;
            lbl2000.BackColor = Color.Green;
            lbl5000.BackColor = Color.Green;
            lbl10000.BackColor = Color.Yellow;
        }



        private void pbx2_Click(object sender, EventArgs e)
        {
            btnB.Visible = false;
        }

        private void pbx50_Click(object sender, EventArgs e)
        {

            btnA.Visible = false;
            btnD.Visible = false;
        }

        private void pbxpass_Click_1(object sender, EventArgs e)
        {
            Form6 fr = new Form6();
            fr.Show();
            this.Hide();
        }

        private void btnA_Click_1(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }

        private void btnB_Click_1(object sender, EventArgs e)
        {
            btnB.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.BackColor = Color.Green;
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }

        private void btnD_Click_2(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }
    }
}
