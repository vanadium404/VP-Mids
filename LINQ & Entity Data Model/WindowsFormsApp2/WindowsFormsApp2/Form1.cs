using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2


{
    
    public partial class Form1 : Form
    {
        // My Data Base had two tables 
        // 1- Areas 
        // 2- Cities
        // dbef was the database name and it becae dbefEntities
        // Areas was a table and it became Area
        dbefEntities db = new dbefEntities();
        Area areaobj = new Area();

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            areaobj.AreaID = Convert.ToInt32(aid.Text);
            areaobj.AreaName = Convert.ToString(aname.Text);
            areaobj.CityID = Convert.ToInt32(acid.Text);

            db.Areas.Add(areaobj);
            db.SaveChanges();

        }

        private void view_Click(object sender, EventArgs e)
        {
            
            foreach(Area a in db.Areas)
            {
                gridview.DataSource = db.Areas.Local.ToBindingList();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(aid.Text);
            areaobj = db.Areas.Find(id);
            if(areaobj == null)
            {
                MessageBox.Show("Invalid ID entered");
            }
            else
            {
                // Fill the fields against the given id
                aid.Text = Convert.ToString(areaobj.AreaID);
                aname.Text = Convert.ToString(areaobj.AreaName);
                acid.Text = Convert.ToString(areaobj.CityID);

                // Create a new button for updation this is only useful to find the record
                // But it cant update record make new button and paste the updation lines
                // written below to it.


                // Now update
                areaobj.AreaID = Convert.ToInt32(aid.Text);
                areaobj.AreaName = Convert.ToString(aname.Text);
                areaobj.CityID = Convert.ToInt32(acid.Text);

                // db.Areas.Add(areaobj);
                db.SaveChanges();

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(aid.Text);
            areaobj = db.Areas.Find(id);
            if (areaobj == null)
            {
                MessageBox.Show("Invalid ID entered");
            }
            else
            {
                db.Areas.Remove(areaobj);
            }
        }
    }
}
