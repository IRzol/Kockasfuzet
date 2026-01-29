using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockasfuzet.Models
{
    internal class Szolgaltatas
    {
        int azon;
        string nev;

        public Szolgaltatas(int azon, string nev)
        {
            this.azon = azon;
            this.nev = nev;
        }
        public Szolgaltatas() { }

        public int Azon { get => azon; set => azon = value; }
        public string Nev { get => nev; set => nev = value; }

        public override string ToString()
        {
            return $"Id: {Azon},Név: {Nev}";
        }
    }
}