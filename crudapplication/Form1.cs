using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudapplication
{
    public partial class Form1 : Form
    {
        data2 model=new data2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
            PopulateDataGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();

        }
        void clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            btnsave.Text = "Save";
            btndelete.Enabled= false;
            model.id = 0;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            model.firstname = textBox1.Text.Trim();
            model.lastname = textBox2.Text.Trim();
            model.city = textBox3.Text.Trim();
            model.address = textBox4.Text.Trim();
                
            using(dbEntities db=new dbEntities())
            {
                if(model.id==0)
                db.data2.Add(model);
                else
                    db.Entry(model).State=System.Data.Entity.EntityState.Modified;
               db.SaveChanges();
            }
            clear();
            PopulateDataGridView();
            MessageBox.Show("submitted successfully");
        }
        void PopulateDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            using(dbEntities db=new dbEntities())
            {
                dataGridView1.DataSource = db.data2.ToList<data2>();
            }
        }
         
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                using(dbEntities db=new dbEntities())
                {
                   var model1=db.data2.Where(x => x.id == model.id).FirstOrDefault();
                    textBox1.Text = model1.firstname;
                    textBox2.Text = model1.lastname;
                    textBox3.Text = model1.city;
                    textBox4.Text = model1.address;
                }
                btnsave.Text = "Update";
                btndelete.Enabled = true;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure to delete ?","crud operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(dbEntities db=new dbEntities())
                {
                    var entry=db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.data2.Attach(model);
                        db.data2.Remove(model);
                        db.SaveChanges(); 
                        PopulateDataGridView();
                        clear();
                        MessageBox.Show("deleted successfully");
                    }
                }
            }
        }
    }
}
