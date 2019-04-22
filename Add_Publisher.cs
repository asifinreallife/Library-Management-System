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
    public partial class Add_Publisher : Form
    {
        public Add_Publisher()
        {
            InitializeComponent();
        }

        private void pubadd_Click(object sender, EventArgs e)
        {
            try{
                bool flag = false;
                PUBLISHER p = new PUBLISHER();
                p.Publisher_ID = Convert.ToInt32(pubid.Text);
                p.Publisher_Name = pubname.Text;
                p.Publisher_Address = pubaddress.Text;
                using (DataClasses1DataContext context = new DataClasses1DataContext())
                {
                    foreach (PUBLISHER p1 in context.PUBLISHERs)
                    {
                        if (p1.Publisher_ID == p.Publisher_ID || p1.Publisher_Name.ToLower() == p.Publisher_Name.ToLower())
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        context.PUBLISHERs.InsertOnSubmit(p);
                        context.SubmitChanges();
                        MessageBox.Show("Publisher added succesfully.");
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

        private void pubname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_Publisher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project1DataSet17.PUBLISHER' table. You can move, or remove it, as needed.
            this.pUBLISHERTableAdapter.Fill(this.project1DataSet17.PUBLISHER);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
