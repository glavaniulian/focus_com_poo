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
    public partial class CREDIS1 : Form
    {
        public CREDIS1()
        {
            InitializeComponent();
        }

        private void CREDIS1_Load(object sender, EventArgs e)
        {
            label2.Text = (F1.nume + " FELICTARI PENTRU TERMINAREA JOCULUI FOCUS !");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F12 SFARSIT = new F12();
            SFARSIT.Show();
            this.Hide();
        }
    }
}
