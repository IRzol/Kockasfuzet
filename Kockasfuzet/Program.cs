using Kockasfuzet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kockasfuzet.Views;
using Kockasfuzet.Controllers;

namespace Kockasfuzet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a választ");
            Console.WriteLine("1. Szolgáltató hozzáadása");
            Console.WriteLine("2. Szolgáltatók megjelenítése");
            Console.WriteLine("3. Szolgáltatások megjelenítése");
            Console.WriteLine("4. Számla megjelenítése");
            Console.WriteLine("5. Kilépés");
            string valasz = Console.ReadLine();
            switch (valasz) { 
            case "1":
                Szolgaltato ujSzolgaltato = new Szolgaltato()
                {
                    RovidNev = "ABC",
                    Nev = "Helyi kis abc",
                    Ugyfelszolgalat = "Miskolc, Kamra köz 3"
                };
                new SzolgaltatoView().ShowSzolgaltato(ujSzolgaltato);
                break;
            case "2":
                List<Szolgaltato> szolgaltatokListaja = new List<Szolgaltato>()
                {
                    new Szolgaltato(){
                        RovidNev = "ABC",
                        Nev = "Helyi kis abc",
                        Ugyfelszolgalat = "Miskolc, Kamra köz 3" },
                    new Szolgaltato(){
                        RovidNev = "DEF",
                        Nev = "Dávid Esti Falatozója",
                        Ugyfelszolgalat = "Miskolc, Bendőtömő utca 4" },
                    new Szolgaltato(){
                        RovidNev = "GHI",
                        Nev = "Gazdagság Halmozó Intézet",
                        Ugyfelszolgalat = "Brüsszel, Tulip str. 3" }, 
                };
                    List<Szolgaltato> listaAdatbazisbol = new SzolgaltatoController().GetSzolgaltatoList();
                new SzolgaltatoView().ShowSzolgaltatoList(listaAdatbazisbol);
                    break;
            case "3":
                    List<Szolgaltatas> listaAdatbazisbol2 = new SzolgaltatasController().GetSzolgaltatasList();
                    new SzolgaltatasView().ShowSzolgaltatasList(listaAdatbazisbol2);
                    break;
            case "4":
                    List<Szamla> listaAdatbazisbol3 = new SzamlaController().GetSzamlaList();
                    new SzamlaView().ShowSzamlaList(listaAdatbazisbol3);
                    break;
            default:
                   break;
                
            }
        }
    }
}
