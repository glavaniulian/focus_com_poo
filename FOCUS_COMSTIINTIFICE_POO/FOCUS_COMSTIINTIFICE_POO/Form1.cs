using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOCUS_COMSTIINTIFICE_POO
{
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();
        }
        public static string nume = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 numar;

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("INTRODUCETI UN NUME DE JUCATOR !", "FOCUS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }

                else if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                MessageBox.Show("NUMELE NU POATE CONTINE DOAR SPACE !", "FOCUS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox1.Focus();
                }
                else if (textBox1.Text.Length < 5)
                {
                MessageBox.Show("NUMELE ESTE PREA MIC(MIN 5 CARACTERE) !", "FOCUS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox1.Focus();
                }
                else if (textBox1.Text.Length > 15)
                {
                MessageBox.Show("NUMELE ESTE PREA MARE(MAX 15 CARACTERE) !", "FOCUS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox1.Focus();
                }
                else if (Int64.TryParse(textBox1.Text, out numar))
                {
                MessageBox.Show("NUMELE NU POATE CONTINE DOAR CIFRE !", "FOCUS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox1.Focus();
                }
                
            else 
            {
                nume = textBox1.Text;
                F2 FORM2 = new F2();
                FORM2.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nume = textBox1.Text;
            REGULI R = new REGULI();
            R.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nume = textBox1.Text;
            CREDIS C = new CREDIS();
            C.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult rezultat=MessageBox.Show("Vrei sa inchizi jocul?", "FOCUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

       
    }
}
