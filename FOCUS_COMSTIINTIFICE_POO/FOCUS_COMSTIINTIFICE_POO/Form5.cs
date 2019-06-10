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
    public partial class F5 : Form
    {
        public F5()
        {
            InitializeComponent();
        }
        public static int scor4 = F4.scor3;
        private void F5_Load(object sender, EventArgs e)
        {
            label1.Text = (F1.nume + " ESTI LA NIVELUL 4 AL JOCULUI FOCUS!");
            var lv4 = label24.Location;
            lv4.Offset(30, 85);
            Cursor.Position = PointToScreen(lv4);
            label148.Text = ("SCORUL TAU ESTE " + F4.scor3);
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void F5_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ai intrat pe partea rosie !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv4 = label24.Location;
            lv4.Offset(30, 85);
            Cursor.Position = PointToScreen(lv4);
            label148.Text = ("SCORUL TAU ESTE " + (++scor4).ToString());
        }

        private void label147_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era chiar langa tine usa ! Felicitari! Ai terminat NIVELUL 4 !", "NIVELUL 4", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F6 f6 = new F6();
            f6.Show();
            this.Hide();
        }

        private void label141_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Trebuie sa fie undeva !", "Mai cauta !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var lv4 = label24.Location;
            lv4.Offset(30, 85);
            Cursor.Position = PointToScreen(lv4);
            label148.Text = ("SCORUL TAU ESTE " + (++scor4).ToString());
        }

        private void label142_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Infundatura !", "Mai cauta !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var lv4 = label24.Location;
            lv4.Offset(30, 85);
            Cursor.Position = PointToScreen(lv4);
            label148.Text = ("SCORUL TAU ESTE " + (++scor4).ToString());
        }

        private void label143_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Aici este o camera goala !", "Mai cauta !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var lv4 = label24.Location;
            lv4.Offset(30, 85);
            Cursor.Position = PointToScreen(lv4);
            label148.Text = ("SCORUL TAU ESTE " + (++scor4).ToString());
        }

        private void label145_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Usa asta este incuiata !", "Mai cauta !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var lv4 = label24.Location;
            lv4.Offset(30, 85);
            Cursor.Position = PointToScreen(lv4);
            label148.Text = ("SCORUL TAU ESTE " + (++scor4).ToString());
        }

        private void label146_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Aici nu e nicio usa !", "Mai cauta !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var lv4 = label24.Location;
            lv4.Offset(30, 85);
            Cursor.Position = PointToScreen(lv4);
            label148.Text = ("SCORUL TAU ESTE " + (++scor4).ToString());
        }

        private void label144_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Hmm. Asta nu pare a fi iesirea !", "Mai cauta !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var lv4 = label24.Location;
            lv4.Offset(30, 85);
            Cursor.Position = PointToScreen(lv4);
            label148.Text = ("SCORUL TAU ESTE " + (++scor4).ToString());
        }
    }
}
