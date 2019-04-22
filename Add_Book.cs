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
    public partial class Add_Book : Form
    {
        bool publisher_flag = false;
        bool author_flag = false;
        bool id_flag = false;
        public Add_Book()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Panel back = new Admin_Panel();
            back.Show();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            insertbook();
        }

        public void insertbook()
        {
            try
            {
                BOOK b = new BOOK();
                b.Book_ID = Convert.ToInt32(bookidbox.Text);
                b.Book_Name = booknamebox.Text;
                b.Book_Price = Convert.ToInt32(bookpricebox.Text);
                b.Availability = availabilitycombobox.Text;
                b.Language = languagebox.Text;
                b.Publish_Year = Convert.ToInt32(yearbox.Text);
                b.Publisher_Name = pubnamebox.Text;
                // b.Publisher_ID = Convert.ToInt32(pub_idbox.Text);
                b.Genre_Name = Genrecombobox.Text;
                if (b.Publish_Year <= DateTime.Today.Year)
                {
                    using (DataClasses1DataContext context = new DataClasses1DataContext())
                    {

                        foreach (BOOK b1 in context.BOOKs)
                        {
                            if (b1.Book_ID == b.Book_ID)
                            {
                                id_flag = true;
                            }
                        }
                        if (id_flag == true)
                        {
                            MessageBox.Show("Duplicate id detected");
                        }
                        else
                        {
                            BOOK_AUTHOR ba = new BOOK_AUTHOR();

                            foreach (AUTHOR a in context.AUTHORs)
                            {
                                if (a.Author_Name.ToLower() == authornamebox.Text.ToLower())
                                {
                                    ba.Book_ID = b.Book_ID;
                                    ba.Author_ID = a.Author_ID;
                                    b.Author_Name = authornamebox.Text;
                                    author_flag = true;
                                }
                            }

                            if (author_flag == false)
                            {
                                MessageBox.Show("Author not found.Click 'Add Author' to add Publisher.");
                            }
                            else
                            {
                                foreach (PUBLISHER p in context.PUBLISHERs)
                                {
                                    if (b.Publisher_Name.ToLower() == p.Publisher_Name.ToLower())
                                    {
                                        b.Publisher_ID = p.Publisher_ID;
                                        b.Publisher_Address = p.Publisher_Address;
                                        publisher_flag = true;
                                    }
                                }

                                if (publisher_flag == false)
                                {
                                    MessageBox.Show("Publisher not found.Click 'Add Publisher' to add Publisher.");
                                }

                                else
                                {

                                    foreach (GENRE g in context.GENREs)
                                    {
                                        if (b.Genre_Name == g.Genre_Name)
                                        {
                                            b.Genre_ID = g.Genre_ID;
                                        }
                                    }

                                    context.BOOKs.InsertOnSubmit(b);
                                    context.BOOK_AUTHORs.InsertOnSubmit(ba);
                                    context.SubmitChanges();
                                    MessageBox.Show("Book Added Succssessfully.");
                                }
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Invalid year");
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

        private void removebutton_Click(object sender, EventArgs e)
        {
            deletebook();
        }
        public void deletebook()
        {
            /*DataClasses1DataContext context = new DataClasses1DataContext("connection string");
            var books = context.BOOKs.Where(c => c.Book_Name.ToLower() == booknamebox.Text.ToLower());

            context.BOOKs.DeleteAllOnSubmit(books);
            context.SubmitChanges();*/


            using (DataClasses1DataContext c = new DataClasses1DataContext())
            {
                //BOOK a = c.BOOKs.Single(x => x.Book_Name.ToLower() == booknamebox.Text.ToLower());
               foreach(BOOK b in c.BOOKs)
               {
                   if (b.Book_Name.ToLower() == booknamebox.Text.ToLower())
                   {
                        foreach(BOOK_AUTHOR ba in c.BOOK_AUTHORs)
                        {
                            if (ba.Book_ID == b.Book_ID)
                            {
                                c.BOOK_AUTHORs.DeleteOnSubmit(ba);
                                c.BOOKs.DeleteOnSubmit(b);
                                c.SubmitChanges();
                                MessageBox.Show("Succssessfully deleted.");
                            }
                        }
               }                
            }              
        }
      }

        private void addpublisher_Click(object sender, EventArgs e)
        {           
                /*code first add to publisher table then again check 
                for bublisherid in publihser table*/
                this.Hide();
                Add_Publisher p = new Add_Publisher();
                p.Show();
        }

        private void genreidbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet18.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter2.Fill(this.project1DataSet18.BOOK);
            // TODO: This line of code loads data into the 'project1DataSet15.GENRE' table. You can move, or remove it, as needed.
            this.gENRETableAdapter2.Fill(this.project1DataSet15.GENRE);
            // TODO: This line of code loads data into the 'project1DataSet13.BOOK' table. You can move, or remove it, as needed.
           // this.bOOKTableAdapter1.Fill(this.project1DataSet13.BOOK);
            // TODO: This line of code loads data into the 'project1DataSet12.BOOK' table. You can move, or remove it, as needed.
           // this.bOOKTableAdapter.Fill(this.project1DataSet12.BOOK);
            // TODO: This line of code loads data into the 'project1DataSet11.GENRE' table. You can move, or remove it, as needed.
           // this.gENRETableAdapter1.Fill(this.project1DataSet11.GENRE);
        }

        private void addauthor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Author a = new Add_Author();
            a.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                bookidbox.Text = row.Cells["Book_ID"].Value.ToString();
                booknamebox.Text = row.Cells["Book_Name"].Value.ToString();
                authornamebox.Text = row.Cells["Author_Name"].Value.ToString();
                bookpricebox.Text = row.Cells["Book_Price"].Value.ToString();
                availabilitycombobox.Text= row.Cells["Availability"].Value.ToString();
                Genrecombobox.Text = row.Cells["Genre_Name"].Value.ToString();
                languagebox.Text = row.Cells["Language"].Value.ToString();
                yearbox.Text = row.Cells["Publish_Year"].Value.ToString();
                pubnamebox.Text = row.Cells["Publisher_Name"].Value.ToString();               

            }
        }

        private void publisheridbox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bookidbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
