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
    public partial class F10 : Form
    {
        public F10()
        {
            InitializeComponent();
        }
        public static int scor9 = F9.scor8;

        int pasi = -2;
        int originalX;
        
        private void F10_Load(object sender, EventArgs e)
        {
            label1.Text = (F1.nume + " ESTI LA NIVELUL 9 AL JOCULUI FOCUS!");
            var lv9 = label3.Location;
            lv9.Offset(15, 20);
            Cursor.Position = PointToScreen(lv9);
            label24.Text = ("SCORUL TAU ESTE " + F9.scor8);

            originalX = label37.Location.X;
            originalX = label34.Location.X;
            originalX = label48.Location.X;

            originalX = label68.Location.X;
            originalX = label61.Location.X;
            originalX = label66.Location.X;
            originalX = label64.Location.X;
            originalX = label63.Location.X;

            originalX = label67.Location.X;
            originalX = label65.Location.X;
            originalX = label62.Location.X;
        }

        private void F10_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ai intrat pe partea rosie !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv9 = label3.Location;
            lv9.Offset(15, 20);
            Cursor.Position = PointToScreen(lv9);
            label24.Text = ("SCORUL TAU ESTE " + (++scor9).ToString());
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari! Ai terminat NIVELUL 9 !", "NIVELUL 9", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F11 f11 = new F11();
            f11.Show();
            this.Hide();
        }

        private void WALL_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Te-ai lovit de zid !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv9 = label3.Location;
            lv9.Offset(35, 80);
            Cursor.Position = PointToScreen(lv9);
            label24.Text = ("SCORUL TAU ESTE " + (++scor9).ToString());
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            label37.Location = new Point(label37.Location.X + pasi, label37.Location.Y);
            label34.Location = new Point(label34.Location.X + pasi, label34.Location.Y);
            label48.Location = new Point(label48.Location.X + pasi, label48.Location.Y);
            
            if (label37.Location.X <= label46.Location.X)
            {
                pasi = 2;
            }
            else if (label37.Location.X >= originalX)
            {
                pasi = -2;
            }
            else if (label34.Location.X <= label43.Location.X)
            {
                pasi = 2;
            }
            else if (label34.Location.X >= originalX)
            {
                pasi = -2;
            }
            else if (label48.Location.X <= label20.Location.X)
            {
                pasi = 2;
            }
            else if (label48.Location.X >= originalX)
            {
                pasi = -2;
            }
            
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            label68.Location = new Point(label68.Location.X + pasi, label68.Location.Y);
            label61.Location = new Point(label61.Location.X + pasi, label61.Location.Y);
            label66.Location = new Point(label66.Location.X + pasi, label66.Location.Y);
            label64.Location = new Point(label64.Location.X + pasi, label64.Location.Y);
            label63.Location = new Point(label63.Location.X + pasi, label63.Location.Y);
            label67.Location = new Point(label67.Location.X + pasi, label67.Location.Y);
            label65.Location = new Point(label65.Location.X + pasi, label65.Location.Y);
            label62.Location = new Point(label62.Location.X + pasi, label62.Location.Y);


            if (label68.Location.X <= label16.Location.X)
            {
                pasi = 2;
            }
            else if (label68.Location.X >= originalX)
            {
                pasi = -2;
            }
            else if (label61.Location.X <= label16.Location.X)
            {
                pasi = 2;
            }
            else if (label61.Location.X >= originalX)
            {
                pasi = -2;
            }
            else if (label66.Location.X <= label16.Location.X)
            {
                pasi = 2;
            }
            else if (label66.Location.X >= originalX)
            {
                pasi = -2;
            }
            else if (label64.Location.X <= label16.Location.X)
            {
                pasi = 2;
            }
            else if (label64.Location.X >= originalX)
            {
                pasi = -2;
            }
            else if (label63.Location.X <= label16.Location.X)
            {
                pasi = 2;
            }
            else if (label63.Location.X >= originalX)
            {
                pasi = -2;
            }
            else if (label67.Location.X <= label16.Location.X)
            {
                pasi = 2;
            }
            else if (label67.Location.X >= originalX)
            {
                pasi = -2;
            }
            else if (label65.Location.X <= label16.Location.X)
            {
                pasi = 2;
            }
            else if (label65.Location.X >= originalX)
            {
                pasi = -2;
            }
            else if (label62.Location.X <= label16.Location.X)
            {
                pasi = 2;
            }
            else if (label62.Location.X >= originalX)
            {
                pasi = -2;
            }
        }
    }
}
