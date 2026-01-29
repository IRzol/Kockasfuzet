using Kockasfuzet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockasfuzet.Views
{
    internal class SzamlaView
    {

        public void ShowSzamlaList(List<Szamla> szamlalista)
        {
            Console.WriteLine("|----+----------------+----------+----------+-------+----------+----------+----------|");
            Console.WriteLine("| Id |SzolgáltatóRövid|    Tól   |    Ig    |Összeg | Határidő |Befizetve |Megjegyzés|");
            Console.WriteLine("|----|----------------|----------|----------|-------|----------|----------|----------|");
            foreach (Szamla szamla in szamlalista)
            {
                Console.WriteLine(SzamlaToRow(szamla));
            }
            Console.WriteLine("|----+----------------+----------+----------+-------+----------+----------+----------+");
        }

        private static string SzamlaToRow(Szamla sz)
        {
            string row = "|";

            row += sz.Id;
            row += new string(' ', 4 - sz.Id.ToString().Length) + "|";

 

            row += sz.Szolgaltatorovid;
            row += sz.Szolgaltatorovid.Length < 16
                ? new string(' ', 16 - sz.Szolgaltatorovid.Length) + "|"
                : "...|";

            row += sz.Tol.ToString("yyyy-MM-dd");
            row += new string(' ', 10 - sz.Tol.ToString("yyyy-MM-dd").Length) + "|";

            row += sz.Ig.ToString("yyyy-MM-dd");
            row += new string(' ', 10 - sz.Ig.ToString("yyyy-MM-dd").Length) + "|";

            row += sz.Osszeg;
            row += new string(' ', 7 - sz.Osszeg.ToString().Length) + "|";

            row += sz.Hatarido.ToString("yyyy-MM-dd");
            row += new string(' ', 10 - sz.Hatarido.ToString("yyyy-MM-dd").Length) + "|";

            row += sz.Befizetve.ToString("yyyy-MM-dd");
            row += new string(' ', 10 - sz.Befizetve.ToString("yyyy-MM-dd").Length) + "|";

            row += sz.Megjegyzes;
            row += sz.Megjegyzes.Length < 16
                ? new string(' ', 10 - sz.Megjegyzes.Length) + "|"
                : "...|";

            return row;
        }
    }
}
