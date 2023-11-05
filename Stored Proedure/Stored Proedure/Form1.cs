using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stored_Proedure

{

    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LBBD45U\\SQLEXPRESS;Initial Catalog=information;Integrated Security=True");
            con.Open();
            int id = Convert.ToInt32(idd.Text);
            String namee = Convert.ToString(name.Text);
            String phonee = Convert.ToString(phone.Text);
            SqlCommand c = new SqlCommand("sp_insert '"+id+"', '"+name +"', '"+phone+"'", con);
            c.ExecuteNonQuery();
            ShowData();
            MessageBox.Show("Data Inserted Successfully");

        }
        void ShowData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LBBD45U\\SQLEXPRESS;Initial Catalog=information;Integrated Security=True");
            con.Open();
            SqlCommand c = new SqlCommand("sp_viewall", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            grid.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idd.Text);
            SqlConnection con = new SqlConnection("Data Source= DESKTOP-LBBD45U\\SQLEXPRESS; Initial Catalog=information; Integrated Security=True");
            con.Open();
            SqlCommand c = new SqlCommand("sp_loadspecific '"+id+"'");
            c.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            grid.DataSource = dt;
            ShowData();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(idd.Text);
            SqlConnection con = new SqlConnection("Data Source= DESKTOP-LBBD45U\\SQLEXPRESS; Initial Catalog=information;Integrated Security = True");
            con.Open();
            int id = Convert.ToInt32(idd.Text);
            SqlCommand c = new SqlCommand("sp_delete '"+i+"'", con);
            c.ExecuteNonQuery();
            ShowData();

        }
    }
}
