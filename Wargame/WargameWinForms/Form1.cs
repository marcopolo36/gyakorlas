using System;
using System.Windows.Forms;
using Wargame;

namespace WargameWinForms
{
    public partial class Form1 : Form
    {
        //Mezők (minden Form1 példány tartalmazni fog egyet-egyet)
        private Random r;
        private Arena arena;


        //konstruktor
        public Form1()
        {
            InitializeComponent();
            labelSzarmazas.Text = "Nemzetiség";
            comboBoxHarcosTipusa.SelectedIndex = 0;

            //Ez itt kell, hogy a Napló tudja, hova kell írnia az üzeneteket
            Napló.WinFormsNaplóVezérlő = lbxMessages;
            //mezők feltöltése értékekkel
            r = new Random();
            arena = new Arena();
        }

        private void btnAddWarrior_Click(object sender, EventArgs e)
        {
            //van-e szöveg a textboxokban, és átalakítható-e. Ha gond van, jelezzük, visszatér a metódus
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Rossz Név!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSzarmazas.Text))
            {
                MessageBox.Show("Rossz érték!");
                return;
            }

            if (comboBoxHarcosTipusa.SelectedIndex == -1)
            {
                MessageBox.Show("Rossz érték!");
                return;
            }

            
            //harcos hozzáadása
            if ((string)comboBoxHarcosTipusa.SelectedItem == "Ember")
            {
                Ember ember = new Ember(tbName.Text, textBoxSzarmazas.Text, checkBoxTamadoE.Checked);
                arena.HarcosHozzadasa(ember);
            }

            if ((string)comboBoxHarcosTipusa.SelectedItem == "Szörny")
            {
                int OsszErtek = r.Next(8, 13);
                Szorny szorny = new Szorny(tbName.Text, textBoxSzarmazas.Text, OsszErtek);
                arena.HarcosHozzadasa(szorny);
            }
            
            //szövegdobozok ürítése
            tbName.Text = textBoxSzarmazas.Text = string.Empty;

            //lista frissítése
            RefreshWarriorListBox();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            //ha van kiválasztott elem...
            if (lbxWarriors.SelectedIndex > -1)
            {
                //a listbox tartalma bármi lehet (object), ezért ellenőrizni kell, hogy a kiválasztott elem Harcos-e
                Harcos torlendo = (Harcos) lbxWarriors.SelectedItem;
                arena.HarcosTorlese(torlendo);
                //lista frissítése
                RefreshWarriorListBox();
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            //Minden elem törlése
            lbxMessages.Items.Clear();
            //csata indítása
            arena.Csata();
            //lista frissítése
            RefreshWarriorListBox();
        }

        private void RefreshWarriorListBox()
        {
            //töröljük az elemeket, majd egyenként újra berakjuk őket a listboxba
            lbxWarriors.Items.Clear();
            foreach (Harcos h in arena.Harcosok)
            {
                lbxWarriors.Items.Add(h);
            }
        }

        private void comboBoxHarcosTipusa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxHarcosTipusa.SelectedItem == "Ember")
            {
                checkBoxTamadoE.Show();
                labelTamadoE.Show();
                labelSzarmazas.Text = "Nemzetiség";
            }
            else
            {               
                checkBoxTamadoE.Hide();
                labelTamadoE.Hide();
                labelSzarmazas.Text = "Klán";
            }
        }

        private void buttonVeletlen_Click(object sender, EventArgs e)
        {
            if ((string)comboBoxHarcosTipusa.SelectedItem == "Szörny")
            { 
                tbName.Text = Szornynevek.NevGeneralas();
            }
        }
    }
}