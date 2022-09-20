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
    public partial class user : Form
    {
        
        public user()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)
        {
            // Any Changes in this form must updating from admin
            // TODO: This line of code loads data into the 'bookDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.bookDataSet.user);

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            // to clear values of text boxs 
            name.Text = "";
            family.Text = "";
            father.Text = "";
            code.Text = "";
            tel.Text = "";
            email.Text = "";
            address.Text = "";
            start.Text = "";
            finish.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //to insert some values to text boxs from admin
            try
            {
                userTableAdapter.Insertuser(name.Text, family.Text, family.Text, int.Parse(code.Text), int.Parse(tel.Text), email.Text, address.Text, start.Text, finish.Text);
                userTableAdapter.Fill(bookDataSet.user);
            }
            catch
            {
                MessageBox.Show("در ثبت کاربر مشکلی رخ داده دوباره تلاش کنید");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // to update new values to table from admin
            try
            {
                
                userTableAdapter.Updateuser(name.Text, family.Text, father.Text, int.Parse(code.Text), int.Parse(tel.Text), email.Text, address.Text, start.Text, finish.Text, int.Parse(code.Text));
                userTableAdapter.Fill(bookDataSet.user);
            }
            catch
            {
                MessageBox.Show("در بروزرسانی کاربر مشکلی رخ داده دوباره تلاش کنید");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is the text box for search from admin
            try
            {
                int x = int.Parse(search.Text);
                userTableAdapter.FillBycode(bookDataSet.user, x);
            }
            catch
            {
                MessageBox.Show("عملیات جست و جو موفق آمیز نبود دوباره تلاش کنید");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // to delete some values in text boxes from admin
            try
            {
                userTableAdapter.DeleteQuery(int.Parse(code.Text));
                userTableAdapter.Fill(bookDataSet.user);
            }
            catch
            {
                MessageBox.Show("در حذف کاربر مشکلی رخ داده دوباره تلاش کنید");
            }
         
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            // to get some information to admin
            ToolTip tip = new ToolTip();
            tip.SetToolTip(name,"در این فیلد عدد قرار ندهید");
        }

        private void family_TextChanged(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(family, "در این فیلد عدد قرار ندهید");
        }

        private void father_TextChanged(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(father, "در این فیلد عدد قرار ندهید");
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(email, "در این فیلد عدد قرار ندهید");
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(address, "در این فیلد عدد قرار ندهید");
        }

        private void code_TextChanged(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(code, "در این فیلد حروف را قرار ندهید");
        }

        private void tel_TextChanged(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(tel, "در این فیلد حروف را قرار ندهید");
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(name, "در این فیلد حروف را قرار ندهید");
        }

        private void start_TextChanged(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(start, "استفاده از حروف و اعداد در این قسمت مجاز است");
        }

        private void finish_TextChanged(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(finish, "استفاده از حروف و اعداد در این قسمت مجاز است");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // openFileDialog1.ShowDialog();
           // profile.ImageLocation = openFileDialog1.FileName;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
