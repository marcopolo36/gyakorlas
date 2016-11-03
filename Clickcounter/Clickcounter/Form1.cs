using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickcounter
{
    public partial class Form1 : Form
    {
        private int katt = 0;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Width = this.ClientSize.Width;
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.katt += 1;
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.katt -= 1;
            }
            this.label1.Text = this.katt.ToString();
        }
    }
}
