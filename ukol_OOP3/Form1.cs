using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol_OOP3
{
    public partial class Form1 : Form
    {
        Auto auto;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

                auto = new Auto(textBox1.Text, Double.Parse(textBox2.Text));
                MessageBox.Show("Byla vytvořena tvoje vysněná kára!", "Úspěšně vytvořeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.Rozjed();
            MessageBox.Show("Auto se rozjelo!", "Jede", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label4.Enabled = true;
            textBox4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                auto.Zastav(Double.Parse(textBox4.Text));
                MessageBox.Show("Auto se zastavilo a ujelo " + auto.VratUjeteKm(),"Auto stojí", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Nezadal jsi žádnou nebo špatnou hodnotu, zkus to ještě jednou!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = auto.ToString();
        }
    }
}
