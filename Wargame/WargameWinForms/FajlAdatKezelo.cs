using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WargameWinForms
{
    class FajlAdatKezelo : IAdatKezelo
    {
        public void Mentes(List<string> lista)
        {
            if (File.Exists("eredmenyek.txt"))
            {
                File.Delete("eredmenyek.txt");
            }
            FileStream fajl = new FileStream("eredmenyek.txt", FileMode.Create);
            StreamWriter iras = new StreamWriter(fajl);
            for (int i=0; i<lista.Count; i++)
            {
                iras.WriteLine(lista[i]);
            }
            iras.Close();
            fajl.Close();
        }

        public List<string> Betoltes()
        {
            List<string> lista = new List<string>();

            if (File.Exists("eredmenyek.txt"))
            {
                FileStream fajl = new FileStream("eredmenyek.txt", FileMode.Open);
                StreamReader olvasas = new StreamReader(fajl);
               
                while (! olvasas.EndOfStream)
                {
                   lista.Add(olvasas.ReadLine());
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
                return lista;
        }
    }
}
