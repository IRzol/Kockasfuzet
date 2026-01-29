using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockasfuzet.Models
{
    internal class Szamla
    {
        int id;
        int szolgaltatoazon;
        string szolgaltaorovidnev;
        DateTime tol;
        DateTime ig;
        int osszeg;
        DateTime hatarido;
        DateTime befizetve;
        string megjegyzes;

        public Szamla(int id, int szolgaltatoazon, string szolgaltaorovidnev, DateTime tol, DateTime ig, int osszeg, DateTime hatarido, DateTime befizetve, string megjegyzes)
        {
            this.id = id;
            this.szolgaltatoazon = szolgaltatoazon;
            this.szolgaltaorovidnev = szolgaltaorovidnev;
            this.tol = tol;
            this.ig = ig;
            this.osszeg = osszeg;
            this.hatarido = hatarido;
            this.befizetve = befizetve;
            this.megjegyzes = megjegyzes;
        }

        public int Id { get => id; set => id = value; }
        public int Szolgaltatoazon { get => szolgaltatoazon; set => szolgaltatoazon = value; }
        public string Szolgaltaorovidnev { get => szolgaltaorovidnev; set => szolgaltaorovidnev = value; }
        public DateTime Tol { get => tol; set => tol = value; }
        public DateTime Ig { get => ig; set => ig = value; }
        public int Osszeg { get => osszeg; set => osszeg = value; }
        public DateTime Hatarido { get => hatarido; set => hatarido = value; }
        public DateTime Befizetve { get => befizetve; set => befizetve = value; }
        public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }
    }
}