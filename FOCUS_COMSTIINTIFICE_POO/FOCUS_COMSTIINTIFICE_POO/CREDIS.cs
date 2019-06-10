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
    public partial class CREDIS : Form
    {
        public CREDIS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            F1 FORM1 = new F1();
            FORM1.Show();
            this.Hide();
        }
    }
}
