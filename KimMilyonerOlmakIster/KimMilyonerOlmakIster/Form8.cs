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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void pbx2_Click(object sender, EventArgs e)
        {
            btnB.Visible = false;
        }

      
        private void pbxpass_Click(object sender, EventArgs e)
        {
           Form9 fr = new Form9();
            fr.Show();
            this.Hide();
        }
        private void pbx50_Click_1(object sender, EventArgs e)
        {
            btnA.Visible = false;
            btnC.Visible = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {
            btnC.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }

        private void btnD_Click(object sender, EventArgs e)
        {

            btnD.BackColor = Color.Green;
            Form9 fr = new Form9();
            fr.Show();
            this.Hide();
        }

        private void Form8_Load_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "Alinin babasının 4 oğlu var tete mete çeke 4.sü kim";
            btnA.Text = "keke";
            btnB.Text = "dede";
            btnC.Text = "bebe";
            btnD.Text = "Ali";
            lbl1000.BackColor = Color.Green;
            lbl2000.BackColor = Color.Green;
            lbl5000.BackColor = Color.Green;
            lbl10000.BackColor = Color.Green;
            lbl20000.BackColor = Color.Green;
            lbl50000.BackColor = Color.Green;
            lbl100000.BackColor = Color.Yellow;
        }
    }
}
