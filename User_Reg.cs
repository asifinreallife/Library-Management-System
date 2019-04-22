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
    public partial class User_Reg : Form
    {       
        public User_Reg()
        {
            InitializeComponent();
        }

         public User_Reg(String username, String password)
        {
            usernamebox.Text = username;
            passwordbox.Text = password;
            
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Window l = new Login_Window();        
            l.Show();            
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            AWAITING_CONFIRMATION u = new AWAITING_CONFIRMATION();
            u.Name = usernamebox.Text;
            u.Password = passwordbox.Text;
            bool flag = false;
            foreach (USER b in context.USERs)
            {
                if (b.User_Name.ToLower() == u.Name.ToLower())
                {
                    flag = true;
                    MessageBox.Show("User name taken");
                }
            }
            
            if (flag == false)
            {
                using (DataClasses1DataContext c = new DataClasses1DataContext())
                {
                    c.AWAITING_CONFIRMATIONs.InsertOnSubmit(u);
                    c.SubmitChanges();
                    MessageBox.Show("Awaiting for confirmation");
                }
            }      

        }

        public void checkname(String name)
        {            
            DataClasses1DataContext context = new DataClasses1DataContext();
            bool flag = false;
            foreach (USER b in context.USERs)
            {
                if (b.User_Name.ToLower() == name)
                {
                    flag = true;
                    MessageBox.Show("User name taken");
                }
            }

            AWAITING_CONFIRMATION u = new AWAITING_CONFIRMATION ();
            if (flag == false)
            {
                u.Name = usernamebox.Text;
                u.Password = passwordbox.Text;
                using (DataClasses1DataContext c = new DataClasses1DataContext())
                {
                    c.AWAITING_CONFIRMATIONs.InsertOnSubmit(u);
                    c.SubmitChanges();
                }
            }
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
