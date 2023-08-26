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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Hangisi bir meyvedi";
            btnA.Text = "Domates";
            btnB.Text = "Patlıcan";
            btnC.Text = "Elma";
            btnD.Text = "Havuç";
            lbl1000.BackColor = Color.Green;
            lbl2000.BackColor = Color.Green;
            lbl5000.BackColor = Color.Yellow;
        }


        private void btnA_Click(object sender, EventArgs e)
        {
            btnB.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {

            btnA.BackColor = Color.Green;
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }

        private void btnD_Click_1(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }

        private void pbx2_Click_1(object sender, EventArgs e)
        {
            btnB.Visible = false;
        }

        private void pbx50_Click_1(object sender, EventArgs e)
        {
            btnA.Visible = false;
            btnD.Visible = false;
        }

       

        private void pbxpass_Click(object sender, EventArgs e)
        {

            Form5 fr = new Form5();
            fr.Show();
            this.Hide();
        }

        private void btnB_Click(object sender, EventArgs e)
        {

            btnC.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }
    }
}
