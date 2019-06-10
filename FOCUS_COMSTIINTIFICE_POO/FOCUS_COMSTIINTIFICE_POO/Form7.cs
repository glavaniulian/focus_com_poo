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
    public partial class F7 : Form
    {
        public F7()
        {
            InitializeComponent();
        }
        public static int scor6 = F6.scor5;
        private void WALL_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Te-ai lovit de zid !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv6 = label4.Location;
            lv6.Offset(15, 15);
            Cursor.Position = PointToScreen(lv6);
            label255.Text = ("SCORUL TAU ESTE " + (++scor6).ToString());
        }

        private void F7_Load(object sender, EventArgs e)
        {
            label1.Text = (F1.nume + " ESTI LA NIVELUL 6 AL JOCULUI FOCUS!");
            var lv6 = label4.Location;
            lv6.Offset(15, 15);
            Cursor.Position = PointToScreen(lv6);
            label255.Text = ("SCORUL TAU ESTE " + F6.scor5);
        }

        private void label142_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari! Ai terminat NIVELUL 6 !", "NIVELUL 6", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F8 f8 = new F8();
            f8.Show();
            this.Hide();
        }
    }
}
