using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace FOCUS_COMSTIINTIFICE_POO
{
    public partial class F12 : Form
    {
        public F12()
        {
            InitializeComponent();
        }

        public static int scorfinal = F11.scor10;

        private void button1_Click(object sender, EventArgs e)
        {
            
            CREDIS1 C1 = new CREDIS1();
            C1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Vrei sa inchizi jocul?", "FOCUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Esti sigur ca vrei sa incerci nivelul INSANE ?", "FOCUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                INSANE INSANE = new INSANE();
                INSANE.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Esti sigur ca vrei sa te intorci in meniu ?(nu vei putea sa te intorci inapoi)", "FOCUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                F1 f1 = new F1();
                f1.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void F12_Load(object sender, EventArgs e)
        {

            cmd.Connection = cn;

            cn.Open();
            cmd.CommandText = "INSERT INTO ev_jucatori(nume,scor) values('" + F1.nume + "','" + scorfinal + "')";
            cmd.ExecuteNonQuery();
            
            cn.Close();

            label1.Text = ("FELICITARI " + F1.nume + " AI TERMINAT JOCUL FOCUS !");
            label2.Text = ("SCORUL TAU ESTE DE " + scorfinal + " PUNCTE !");
        }


        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\FOCUS_COMSTIINTIFICE_POO\FOCUS_COMSTIINTIFICE_POO\jucatori.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
       

        private void button5_Click(object sender, EventArgs e)
        {


           
        }

        private void button6_Click(object sender, EventArgs e)
        {



            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }
    }
}
