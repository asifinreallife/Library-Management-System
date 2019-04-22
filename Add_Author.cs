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
    public partial class Add_Author : Form
    {
        public Add_Author()
        {
            InitializeComponent();
        }

        private void pubadd_Click(object sender, EventArgs e)
        {
          try{
            bool flag=false;
            AUTHOR a = new AUTHOR();            
            a.Author_ID = Convert.ToInt32(authoridbox.Text);
            a.Author_Name = authornamebox.Text;
            using (DataClasses1DataContext context = new DataClasses1DataContext())
            {
                
                foreach (AUTHOR a1 in context.AUTHORs)
                {
                    if ((a1.Author_ID == a.Author_ID || a1.Author_Name == a.Author_Name) && !string.IsNullOrEmpty(authornamebox.Text))
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    context.AUTHORs.InsertOnSubmit(a);
                    context.SubmitChanges();
                    MessageBox.Show("Author Added successfully.");
                }
                else if (string.IsNullOrEmpty(authornamebox.Text))
                {
                    MessageBox.Show("adsd");
                }
                else
                {
                    MessageBox.Show("Same Id/Name found.");
                }
              }       
            }
            catch (FormatException)
            {
                MessageBox.Show("Input Error.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Book a = new Add_Book();
            a.Show();
        }

        private void Add_Author_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet16.AUTHOR' table. You can move, or remove it, as needed.
            this.aUTHORTableAdapter.Fill(this.project1DataSet16.AUTHOR);

        }

        private void authoridbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
