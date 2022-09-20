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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (name.Text == "admin" && password.Text == "admin")
            {
                main index = new main();
                index.Show();
            }
            else if(name.Text == "" && password.Text == "")
            {
                MessageBox.Show("لطفا مقادیر خواسته شده را کامل کنید");
            }
            else
            {
                MessageBox.Show("  کاربر گرامی شما ادمین نیستید لطفا روی دکمه ادمین نیستم کلیک کنید تا بتوانید از امکانات نرم افزار بهره مند شوید  ");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            client custom = new client();
            custom.Show();
        }

        private void login_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text == "ADMIN")
            {
                MessageBox.Show("در نوشتن نام کاربری از حروف کوچک انگلیسی استفاده کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text == "ADMIN")
            {
                MessageBox.Show("در نوشتن نام کاربری از حروف کوچک انگلیسی استفاده کنید ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
