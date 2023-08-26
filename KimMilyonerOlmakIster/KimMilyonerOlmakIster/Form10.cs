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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kardeş Katilini hangi padişah kaldırmıştır";
            btnA.Text = "1.Ahmet";
            btnB.Text = "2.Mustafa";
            btnC.Text = "Fatih Sultan Mehmet";
            btnD.Text = "Kanuni Sultan Süleyman";
            lbl1000.BackColor = Color.Green;
            lbl2000.BackColor = Color.Green;
            lbl5000.BackColor = Color.Green;
            lbl10000.BackColor = Color.Green;
            lbl20000.BackColor = Color.Green;
            lbl50000.BackColor = Color.Green;
            lbl100000.BackColor = Color.Green;
            lbl200000.BackColor = Color.Green;
            lbl500000.BackColor = Color.Yellow;
        }

        private void pbx2_Click(object sender, EventArgs e)
        {
            btnB.Visible = false;
        }

        private void pbx50_Click_1(object sender, EventArgs e)
        {

            btnD.Visible = false;
            btnC.Visible = false;
        }

        private void pbxpass_Click(object sender, EventArgs e)
        {
            Form11 fr = new Form11();
            fr.Show();
            this.Hide();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Green;
            Form11 fr = new Form11();
            fr.Show();
            this.Hide();
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

            btnD.BackColor = Color.Red;
            MessageBox.Show("Yanlış Cevap Elendiniz");
            this.Close();
        }
    }
}
