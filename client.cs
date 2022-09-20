using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Library_Managment
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath;
            filename = Path.GetFullPath(Path.Combine(filename, "www.roshdana.com"));
            webBrowser1.Navigate(filename);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath;
            filename = Path.GetFullPath(Path.Combine(filename, ".//www.roshdana.com"));
            webBrowser1.Navigate(filename);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath;
            filename = Path.GetFullPath(Path.Combine(filename, "www.roshdana.com"));
            webBrowser1.Navigate(filename);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath;
            filename = Path.GetFullPath(Path.Combine(filename, "harfeakhar.org"));
            webBrowser1.Navigate(filename);
        }

        private void teamwork_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void finish_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        int s = 0;
        int m = 0;
        int h = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s += 1;
            if (s == 60)
            {
                m += 1;
                s = 0;
            }
            else if (m == 60)
            {
                h += 1;
                m = 0;
                s = 0;
            }
            second.Text = s.ToString();
            minute.Text = m.ToString();
            hour.Text = h.ToString();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}
