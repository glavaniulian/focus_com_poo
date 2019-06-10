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
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
        }
        public static int scor1;
        
        private void F2_Load(object sender, EventArgs e)
        {
            label1.Text = (F1.nume + " ESTI LA NIVELUL 1 AL JOCULUI FOCUS!");
            var lv1 = label3.Location;
            lv1.Offset(25, 25);
            Cursor.Position = PointToScreen(lv1);
            label27.Text = ("SCORUL TAU ESTE 0");
        }

        private void F2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ai intrat pe partea rosie !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv1 = label3.Location;
            lv1.Offset(25, 25);
            Cursor.Position = PointToScreen(lv1);
            label27.Text = ("SCORUL TAU ESTE " + (++scor1).ToString());
        }
        private void label26_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari! Ai terminat NIVELUL 1 !", "NIVELUL 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F3 f3 = new F3();
            f3.Show();
            this.Hide();
        }

        private void label28_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Intra in Modul Prezentare", "FOCUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F9 f9 = new F9();
            f9.Show();
            this.Hide();
        }
    }
        
    
}

