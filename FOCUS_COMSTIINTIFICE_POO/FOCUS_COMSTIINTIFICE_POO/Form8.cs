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
    public partial class F8 : Form
    {
        public F8()
        {
            InitializeComponent();
        }
        int pasi = -4;       
        int originalX;
        public static int scor7 = F7.scor6;

        private void F8_Load(object sender, EventArgs e)
        {
            label1.Text = (F1.nume + " ESTI LA NIVELUL 7 AL JOCULUI FOCUS!");
            var lv7 = label3.Location;
            lv7.Offset(15, 15);
            Cursor.Position = PointToScreen(lv7);
            originalX = label6.Location.X;
            originalX = label7.Location.X;
            originalX = label11.Location.X;
            originalX = label10.Location.X;
            label5.Text = ("SCORUL TAU ESTE " + F7.scor6);
        }

        private void F8_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ai intrat pe partea rosie !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv7 = label3.Location;
            lv7.Offset(15, 15);
            Cursor.Position = PointToScreen(lv7);
            label5.Text = ("SCORUL TAU ESTE " + (++scor7).ToString());
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari! Ai terminat NIVELUL 7 !", "NIVELUL 7", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F9 f9 = new F9();
            f9.Show();
            this.Hide();
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            label6.Location = new Point(label6.Location.X + pasi, label6.Location.Y);
            label7.Location = new Point(label7.Location.X + pasi, label7.Location.Y);
            label11.Location = new Point(label11.Location.X + pasi, label11.Location.Y);
            label10.Location = new Point(label10.Location.X + pasi, label10.Location.Y);

            if (label6.Location.X <= label3.Location.X)
            {
                pasi = 4;
            }
            else if(label6.Location.X >= originalX)
            {
                pasi = -4;
            }
            

            if (label7.Location.X <= label4.Location.X)
            {
                pasi = 4;
            }
            else if (label7.Location.X >= originalX)
            {
                pasi = -4;
            }

            if (label11.Location.X <= label9.Location.X)
            {
                pasi = 4;
            }
            else if (label11.Location.X >= originalX)
            {
                pasi = -4;
            }

            if (label10.Location.X <= label21.Location.X)
            {
                pasi = 4;
            }
            else if (label10.Location.X >= originalX)
            {
                pasi = -4;
            }

        }


    }
}
