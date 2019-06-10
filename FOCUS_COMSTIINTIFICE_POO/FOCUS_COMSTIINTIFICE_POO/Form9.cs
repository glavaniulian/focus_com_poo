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
    public partial class F9 : Form
    {
        public F9()
        {
            InitializeComponent();
        }

        public static int scor8 = F8.scor7;

        private void F9_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ai intrat pe partea rosie !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv8 = label3.Location;
            lv8.Offset(35, 80);
            Cursor.Position = PointToScreen(lv8);
            label24.Text = ("SCORUL TAU ESTE " + (++scor8).ToString());
        }

        int pasi = -2;
        int originalX;

        private void F9_Load(object sender, EventArgs e)
        {
            label1.Text = (F1.nume + " ESTI LA NIVELUL 8 AL JOCULUI FOCUS!");
            var lv8 = label3.Location;
            lv8.Offset(35, 80);
            Cursor.Position = PointToScreen(lv8);
            originalX = label5.Location.X;
            label24.Text = ("SCORUL TAU ESTE " + F8.scor7);
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari! Ai terminat NIVELUL 8 !", "NIVELUL 8", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F10 f10 = new F10();
            f10.Show();
            this.Hide();
        }

        private void WALL_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Te-ai lovit de zid !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv8 = label3.Location;
            lv8.Offset(35, 80);
            Cursor.Position = PointToScreen(lv8);
            label24.Text = ("SCORUL TAU ESTE " + (++scor8).ToString());
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            label5.Location = new Point(label5.Location.X + pasi, label5.Location.Y);

            if (label5.Location.X <= label3.Location.X)
            {
                pasi = 2;
            }
            else if (label5.Location.X >= originalX)
            {
                pasi = -2;
            }
        }
    }
}
