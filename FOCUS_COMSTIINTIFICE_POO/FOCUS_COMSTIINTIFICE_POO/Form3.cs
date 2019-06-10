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
    public partial class F3 : Form
    {
        public F3()
        {
            InitializeComponent();
        }
        public static int scor2 = F2.scor1;
        private void F3_Load(object sender, EventArgs e)
        {
            label1.Text = (F1.nume + " ESTI LA NIVELUL 2 AL JOCULUI FOCUS!");
            var lv2 = label4.Location;
            lv2.Offset(15, 15);
            Cursor.Position = PointToScreen(lv2);
            label30.Text = ("SCORUL TAU ESTE "+F2.scor1);
        }

        private void F3_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ai intrat pe partea rosie !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv2 = label4.Location;
            lv2.Offset(15, 15);
            Cursor.Position = PointToScreen(lv2);
            label30.Text = ("SCORUL TAU ESTE " + (++scor2).ToString());
        }      
        private void label29_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari! Ai terminat NIVELUL 2 !", "NIVELUL 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F4 f4 = new F4();
            f4.Show();
            this.Hide();
        }
    
        
    }
}
