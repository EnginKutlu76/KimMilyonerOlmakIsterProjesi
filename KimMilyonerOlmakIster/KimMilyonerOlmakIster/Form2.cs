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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Türkiyenin Başkenti Neresidir";
            btnA.Text = "Ankara";
            btnB.Text = "Kayseri";
            btnC.Text = "Manisa";
            btnD.Text = "Iğdır";
            lbl1000.BackColor = Color.Yellow;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Green;
            Form3 fr = new Form3();
            fr.Show();
            this.Hide();
        }

        private void btnB_Click(object sender, EventArgs e)
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

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }

        private void pbx2_Click(object sender, EventArgs e)
        {
            btnD.Visible = false;
        }

        private void pbx50_Click(object sender, EventArgs e)
        {
            btnB.Visible = false;
            btnC.Visible = false;
        }
    }
}
