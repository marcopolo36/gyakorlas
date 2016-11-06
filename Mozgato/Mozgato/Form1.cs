using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mozgato
{
    public partial class Form1 : Form
    {
        int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
        int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = this.ScreenHeight / 2 - this.Height / 2;
            
            this.Left = this.ScreenWidth / 2 - this.Width / 2;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyData)
            {
                case Keys.Left:
                    if (this.Left > 0)
                    {
                        this.Left = this.Left - 1;
                    }
                    break;
            }
                
        }
    }
}
