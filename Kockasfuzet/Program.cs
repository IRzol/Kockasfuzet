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
            Console.WriteLine("1. Szolgáltatók megjelenítése");
            Console.WriteLine("2. Szolgáltatások megjelenítése");
            Console.WriteLine("3. Számla megjelenítése");
            Console.WriteLine("4. Kilépés");
            string valasz = Console.ReadLine();
            string altvalasz;
            switch (valasz)
            {
                //case "1":
                //    Szolgaltato ujSzolgaltato = new Szolgaltato()
                //    {
                //        RovidNev = "ABC",
                //        Nev = "Helyi kis abc",
                //        Ugyfelszolgalat = "Miskolc, Kamra köz 3"
                //    };
                //    new SzolgaltatoView().ShowSzolgaltato(ujSzolgaltato);
                //    break;
                case "1":
                    //List<Szolgaltato> szolgaltatokListaja = new List<Szolgaltato>()
                    //{
                    //    new Szolgaltato(){
                    //        RovidNev = "ABC",
                    //        Nev = "Helyi kis abc",
                    //        Ugyfelszolgalat = "Miskolc, Kamra köz 3" },
                    //    new Szolgaltato(){
                    //        RovidNev = "DEF",
                    //        Nev = "Dávid Esti Falatozója",
                    //        Ugyfelszolgalat = "Miskolc, Bendőtömő utca 4" },
                    //    new Szolgaltato(){
                    //        RovidNev = "GHI",
                    //        Nev = "Gazdagság Halmozó Intézet",
                    //        Ugyfelszolgalat = "Brüsszel, Tulip str. 3" }, 
                    //};
                    Console.Clear();
                    List<Szolgaltato> listaAdatbazisbol = new SzolgaltatoController().GetSzolgaltatoList();
                    new SzolgaltatoView().ShowSzolgaltatoList(listaAdatbazisbol);
                    Console.WriteLine("1. Új szolgáltató rögzítése");
                    Console.WriteLine("2. Szolgáltató módosítása");
                    Console.WriteLine("3. Szolgáltató törlése");
                    altvalasz = Console.ReadLine();
                    switch (altvalasz)
                    {
                        case "1":
                            try
                            {
                                Console.Clear();
                                new SzolgaltatoView().ShowSzolgaltatoList(listaAdatbazisbol);
                                Console.WriteLine("Kérem adja meg a rövid nevét a szolgáltatónak: ");
                                string rovidnev = Console.ReadLine();
                                Console.WriteLine("Kérem adja meg a teljes nevét a szolgáltatónak: ");
                                string nev = Console.ReadLine();
                                Console.WriteLine("Kérem adja meg az ügyfélszolgálat címét: ");
                                string ugyfelszolgalat = Console.ReadLine();
                                Szolgaltato ujSzolgaltato = new Szolgaltato()
                                {
                                    RovidNev = rovidnev,
                                    Nev = nev,
                                    Ugyfelszolgalat = ugyfelszolgalat
                                };
                                new SzolgaltatoController().CreateSzolgaltato(ujSzolgaltato);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Hiba történt a szolgáltató létrehozása közben: ");
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Enterre kilép...");
                            string vegevalasz = Console.ReadLine();
                            break;


                        case "2":
                            try
                            {
                                Console.Clear();
                                new SzolgaltatoView().ShowSzolgaltatoList(listaAdatbazisbol);
                                Console.WriteLine("Kérem adja meg a módosítani kívánt szolgáltató rövid nevét: ");
                                string eredetirovidnev = Console.ReadLine();
                                Console.WriteLine("Kérem adja meg az új rövid nevét a szolgáltatónak: ");
                                string modrovidnev = Console.ReadLine();
                                Console.WriteLine("Kérem adja meg az új teljes nevét a szolgáltatónak: ");
                                string modnev = Console.ReadLine();
                                Console.WriteLine("Kérem adja meg az új ügyfélszolgálat címét: ");
                                string modugyfelszolgalat = Console.ReadLine();
                                Szolgaltato modujSzolgaltato = new Szolgaltato()
                                {
                                    RovidNev = modrovidnev,
                                    Nev = modnev,
                                    Ugyfelszolgalat = modugyfelszolgalat
                                };
                                new SzolgaltatoController().UpdateSzolgaltato(modujSzolgaltato, eredetirovidnev);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Hiba történt a szolgáltató módosítása közben: ");
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Enterre kilép...");
                            vegevalasz = Console.ReadLine();
                            break;

                        case "3":
                            try
                            {
                                Console.Clear();
                                new SzolgaltatoView().ShowSzolgaltatoList(listaAdatbazisbol);
                                Console.WriteLine("Kérem, adja meg a törölni kívánt szolgáltató rövid nevét: ");
                                string torolrovidnev = Console.ReadLine();
                                Szolgaltato torolSzolgaltato = new Szolgaltato()
                                {
                                    RovidNev = torolrovidnev
                                };
                                new SzolgaltatoController().DeleteSzolgaltato(torolSzolgaltato);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Hiba történt a szolgáltató törlése közben: ");
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Enterre kilép...");
                            vegevalasz = Console.ReadLine();
                            break;
                    }
                    break;
                case "2":
                    Console.Clear();
                    List<Szolgaltatas> listaAdatbazisbol2 = new SzolgaltatasController().GetSzolgaltatasList();
                    new SzolgaltatasView().ShowSzolgaltatasList(listaAdatbazisbol2);
                    Console.WriteLine("1. Új szolgáltatás rögzítése");
                    Console.WriteLine("2. Szolgáltatás módosítása");
                    Console.WriteLine("3. Szolgáltatás törlése");
                    altvalasz = Console.ReadLine();
                    switch (altvalasz)
                    {
                        case "1":
                            try
                            {
                                Console.Clear();
                                new SzolgaltatasView().ShowSzolgaltatasList(listaAdatbazisbol2);
                                Console.WriteLine("Kérem adja meg a nevét a szolgáltatásnak: ");
                                string nev = Console.ReadLine();
                                Szolgaltatas ujSzolgaltatas = new Szolgaltatas()
                                {
                                    Nev = nev,
                                };
                                new SzolgaltatasController().CreateSzolgaltatas(ujSzolgaltatas);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Hiba történt a szolgáltatás létrehozása közben: ");
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Enterre kilép...");
                            string vegevalasz = Console.ReadLine();
                            break;


                        case "2":
                            try
                            {
                                Console.Clear();
                                new SzolgaltatasView().ShowSzolgaltatasList(listaAdatbazisbol2);
                                Console.WriteLine("Kérem adja meg a módosítani kívánt szolgáltató sorszámát: ");
                                int modid = int.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem adja meg az újnevét a szolgáltatásnak: ");
                                string modnev = Console.ReadLine();
                                Szolgaltatas modujSzolgaltatas = new Szolgaltatas()
                                {
                                    Id = modid,
                                    Nev = modnev,
                                };
                                new SzolgaltatasController().UpdateSzolgaltatas(modujSzolgaltatas);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Hiba történt a szolgáltatás módosítása közben: ");
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Enterre kilép...");
                            vegevalasz = Console.ReadLine();
                            break;

                        case "3":
                            try
                            {
                                Console.Clear();
                                new SzolgaltatasView().ShowSzolgaltatasList(listaAdatbazisbol2);
                                Console.WriteLine("Kérem, adja meg a törölni kívánt szolgáltatás sorszámát: ");
                                int torolId = int.Parse(Console.ReadLine());
                                new SzolgaltatasController().DeleteSzolgaltatas(torolId);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Hiba történt a szolgáltatás törlése közben: ");
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Enterre kilép...");
                            vegevalasz = Console.ReadLine();
                            break;
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("------- SZÁMLÁK -------");
                    Console.ForegroundColor = ConsoleColor.White;
                    List<Szamla> listaAdatbazisbol3 = new SzamlaController().GetSzamlaList();
                    new SzamlaView().ShowSzamlaList(listaAdatbazisbol3);
                    Console.WriteLine("1. Új számla rögzítése");
                    Console.WriteLine("2. Számla módosítása");
                    Console.WriteLine("3. Számla törlése");
                    altvalasz = Console.ReadLine();
                    switch (altvalasz)
                    {
                        case "1":
                            try
                            {
                                Console.Clear();

                                listaAdatbazisbol2 = new SzolgaltatasController().GetSzolgaltatasList();
                                new SzolgaltatasView().ShowSzolgaltatasList(listaAdatbazisbol2);
                                Console.WriteLine("Kérem adja meg a szolgáltatás azonosítóját: ");
                                int szolgaltatasazon = int.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem adja meg a szolgáltató rövidnevét: ");
                                string szolgaltatorovnev = Console.ReadLine();
                                Console.WriteLine("Kérem adja meg, hogy mikortól tartott: ");
                                DateTime tol = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem adja meg, hogy meddig tartott: ");
                                DateTime ig = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem, adja meg az összeget: ");
                                int osszeg = int.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem, adja meg a határidőt, amíg bekellett fizetnie: ");
                                DateTime hatarido = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem, adja meg a befizetés napját: ");
                                DateTime befizetve = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem, adja meg a megjegyzést: ");
                                string megjegyzes = Console.ReadLine();
                                Szamla ujSzamla = new Szamla()
                                {
                                    Szolgaltatasazon = szolgaltatasazon,
                                    Szolgaltatorovid = szolgaltatorovnev,
                                    Tol = tol,
                                    Ig = ig,
                                    Osszeg = osszeg,
                                    Hatarido = hatarido,
                                    Befizetve = befizetve,
                                    Megjegyzes = megjegyzes
                                };
                                Console.WriteLine(new SzamlaController().CreateSzamla(ujSzamla));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Hiba történt a számla létrehozása közben: ");
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Enterre kilép...");
                            string vegevalasz = Console.ReadLine();
                            break;


                        case "2":
                            try
                            {
                                Console.Clear();
                                new SzamlaView().ShowSzamlaList(listaAdatbazisbol3);
                                Console.WriteLine("Kérem adja meg a módosítani kívánt számla sorszámát: ");
                                int modint = int.Parse(Console.ReadLine());
                                listaAdatbazisbol2 = new SzolgaltatasController().GetSzolgaltatasList();
                                new SzolgaltatasView().ShowSzolgaltatasList(listaAdatbazisbol2);
                                Console.WriteLine("Kérem adja meg az új szolgáltatás azonosítóját: ");
                                int modszolgaltatasazon = int.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem adja meg az új szolgáltató rövidnevét: ");
                                string modszolgaltatorovnev = Console.ReadLine();
                                Console.WriteLine("Kérem adja meg, hogy mikortól tartott: ");
                                DateTime modtol = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem adja meg, hogy meddig tartott: ");
                                DateTime modig = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem, adja meg az új összeget: ");
                                int modosszeg = int.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem, adja meg az új határidőt, amíg bekellett fizetnie: ");
                                DateTime modhatarido = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem, adja meg az új befizetés napját: ");
                                DateTime modbefizetve = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Kérem, adja meg az új megjegyzést: ");
                                string modmegjegyzes = Console.ReadLine();
                                Szamla modujSzamla = new Szamla()
                                {
                                    Id = modint,
                                    Szolgaltatasazon = modszolgaltatasazon,
                                    Szolgaltatorovid = modszolgaltatorovnev,
                                    Tol = modtol,
                                    Ig = modig,
                                    Osszeg = modosszeg,
                                    Hatarido = modhatarido,
                                    Befizetve = modbefizetve,
                                    Megjegyzes = modmegjegyzes
                                };
                                new SzamlaController().UpdateSzamla(modujSzamla);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Hiba történt a számla módosítása közben: ");
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Enterre kilép...");
                            vegevalasz = Console.ReadLine();
                            break;

                        case "3":
                            try
                            {
                                Console.Clear();
                                new SzamlaView().ShowSzamlaList(listaAdatbazisbol3);
                                Console.WriteLine("Kérem, adja meg a törölni kívánt számla sorszámát: ");
                                int torolssz = int.Parse(Console.ReadLine());
                                new SzamlaController().DeleteSzamla(torolssz);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Hiba történt a számla törlése közben: ");
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Enterre kilép...");
                            vegevalasz = Console.ReadLine();
                            break;
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
