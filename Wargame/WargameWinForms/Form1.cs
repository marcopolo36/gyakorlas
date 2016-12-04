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
            //Ez itt kell, hogy a Napló tudja, hova kell írnia az üzeneteket
            Napló.WinFormsNaplóVezérlő = lbxMessages;
            //mezők feltöltése értékekkel
            r = new Random();
            arena = new Arena();
        }

        private void btnRandomise_Click(object sender, EventArgs e)
        {
            //random értékekkel feltöltjük a néven kívüli textboxokat
            tbHP.Text = r.Next(5, 10).ToString();
            tbAttack.Text = r.Next(2, 5).ToString();
            tbDefense.Text = r.Next(2, 5).ToString();
        }

        private void btnAddWarrior_Click(object sender, EventArgs e)
        {
            //van-e szöveg a textboxokban, és átalakítható-e. Ha gond van, jelezzük, visszatér a metódus
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Rossz Név!");
                return;
            }
            int hp, attack, defense;
            if (! int.TryParse(tbHP.Text, out hp))
            {
                MessageBox.Show("Rossz Életerő érték!");
                return;
            }
            if (! int.TryParse(tbAttack.Text, out attack))
            {
                MessageBox.Show("Rossz Támadó érték!");
                return;
            }
            if (! int.TryParse(tbDefense.Text, out defense))
            {
                MessageBox.Show("Rossz Védő érték!");
                return;
            }

            //harcos hozzáadása
            arena.HarcosHozzadasa(tbName.Text, hp, attack, defense);

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
    }
}