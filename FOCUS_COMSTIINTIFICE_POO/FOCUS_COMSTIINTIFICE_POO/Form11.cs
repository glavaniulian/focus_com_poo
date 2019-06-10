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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
               cmd.Connection = cn;



            cn.Open();

            SqlDataAdapter table = new SqlDataAdapter("SELECT * FROM ev_jucatori ORDER BY scor ASC", cn);
            DataTable dt = new DataTable();
            table.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();


            
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\FOCUS_COMSTIINTIFICE_POO\FOCUS_COMSTIINTIFICE_POO\jucatori.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

       

        private void button1_Click(object sender, EventArgs e)
        {
            F12 f12 = new F12();
            f12.Show();
            this.Hide();
        }

        private void ev_jucatoriBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ev_jucatoriBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
