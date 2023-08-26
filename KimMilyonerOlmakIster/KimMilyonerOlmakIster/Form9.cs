using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KimMilyonerOlmakIster
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "hangi kelime 2 hecelidir";
            btnA.Text = "merak";
            btnB.Text = "tazmanya";
            btnC.Text = "Türkiye";
            btnD.Text = "kalemlik";
            lbl1000.BackColor = Color.Green;
            lbl2000.BackColor = Color.Green;
            lbl5000.BackColor = Color.Green;
            lbl10000.BackColor = Color.Green;
            lbl20000.BackColor = Color.Green;
            lbl50000.BackColor = Color.Green;
            lbl100000.BackColor = Color.Green;
            lbl200000.BackColor = Color.Yellow;
        }
        private void pbx2_Click_1(object sender, EventArgs e)
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
            Form10 fr = new Form10();
            fr.Show();
            this.Hide();
        }

        private void btnA_Click_1(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Green;
            Form10 fr = new Form10();
            fr.Show();
            this.Hide();
        }

        private void btnB_Click_1(object sender, EventArgs e)
        {
            btnB.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
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
