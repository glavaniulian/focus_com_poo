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
    public partial class F4 : Form
    {
        public F4()
        {
            InitializeComponent();
        }
        public static int scor3 = F3.scor2;
        private void F4_Load(object sender, EventArgs e)
        {
            label1.Text = (F1.nume + " ESTI LA NIVELUL 3 AL JOCULUI FOCUS!");
            var lv3 = label24.Location;
            lv3.Offset(30, 30);
            Cursor.Position = PointToScreen(lv3);
            label60.Text = ("SCORUL TAU ESTE " + F3.scor2);
        }

        private void F4_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ai intrat pe partea rosie !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv3 = label24.Location;
            lv3.Offset(30, 30);
            Cursor.Position = PointToScreen(lv3);
            label60.Text = ("SCORUL TAU ESTE " + (++scor3).ToString());
        }

        private void label59_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari! Ai terminat NIVELUL 3 !", "NIVELUL 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F5 f5 = new F5();
            f5.Show();
            this.Hide();
        }
    }
}
