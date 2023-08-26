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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Suyun formülü nedir";
            btnA.Text = "H2O";
            btnB.Text = "O6";
            btnC.Text = "H2SO4";
            btnD.Text = "CACO4";
            lbl1000.BackColor = Color.Green;
            lbl2000.BackColor = Color.Green;
            lbl5000.BackColor = Color.Green;
            lbl10000.BackColor = Color.Green;
            lbl20000.BackColor = Color.Green;
            lbl50000.BackColor = Color.Yellow;
        }
        private void pbx2_Click(object sender, EventArgs e)
        {
            btnB.Visible = false;
        }

        private void pbx50_Click(object sender, EventArgs e)
        {
            btnC.Visible = false;
            btnD.Visible = false;
        }

        private void pbxpass_Click_1(object sender, EventArgs e)
        {
            Form8 fr = new Form8();
            fr.Show();
            this.Hide();
        }

        private void btnA_Click_1(object sender, EventArgs e)
        {

            btnA.BackColor = Color.Green;
            Form8 fr = new Form8();
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
