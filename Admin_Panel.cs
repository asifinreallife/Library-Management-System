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
    public partial class Admin_Panel : Form
    {
        String u_name, password;
        bool remember;
        public Admin_Panel()
        {
            InitializeComponent();
        }

        public Admin_Panel(String u,String p,bool r)
        {
            this.u_name = u;
            this.password = p;
            this.remember = r;
            InitializeComponent();            
        }   

        private void adminlogoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Window l = new Login_Window();
            if (this.remember == true)
            {
                l.usernamebox.Text = u_name;
                l.passwordbox.Text = password;
            }
            l.Show();
        }

        private void userregbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg_Confirm r = new Reg_Confirm();
            r.Show();
        }

        private void addremovebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Book b = new Add_Book();
            b.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
