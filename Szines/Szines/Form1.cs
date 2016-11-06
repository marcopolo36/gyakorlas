using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = this.BackColor;
            this.BackColor = Color.Red;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = this.BackColor;
            this.BackColor = Color.Blue;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = this.BackColor;
            this.BackColor = Color.Yellow;

        }
        private void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = this.BackColor;
            this.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
