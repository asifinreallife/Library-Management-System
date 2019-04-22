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
    public partial class Auth_Reg : Form
    {
        public Auth_Reg()
        {
            InitializeComponent();
        }

        private void authadd_Click(object sender, EventArgs e)
        {
            AUTHOR a = new AUTHOR();
            a.Author_ID = Convert.ToInt32(auth_id.Text);
            a.Author_Name = auth_name.Text;            
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                context.AUTHORs.InsertOnSubmit(a);
                context.SubmitChanges();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Book a = new Add_Book();
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
