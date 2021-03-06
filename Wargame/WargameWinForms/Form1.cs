﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Wargame;

namespace WargameWinForms
{
    public partial class Form1 : Form
    {
        //Mezők (minden Form1 példány tartalmazni fog egyet-egyet)
        private Random r;
        private Arena arena;
        private FajlAdatKezelo adatKezelo = new FajlAdatKezelo();

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
            /*if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Rossz Név!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSzarmazas.Text))
            {
                MessageBox.Show("Rossz érték!");
                return;
            }*/

            if (comboBoxHarcosTipusa.SelectedIndex == -1)
            {
                MessageBox.Show("Rossz érték!");
                return;
            }

            
            //harcos hozzáadása
            if ((string)comboBoxHarcosTipusa.SelectedItem == "Ember")
            {   
                try
                { 
                    Ember ember = new Ember(tbName.Text, textBoxSzarmazas.Text, checkBoxTamadoE.Checked);
                    arena.HarcosHozzadasa(ember);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if ((string)comboBoxHarcosTipusa.SelectedItem == "Szörny")
            {
                int OsszErtek = r.Next(8, 13);
                try
                {
                    Szorny szorny = new Szorny(tbName.Text, textBoxSzarmazas.Text, OsszErtek);
                    arena.HarcosHozzadasa(szorny);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            try
            {
                arena.Csata();
            }
            catch ( Arena.CsataNemIndithatoException ex)
            {
                MessageBox.Show(ex.Message);                  
            }
            //lista frissítése
            string lastRow = lbxMessages.Items[lbxMessages.Items.Count - 1].ToString();
            lbxStatisztika.Items.Add(lastRow);
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

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> lista = new List<string>();

            for (int i = 0; i < lbxStatisztika.Items.Count; i++)
            {
                lista.Add(lbxStatisztika.Items[i].ToString());
            }
            adatKezelo.Mentes(lista);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbxStatisztika.Items.Clear();

            List<string> lista;
            try
            {
                lista = adatKezelo.Betoltes();
                for (int i = 0; i < lista.Count; i++)
                {
                    lbxStatisztika.Items.Add(lista[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nincs korábbi statisztika!");
            }

        }
    }
}