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
    public partial class signup : Form
    {
        cruddbEntities db=new cruddbEntities();
        public signup()
        {
            InitializeComponent();
        }
         public bool IsEmpty()
        {
            if(textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                return true;
            }
            else
            {  return false; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                userdata obj = new userdata();
                obj.name = textBox1.Text;
                obj.password = textBox2.Text;
                obj.email = textBox3.Text;
                db.userdatas.Add(obj);
                db.SaveChanges();
                MessageBox.Show("signup successfully");
            }
            else
            {
                MessageBox.Show("Please fill required field");
            }
            
                
            

        }
      

        private void button2_Click_1(object sender, EventArgs e)
        {

            login obj = new login();
            this.Hide();
            obj.ShowDialog();
           
        }
    }
}
