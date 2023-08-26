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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }      
        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Almanya Hangi Kıtadadır";
            btnA.Text = "Afrika";
            btnB.Text = "Avrupa";
            btnC.Text = "Asya";
            btnD.Text = "Avusturalya";
            lbl1000.BackColor = Color.Green;
            lbl2000.BackColor = Color.Yellow;
        }


        private void btnA_Click_1(object sender, EventArgs e)
        {            
                btnA.BackColor = Color.Red;
                MessageBox.Show("Yanlış Cevap Elendiniz");
                this.Close();   
        }

        private void btnB_Click_1(object sender, EventArgs e)
        {

            btnB.BackColor = Color.Green;
            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }

        private void btnC_Click_1(object sender, EventArgs e)
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

        private void pbx2_Click_1(object sender, EventArgs e)
        {
            btnD.Visible = false;
        }

        private void pbx50_Click_1(object sender, EventArgs e)
        {
            btnA.Visible = false;
            btnC.Visible = false;
        }

        private void pbxpass_Click_1(object sender, EventArgs e)
        {

            Form4 fr = new Form4();
            fr.Show();
            this.Hide();
        }
    }
}

