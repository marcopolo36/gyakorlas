using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenzinkutWinform
{
    public partial class Form1 : Form
    {
        Autosok autosok;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autosok = new Autosok();
            label4.Text = autosok.ToString();
            textBox2.Text = autosok.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autos autos = new Autos(textBox1.Text, Convert.ToDouble(numericUpDown1.Value), Convert.ToByte(comboBox1.SelectedIndex));
            autosok.UjAutos(autos);
            label4.Text= autosok.ToString();
            textBox2.Text = autosok.ToString();
        }
    }
}
