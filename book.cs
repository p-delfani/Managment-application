using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment
{
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void book_Load(object sender, EventArgs e)
        {
            //Any Changes in this form must from updating from admin
            // TODO: This line of code loads data into the 'bookDataSet1.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.bookDataSetbook.book);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            // this is the text box for search users from admin
            try
            {
                bookTableAdapter.FillByname(bookDataSetbook.book, search.Text);
            }
            catch
            {
                MessageBox.Show("مشکلی رخ داده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // to insert some value to table from admin
            try
            {
                bookTableAdapter.InsertQuery(namebook.Text, auther.Text, publisher.Text, int.Parse(number.Text));
                bookTableAdapter.Fill(bookDataSetbook.book);
            }
            catch
            {
                MessageBox.Show("عملیات اضافه کردن کتاب با موفقیت انجام نشد لطفا دوباره تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // to delete values of text boxs from admin
            try
            {
                bookTableAdapter.DeleteQuery(namebook.Text);
                bookTableAdapter.Fill(bookDataSetbook.book);
                MessageBox.Show("عملیات حذف کتاب موفقیت آمیز بود","اطلاعات",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("عملیات حذف کتاب با موفقیت انجام نشد لطفا دوباره تلاش کنید","هشدار",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //to clear all textboxs in data grid view  from admin

            try
            {
                namebook.Text = "";
                auther.Text = "";
                publisher.Text = "";
                number.Text = "";
                MessageBox.Show("اکنون میتوانید مقادیر جدید را در فیلد ها بنوسید ", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("مشکلی رخ داده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //to update value of all textboxs in data grid view from admin
            try
            {
                bookTableAdapter.UpdateQuery(namebook.Text, auther.Text, publisher.Text,int.Parse(number.Text),int.Parse(number.Text));
                bookTableAdapter.Fill(bookDataSetbook.book);
            }
            catch
            {
                MessageBox.Show(" مشکلی رخ داده است دوباره تلاش کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void namebook_TextChanged(object sender, EventArgs e)
        {
            // tool tip for get some information to users from admin
            ToolTip tip = new ToolTip();
            tip.SetToolTip(namebook, "در این فیلد عدد قرار ندهید");
        }

        private void auther_TextChanged(object sender, EventArgs e)
        {
            // tool tip for get some information to users from admin
            ToolTip tip = new ToolTip();
            tip.SetToolTip(auther, "در این فیلد عدد قرار ندهید");
        }

        private void publisher_TextChanged(object sender, EventArgs e)
        {
            // tool tip for get some information to users from admin
            ToolTip tip = new ToolTip();
            tip.SetToolTip(publisher, "در این فیلد عدد قرار ندهید");
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            // tool tip for get some information to users from admin
            ToolTip tip = new ToolTip();
            tip.SetToolTip(number, "در این فیلد عدد قرار ندهید");
        }
    }
}
