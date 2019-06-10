
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
    public partial class F11 : Form
    {
        public F11()
        {
            InitializeComponent();
        }

        public static int scor10 = F10.scor9;

        private void F11_Load(object sender, EventArgs e)
        {
            label1.Text = (F1.nume + " ESTI LA NIVELUL 10 AL JOCULUI FOCUS!");
            var lv10 = label3.Location;
            lv10.Offset(35, 35);
            Cursor.Position = PointToScreen(lv10);
            label24.Text = ("SCORUL TAU ESTE " + F10.scor9);


        }

        private void WALL_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Te-ai lovit de zid !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            var lv10 = label3.Location;
            lv10.Offset(35, 35);
            Cursor.Position = PointToScreen(lv10);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari! Ai terminat NIVELUL 10 !", "NIVELUL 10", MessageBoxButtons.OK, MessageBoxIcon.Information);
            F12 f12 = new F12();
            f12.Show();
            this.Hide();
        }

        private void label50_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label50.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SPAWN SETAT", "FOCUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SPAWN SETAT", "FOCUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var mine = button2.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
        }

        private void label239_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label239.BackColor = Color.Yellow;
        }

        private void label49_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label49.BackColor = Color.Yellow;
        }

        private void label54_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label54.BackColor = Color.Yellow;
        }

        private void label55_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label55.BackColor = Color.Yellow;
        }

        private void label42_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label42.BackColor = Color.Yellow;
        }

        private void label57_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label57.BackColor = Color.Yellow;
        }

        private void label45_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label45.BackColor = Color.Yellow;
        }

        private void label56_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label56.BackColor = Color.Yellow;
        }

        private void label52_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label52.BackColor = Color.Yellow;
        }

        private void label58_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label58.BackColor = Color.Yellow;
        }

        private void label61_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label61.BackColor = Color.Yellow;
        }

        private void label46_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label46.BackColor = Color.Yellow;
        }

        private void label62_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label62.BackColor = Color.Yellow;
        }

        private void label68_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label68.BackColor = Color.Yellow;
        }

        private void label64_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label64.BackColor = Color.Yellow;
        }

        private void label69_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label69.BackColor = Color.Yellow;
        }

        private void label63_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label63.BackColor = Color.Yellow;
        }

        private void label53_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label53.BackColor = Color.Yellow;
        }

        private void label70_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label70.BackColor = Color.Yellow;
        }

        private void label65_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label65.BackColor = Color.Yellow;
        }

        private void label71_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label71.BackColor = Color.Yellow;
        }

        private void label59_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label59.BackColor = Color.Yellow;
        }

        private void label66_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label66.BackColor = Color.Yellow;
        }

        private void label72_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label72.BackColor = Color.Yellow;
        }

        private void label75_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label75.BackColor = Color.Yellow;
        }

        private void label60_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label60.BackColor = Color.Yellow;
        }

        private void label76_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label76.BackColor = Color.Yellow;
        }

        private void label110_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label110.BackColor = Color.Yellow;
        }

        private void label67_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label67.BackColor = Color.Yellow;
        }

        private void label77_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label77.BackColor = Color.Yellow;
        }

        private void label111_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label111.BackColor = Color.Yellow;
        }

        private void label112_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label112.BackColor = Color.Yellow;
        }

        private void label79_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label79.BackColor = Color.Yellow;
        }

        private void label113_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label113.BackColor = Color.Yellow;
        }

        private void label73_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label73.BackColor = Color.Yellow;
        }

        private void label85_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label85.BackColor = Color.Yellow;
        }

        private void label108_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label108.BackColor = Color.Yellow;
        }

        private void label114_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label114.BackColor = Color.Yellow;
        }

        private void label74_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label74.BackColor = Color.Yellow;
        }

        private void label104_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label104.BackColor = Color.Yellow;
        }

        private void label89_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label89.BackColor = Color.Yellow;
        }

        private void label106_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label106.BackColor = Color.Yellow;
        }

        private void label90_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label90.BackColor = Color.Yellow;
        }

        private void label109_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label109.BackColor = Color.Yellow;
        }

        private void label105_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label105.BackColor = Color.Yellow;
        }

        private void label92_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label92.BackColor = Color.Yellow;
        }

        private void label91_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label91.BackColor = Color.Yellow;
        }

        private void label101_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label101.BackColor = Color.Yellow;
        }

        private void label81_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label81.BackColor = Color.Yellow;
        }

        private void label107_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label107.BackColor = Color.Yellow;
        }

        private void label87_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label87.BackColor = Color.Yellow;
        }

        private void label93_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label93.BackColor = Color.Yellow;
        }

        private void label96_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label96.BackColor = Color.Yellow;
        }

        private void label97_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label97.BackColor = Color.Yellow;
        }

        private void label102_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label102.BackColor = Color.Yellow;
        }

        private void label98_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label98.BackColor = Color.Yellow;
        }

        private void label99_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label99.BackColor = Color.Yellow;
        }

        private void label88_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label88.BackColor = Color.Yellow;
        }

        private void label94_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label94.BackColor = Color.Yellow;
        }

        private void label100_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button1.Location;
            mine.Offset(20, 10);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label100.BackColor = Color.Yellow;
        }
        //A DOUA COLOANA DE MINE (LABEL-URI CARORA LI SE SCHIMBA CULOAREA PRIN COMANDA MOUSE ENTER
        private void label116_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label116.BackColor = Color.Yellow;
        }

        private void label135_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label135.BackColor = Color.Yellow;
        }

        private void label129_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label129.BackColor = Color.Yellow;
        }

        private void label128_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label128.BackColor = Color.Yellow;
        }

        private void label122_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label122.BackColor = Color.Yellow;
        }

        private void label133_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label133.BackColor = Color.Yellow;
        }

        private void label137_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label137.BackColor = Color.Yellow;
        }

        private void label115_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label115.BackColor = Color.Yellow;
        }

        private void label134_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label134.BackColor = Color.Yellow;
        }

        private void label127_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label127.BackColor = Color.Yellow;
        }

        private void label132_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label132.BackColor = Color.Yellow;
        }

        private void label126_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label126.BackColor = Color.Yellow;
        }

        private void label131_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label131.BackColor = Color.Yellow;
        }

        private void label120_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label120.BackColor = Color.Yellow;
        }

        private void label119_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label119.BackColor = Color.Yellow;
        }

        private void label125_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label125.BackColor = Color.Yellow;
        }

        private void label124_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label124.BackColor = Color.Yellow;
        }

        private void label136_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label136.BackColor = Color.Yellow;
        }

        private void label142_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label142.BackColor = Color.Yellow;
        }

        private void label118_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label118.BackColor = Color.Yellow;
        }

        private void label158_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label158.BackColor = Color.Yellow;
        }

        private void label117_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label117.BackColor = Color.Yellow;
        }

        private void label141_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label141.BackColor = Color.Yellow;
        }

        private void label151_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label151.BackColor = Color.Yellow;
        }

        private void label140_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label140.BackColor = Color.Yellow;
        }

        private void label144_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label144.BackColor = Color.Yellow;
        }

        private void label139_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label139.BackColor = Color.Yellow;
        }

        private void label138_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label138.BackColor = Color.Yellow;
        }

        private void label157_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label157.BackColor = Color.Yellow;
        }

        private void label163_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label163.BackColor = Color.Yellow;
        }

        private void label150_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label150.BackColor = Color.Yellow;
        }

        private void label156_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label156.BackColor = Color.Yellow;
        }

        private void label143_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label143.BackColor = Color.Yellow;
        }

        private void label162_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label162.BackColor = Color.Yellow;
        }

        private void label164_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label164.BackColor = Color.Yellow;
        }

        private void label149_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label149.BackColor = Color.Yellow;
        }

        private void label160_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label160.BackColor = Color.Yellow;
        }

        private void label155_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label155.BackColor = Color.Yellow;
        }

        private void label159_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label159.BackColor = Color.Yellow;
        }

        private void label153_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label153.BackColor = Color.Yellow;
        }

        private void label147_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label147.BackColor = Color.Yellow;
        }

        private void label152_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label152.BackColor = Color.Yellow;
        }

        private void label161_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label161.BackColor = Color.Yellow;
        }

        private void label169_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label168.BackColor = Color.Yellow;
        }

        private void label145_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label145.BackColor = Color.Yellow;
        }

        private void label178_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label178.BackColor = Color.Yellow;
        }

        private void label168_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label168.BackColor = Color.Yellow;
        }

        private void label171_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label171.BackColor = Color.Yellow;
        }

        private void label167_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label167.BackColor = Color.Yellow;
        }

        private void label229_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label229.BackColor = Color.Yellow;
        }

        private void label166_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label166.BackColor = Color.Yellow;
        }

        private void label177_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label177.BackColor = Color.Yellow;
        }

        private void label165_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Era o mina ! BOOM !", "Ai pierdut !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var mine = button2.Location;
            mine.Offset(20, 15);
            Cursor.Position = PointToScreen(mine);
            label24.Text = ("SCORUL TAU ESTE " + (++scor10).ToString());
            label165.BackColor = Color.Yellow;
        }
    }
}
