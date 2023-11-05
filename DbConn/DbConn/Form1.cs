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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbConn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(id.Text);
            String namee = Convert.ToString(name.Text);
            int selectedIndex = dep.SelectedIndex;
            String depart = dep.Items[selectedIndex].ToString();

            string insertqry = "INSERT INTO info(id, name, department) VALUES (@id, @name, @department)";
            SqlParameter[] insertParam =
            {
                new SqlParameter("@id", idd),
                new SqlParameter("@name", namee),
                new SqlParameter("@department", depart)
            };
            DBCONN dbconn = new DBCONN("Data Source = DESKTOP-LBBD45U\\SQLEXPRESS; Initial Catalog=student; Integrated Security=True");
            int res = dbconn.UpdateDeleteInsert(insertqry, insertParam);
            if(res == 1)
            {
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Record Insertion Error");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // We want combo box to fill with departments as soon as form loads
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LBBD45U\\SQLEXPRESS; Initial Catalog =" +
                "student; Integrated Security=True");
            con.Open();
            String qry = "Select * from department";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    dep.Items.Add(rdr["name"].ToString());
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(id.Text);
            string deleteqry = "Delete from info where id = @id";
            SqlParameter[] deleteParam =
            {
                new SqlParameter("@id", idd),
                
            };
            DBCONN dbconn = new DBCONN("Data Source = DESKTOP-LBBD45U\\SQLEXPRESS; Initial Catalog=student; Integrated Security=True");
            int res = dbconn.UpdateDeleteInsert(deleteqry, deleteParam);
            if (res == 1)
            {
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Record Deletion Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBCONN dbconn = new DBCONN("Data Source = DESKTOP-LBBD45U\\SQLEXPRESS; Initial Catalog=student; Integrated Security=True");
            String qry = "Select * from info";
            DataTable dt = dbconn.SelectConnLess(qry);

            list.Columns.Add("ID");
            list.Columns.Add("Department");
            list.Columns.Add("Name");

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["department"].ToString());
                
                list.Items.Add(item);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(id.Text);
            String namee = Convert.ToString(name.Text);
            int selectedIndex = dep.SelectedIndex;
            String depart = dep.Items[selectedIndex].ToString();

            string insertqry = "UPDATE info set name=@name, department=@department where id=@id";
            SqlParameter[] insertParam =
            {
                new SqlParameter("@id", idd),
                new SqlParameter("@name", namee),
                new SqlParameter("@department", depart)
            };
            DBCONN dbconn = new DBCONN("Data Source = DESKTOP-LBBD45U\\SQLEXPRESS; Initial Catalog=student; Integrated Security=True");
            int res = dbconn.UpdateDeleteInsert(insertqry, insertParam);
            if (res == 1)
            {
                MessageBox.Show("Record Updated Successfully");
            }
            else
            {
                MessageBox.Show("Record Updation Error");
            }
        }
    }
}
