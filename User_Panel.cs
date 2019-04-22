using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpproject
{
    public partial class User_Panel : Form
    {
        String u_name, password;
        bool remember;
        public User_Panel()
        {
            InitializeComponent();
        }
        public User_Panel(String u, String p, bool r)
        {
            {
                this.u_name = u;
                this.password = p;
                this.remember = r;
                InitializeComponent();
            }   
        }

        private void logoutbutton_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext c = new DataClasses1DataContext();

                if (String.IsNullOrEmpty(booknamebox.Text) && String.IsNullOrEmpty(yearbox.Text) && String.IsNullOrEmpty(pricebox.Text) && String.IsNullOrEmpty(publishernamebox.Text) && String.IsNullOrEmpty(availabilitycombobox.Text))
                {
                    dataGridView1.DataSource = c.BOOKs.Where(x => x.Author_Name.ToLower() == authornamebox.Text.ToLower() && (x.Genre_Name.ToLower() == genrebox.Text.ToLower()));
                    
                }

                else if (String.IsNullOrEmpty(booknamebox.Text) && String.IsNullOrEmpty(yearbox.Text) && String.IsNullOrEmpty(pricebox.Text) && String.IsNullOrEmpty(publishernamebox.Text))
                {
                    dataGridView1.DataSource = c.BOOKs.Where(x => x.Author_Name.ToLower() == authornamebox.Text.ToLower() && (x.Genre_Name.ToLower() == genrebox.Text.ToLower())
                    && (x.Availability.ToLower() == availabilitycombobox.Text.ToLower()));
                    
                }
                else if (String.IsNullOrEmpty(booknamebox.Text) && String.IsNullOrEmpty(yearbox.Text) && String.IsNullOrEmpty(pricebox.Text))
                {
                    dataGridView1.DataSource = c.BOOKs.Where(x => x.Author_Name.ToLower() == authornamebox.Text.ToLower() && (x.Genre_Name.ToLower() == genrebox.Text.ToLower())
                    && (x.Availability.ToLower() == availabilitycombobox.Text.ToLower()) && (x.Publisher_Name.ToLower() == publishernamebox.Text.ToLower()));
                    
                }
                else if (String.IsNullOrEmpty(booknamebox.Text))
                {
                    dataGridView1.DataSource = c.BOOKs.Where(x => x.Author_Name.ToLower() == authornamebox.Text.ToLower()
                      && (x.Genre_Name.ToLower() == genrebox.Text.ToLower()) && (x.Book_Price == Convert.ToInt32(pricebox.Text)) && (x.Availability.ToLower() == availabilitycombobox.Text.ToLower())
                      && (x.Publish_Year == Convert.ToInt32(yearbox.Text)) && (x.Publisher_Name.ToLower() == publishernamebox.Text.ToLower()));
                    
                }
                else
                {
                    dataGridView1.DataSource = c.BOOKs.Where(x => x.Book_Name.ToLower() == booknamebox.Text.ToLower() && (x.Author_Name.ToLower() == authornamebox.Text.ToLower())
                       && (x.Genre_Name.ToLower() == genrebox.Text.ToLower()) && (x.Book_Price == Convert.ToInt32(pricebox.Text)) && (x.Availability.ToLower() == availabilitycombobox.Text.ToLower())
                       && (x.Publish_Year == Convert.ToInt32(yearbox.Text)) && (x.Publisher_Name.ToLower() == publishernamebox.Text.ToLower()));
                    
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbybook_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext c = new DataClasses1DataContext();  
            dataGridView1.DataSource = c.BOOKs.Where(x => x.Book_Name.ToLower() == booknamebox.Text.ToLower());
            //this.bOOKTableAdapter.Fill(this.project1DataSet14.BOOK);
            
        }

        private void searchbyauthor_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext c = new DataClasses1DataContext();
            // var books=(from BOOKs in c.GetTable<BOOK>())    
            dataGridView1.DataSource = c.BOOKs.Where(x => x.Author_Name.ToLower() == authornamebox.Text.ToLower());
           
        }

        private void searchbygenre_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext c = new DataClasses1DataContext();   
            dataGridView1.DataSource = c.BOOKs.Where(x => x.Genre_Name.ToLower() == genrebox.Text.ToLower());
           
        }

        private void searchbyprice_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext c = new DataClasses1DataContext();
                dataGridView1.DataSource = c.BOOKs.Where(x => x.Book_Price == Convert.ToInt32(pricebox.Text));
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbyavailability_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext c = new DataClasses1DataContext();
            dataGridView1.DataSource = c.BOOKs.Where(x => x.Availability.ToLower() == availabilitycombobox.Text.ToLower());
           
        }

        private void searchbyyear_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(yearbox.Text) <= DateTime.Today.Year)
                {
                    DataClasses1DataContext c = new DataClasses1DataContext();
                    dataGridView1.DataSource = c.BOOKs.Where(x => x.Publish_Year == Convert.ToInt32(yearbox.Text));
                    
                }
                else 
                {
                    MessageBox.Show(" Invalid Year.");
                }
            }            
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbypublisher_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext c = new DataClasses1DataContext();
            dataGridView1.DataSource = c.BOOKs.Where(x => x.Publisher_Name.ToLower() ==publishernamebox.Text.ToLower());
           
        }

        private void User_Panel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet21.BOOK' table. You can move, or remove it, as needed.
           

        }
    }
}
