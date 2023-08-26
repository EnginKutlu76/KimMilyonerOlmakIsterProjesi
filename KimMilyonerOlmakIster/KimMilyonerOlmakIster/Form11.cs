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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kuran'ın ilk suresi hangisidir";
            btnA.Text = "Bakara";
            btnB.Text = "Yasin";
            btnC.Text = "Fatiha";
            btnD.Text = "Kevser";
            lbl1000.BackColor = Color.Green;
            lbl2000.BackColor = Color.Green;
            lbl5000.BackColor = Color.Green;
            lbl10000.BackColor = Color.Green;
            lbl20000.BackColor = Color.Green;
            lbl50000.BackColor = Color.Green;
            lbl100000.BackColor = Color.Green;
            lbl200000.BackColor = Color.Green;
            lbl500000.BackColor = Color.Green;
            lbl1000000.BackColor = Color.Yellow;
        }

        private void pbx2_Click(object sender, EventArgs e)
        {
            btnB.Visible = false;
        }
        private void pbx50_Click(object sender, EventArgs e)
        {
            btnD.Visible = false;
            btnC.Visible = false;
        }

        private void pbxpass_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler 1 Milyon Tl kazandınız");
            this.Close();
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
            MessageBox.Show("Tebrikler 1 Milyon Tl kazandınız");
            this.Close();

        }

        private void btnD_Click_1(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }
    }
}
