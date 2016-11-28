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
            if(! maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("A rendszám adat formailag hibás!");
                return;
            }

            Autos autos = new Autos(maskedTextBox1.Text, Convert.ToDouble(numericUpDown1.Value), Convert.ToByte(comboBox1.SelectedIndex));
            autosok.UjAutos(autos);
            label4.Text= autosok.ToString();
            textBox2.Text = autosok.ToString();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            textBox1.Text = autosok.LegtobbetTankolo();
            textBox3.Text = (autosok.AtlagKoltseg()).ToString();
        }
    
    }
}
