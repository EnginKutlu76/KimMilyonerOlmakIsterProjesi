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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Dünyanın ilk yazılı antlaşması nedir";
            btnA.Text = "İstanbul Sözleşmesi";
            btnB.Text = "Sevr Antlaşması";
            btnC.Text = "Kadeş Antlaşması";
            btnD.Text = "Lozan Antlaşması";
            lbl1000.BackColor = Color.Green;
            lbl2000.BackColor = Color.Green;
            lbl5000.BackColor = Color.Green;
            lbl10000.BackColor = Color.Green;
            lbl20000.BackColor = Color.Yellow;
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
            Form7 fr = new Form7();
            fr.Show();
            this.Hide();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Red;
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
            btnC.BackColor = Color.Green;
            Form7 fr = new Form7();
            fr.Show();
            this.Hide();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }
    }
}
