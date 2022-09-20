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
    public partial class main : Form
    {
        
        private int displacement = 1;
        private int direction = 1;
        public main()
        {
            InitializeComponent();
        }

        private void افزودنکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user client = new user();
            client.Show();
            افزودنکاربرToolStripMenuItem.Checked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox1.Right >= this.ClientSize.Width || pictureBox1.Left <= 0) direction *= -1;
            pictureBox1.Location = new Point(pictureBox1.Location.X + displacement * direction, pictureBox1.Location.Y);

        }

        private void main_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void گزارشخرابیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("در صورت بروز هر گونه مشکل به ایمیل زیر پیام ارسال کنید " +
            //   "parmis.delfani84@gmail.com");
            report re = new report();
            re.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void همهکتابهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book bo = new book();
            bo.Show();
        }

        private void سرویسهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutapp about = new aboutapp();
            about.Show();
            


        }
    }
}
