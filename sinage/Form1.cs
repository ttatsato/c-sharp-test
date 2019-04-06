using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinage
{
    public partial class Form1 : Form
    {

    string url = "http://www.kait.jp/";
    public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate(new Uri(url));
            }
            catch
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
