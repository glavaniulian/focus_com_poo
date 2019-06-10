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
    public partial class F6 : Form
    {
        public F6()
        {
            InitializeComponent();
        }
        public static int scor5 = F5.scor4;
        private void F6_Load(object sender, EventArgs e)
        {
            label1.Text = (F1.nume + " ESTI LA NIVELUL 5 AL JOCULUI FOCUS!");
            var lv5 = label4.Location;
            lv5.Offset(15, 15);
            Cursor.Position = PointToScreen(lv5);
            label50.Text = ("SCORUL TAU ESTE " + F5.scor4);
        }

        

        private void WALL_EnterMouse(object sender, EventArgs e)
        {
            MessageBox.Show("Te-ai lovit de zid !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv5 = label4.Location;
            lv5.Offset(15, 15);
            Cursor.Position = PointToScreen(lv5);
            label50.Text = ("SCORUL TAU ESTE " + (++scor5).ToString());
        }

        private void label142_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari! Ai terminat NIVELUL 5 !", "NIVELUL 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F7 f7 = new F7();
            f7.Show();
            this.Hide();
        }
    }
}
