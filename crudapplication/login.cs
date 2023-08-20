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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
         cruddbEntities db = new cruddbEntities();
     
        private void mainlogin_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;
            var model = db.userdatas.Where(x => x.name == username && x.password == password).FirstOrDefault();
            if (model != null)
            {
                Form1 formobject = new Form1();
                this.Hide();
                formobject.ShowDialog();
            }
            else
            {
                MessageBox.Show("login failed");
            }

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            signup signupobject = new signup();
            this.Hide();
            signupobject.ShowDialog();
           
        }
    }
}
