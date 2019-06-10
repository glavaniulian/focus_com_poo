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
    public partial class REGULI : Form
    {
        public REGULI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            F1 FORM1 = new F1();
            FORM1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FI ATENT LA DETALII, EXISTA CAPCANE IN JOC !", "FOCUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
