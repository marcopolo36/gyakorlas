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
            if (comboBoxHarcosTipusa.SelectedIndex == -1)
            {
                MessageBox.Show("Rossz érték!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxSzarmazas.Text))
            {
                MessageBox.Show("Rossz érték!");
                return;
            }

            Ember ember = new Ember(this.nev, );

            //harcos hozzáadása
            arena.HarcosHozzadasa(harcos);

            //szövegdobozok ürítése
            tbName.Text = tbHP.Text = tbAttack.Text = tbDefense.Text = string.Empty;

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
            if (comboBoxHarcosTipusa.SelectedText == "Ember")
            {
                checkBoxTamadoE.Hide();
                labelTamadoE.Hide();
                labelSzarmazas.Text = "Nemzetiség";
            }
            else
            {
                checkBoxTamadoE.Show();
                labelTamadoE.Show();
                labelSzarmazas.Text = "Klán";
            }
        }
    }
}