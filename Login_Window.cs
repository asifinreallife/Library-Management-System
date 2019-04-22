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

namespace csharpproject
{
    public partial class Login_Window : Form
    {
        public String u_name,password;
        public bool remember=true;
        public Login_Window()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {            
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            bool flag=false;
            DataClasses1DataContext context = new DataClasses1DataContext();
            foreach(ADMIN a in context.ADMINs)
            {
                if (a.Admin_Name == usernamebox.Text && a.Admin_Password == passwordbox.Text)
                {
                    flag = true;
                    this.Hide();
                    Admin_Panel ap = new Admin_Panel(usernamebox.Text, passwordbox.Text, remember);
                    ap.Show();
                }
            }

            foreach (USER a in context.USERs)
            {
                if (a.User_Name == usernamebox.Text && a.User_Password == passwordbox.Text)
                {

                    flag = true;
                    this.Hide();
                    User_Panel up = new User_Panel(usernamebox.Text, passwordbox.Text, remember);
                    up.Show();
 
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Incorrect Username/Pass.");
            }
            
        }

        public void checkuser(String username, String password)
        {
                
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Reg u = new User_Reg();
            u.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                remember = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
