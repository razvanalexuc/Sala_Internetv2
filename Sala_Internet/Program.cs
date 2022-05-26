using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase;
using Administrare_Fisier;
using System.Configuration;

namespace Sala_Internet
{
	public class Program
	{
        private static string nume_pers;
        private static string cod_pers;
        private static string nume_comp;
        private static string cod_comp;
		static void Main(string[] args)
		{
          //!!! string numeFisier = args[0];
            //Fisier pentru Persoane
            string Fisier_Persoane = ConfigurationManager.AppSettings["Persoane"];
            string locatiefisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatiefisierSolutie + "\\" + Fisier_Persoane;
            AdministrarePersoane_FisierText administrarePersoane = new AdministrarePersoane_FisierText(caleCompletaFisier);
            Persoana persoananew = new Persoana();
            int nrPers = 0;
            administrarePersoane.GetPersoane(out nrPers);

            //Fisier pentru Periferice

            string Fisier_Periferice = ConfigurationManager.AppSettings["Periferice"];
            string locatiefisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier1 = locatiefisierSolutie1 + "\\" + Fisier_Periferice;
            AdministrarePeriferice_FisierText administrarePeriferice = new AdministrarePeriferice_FisierText(caleCompletaFisier1);
            Periferice perifericnew = new Periferice();
            int nrPerif = 0;
            administrarePeriferice.GetPeriferice(out nrPerif);


            //Fisier pentru Componente
            string Fisier_Componente = ConfigurationManager.AppSettings["Componente"];
            string locatiefisierSolutie2 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier2 = locatiefisierSolutie2 + "\\" + Fisier_Componente;
            AdministrareComponente_FisierText administrareComponente = new AdministrareComponente_FisierText(caleCompletaFisier2);
            int nrComp = 0;
            Componente componentanew = new Componente();
            administrareComponente.GetComponente(out nrComp);


            // program
            int IdPers = 0;
            int IdPerif = 0;
            int IdComp = 0;

            string optiune;
            do
            {
                Console.WriteLine("A. Afisare Persoane din file ");
                Console.WriteLine("B. Salvare Persoane in file");
                Console.WriteLine("C. Citirea de la tastatura a persoanelor");
                Console.WriteLine("D. Cautarea unui utilizator al calculatorului");
                Console.WriteLine("E. Adaugati si afisati perifericele dorite"); 
                Console.WriteLine("F. Adaugati si afisati Componentele dorite"); 
                Console.WriteLine("G. Alegerea calculatorului in functie de obiectiv");
                Console.WriteLine("W. Afisati perifericele introduse");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        Persoana[] persoane = administrarePersoane.GetPersoane(out nrPers);
                        AfisarePersoane(persoane, nrPers);
                        break;
                    case "B":
                        nrPers++;
                        persoananew.SetcodPersoana(nrPers+IdPers);
                        administrarePersoane.AddPersoane(persoananew);

                        break;
                    case "C":
                        persoananew=CitireTastatura();
                        break;
                    case "D":
                        Console.WriteLine("Introduceti codul utilizatorului pe care doriti sa il cautati:");
                        cod_pers = Console.ReadLine();
                        Console.WriteLine("Introduceti numele utilizatorului pe care doriti sa il cautati:");
                        nume_pers = Console.ReadLine();
                        Persoana existingPers = administrarePersoane.CautarePersoana(cod_pers, nume_pers);
                        if (existingPers == null)
                        {
                            Console.WriteLine("Persoana cautata nu figureaza pe lista.");
                        }
                        else
                        {
                            Console.WriteLine(string.Format("Utilizatorul gasit are codul #{0} si se numeste: {1}",
                                existingPers.GetIdPers(),
                                existingPers.GetNume() ?? "NECUNOSCUT"));
                        }
                        break;
                    case "E":
                        perifericnew = CitirePerifTastatura();
                        nrPerif++;
                        perifericnew.SetCodPeriferice(nrPerif + IdPerif);
                        administrarePeriferice.AddPeriferice(perifericnew);
                        break;

                    case "W":
                        nrPerif++;
                        perifericnew.SetCodPeriferice(nrPerif + IdPerif);
                        administrarePeriferice.AddPeriferice(perifericnew);
                        Periferice[] periferice = administrarePeriferice.GetPeriferice(out nrPerif);
                        AfisarePeriferice(periferice, nrPerif);

                        break;

                    case "F":
                        componentanew = CitireCompTastatura();
                        nrComp++;
                        componentanew.SetcodComponenta(nrComp + IdComp);
                        administrareComponente.AddComponente(componentanew);
                        break;

                    case "Z":
                        nrComp++;
                        componentanew.SetcodComponenta(nrComp + IdComp);
                        administrareComponente.AddComponente(componentanew);
                        Componente[] componenta = administrareComponente.GetComponente(out nrComp);
                        AfisareComponente(componenta, nrComp);
                        break;

                    case "G":
                        Console.WriteLine("Alegeti pachetul dorit:");
                        Console.WriteLine("1 - GAMING \n" +
                            "2 - OFFICE \n" +
                            "3 - RENDER \n" +
                            "4 - BASIC \n");
                        int alegere = Convert.ToInt32(Console.ReadLine());
                        if (alegere == (int)PACHET_GAMING)
                        {
                            Console.WriteLine($"Ati ales pachetul de:"
                              + $"{PACHET_GAMING.ToString().ToUpper()}");
                              }
                        else
                        {
                            Console.WriteLine($"Ati ales pachetul: {(PachetCalculator)alegere}");
                        }
                        Console.ReadKey();
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiunea introdusa este inexistenta!");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        // FUNCTII PENTRU PERSOANA

        public static void AfisarePersoane(Persoana[] persoane, int nrPers)
        {
            Console.WriteLine("Utilizatorii calculatorului sunt:");
            for (int contor = 0; contor < nrPers; contor++)
            {
                string infoPersoana = string.Format("Utilizatorul cu id-ul #{0} are numele: {1} {2}, varsta de {3}, iar numarul de ore achizitionate este {4}",
                    persoane[contor].GetIdPers(),
                    persoane[contor].GetNume() ?? "NECUNOSCUT",
                    persoane[contor].GetPrenume() ?? "NECUNOSCUT",
                    persoane[contor].GetVarsta(),
                    persoane[contor].Getnr_ore());
                Console.WriteLine(infoPersoana);

            }
        }


        public static Persoana CitireTastatura()
        {
            Console.WriteLine("Introduceti numele utilizatorului de calculator:");
            string Nume = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele utilizatorului de calculator:");
            string Prenume = Console.ReadLine();
            Console.WriteLine("Introduceti varsta utilizatorului de calculator:");
            int Varsta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de ore achizitionate:");
            int Nr_ore = Convert.ToInt32(Console.ReadLine());

            Persoana persoana = new Persoana(0, Nume, Prenume, Varsta, Nr_ore);
            return persoana;

        }

        // FUNCTII PENTRU PERIFERICE


        public static void AfisarePeriferice(Periferice[] periferic, int nrPerif)
        {
            Console.WriteLine("Perifericele sunt:");
            for (int contor = 0; contor < nrPerif; contor++)
            {
                string infoPeriferice = string.Format("Setul de periferice cu id-ul #{0} are componentele: {1} {2}, {3}, {4}",
                    periferic[contor].GetIdSetPerif(),
                    periferic[contor].Getmonitor() ?? "NECUNOSCUT",
                    periferic[contor].Getmouse() ?? "NECUNOSCUT",
                    periferic[contor].Gettastatura() ?? "NECUNOSCUT",
                    periferic[contor].Getcasti() ?? "NECUNOSCUT");
                Console.WriteLine(infoPeriferice);

            }
        }

        public static Periferice CitirePerifTastatura()
        {
            Console.WriteLine("Introduceti monitorul: ");
            string Monitor = Console.ReadLine();
            Console.WriteLine("Introduceti mouse-ul: ");
            string Mouse = Console.ReadLine();
            Console.WriteLine("Introduceti tastatura: ");
            string Tastatura = Console.ReadLine();
            Console.WriteLine("Introduceti castile:");
            string Casti = Console.ReadLine();

            Periferice periferic = new Periferice(0, Monitor, Mouse, Tastatura, Casti);
            return periferic;

        }

        // FUNCTII PENTRU COMPONENTE

        public static void AfisareComponente(Componente[] componenta, int nrComp)
        {
            Console.WriteLine("Perifericele sunt:");
            for (int contor = 0; contor < nrComp; contor++)
            {
                string infoComponente = string.Format("Setul de componente cu id-ul #{0} are: {1} {2}, {3}, {4}, {5}, {6}",
                    componenta[contor].GetIdSetComp(),
                    componenta[contor].GetMOBO() ?? "NECUNOSCUT",
                    componenta[contor].GetRAM(),
                    componenta[contor].GetCPU() ?? "NECUNOSCUT",
                    componenta[contor].Getcool() ?? "NECUNOSCUT",
                    componenta[contor].GetHardDisk() ?? "NECUNOSCUT",
                    componenta[contor].GetSolidDrive() ?? "NECUNOSCUT");
                Console.WriteLine(infoComponente);

            }
        }

        public static Componente CitireCompTastatura()
        {
            Console.WriteLine("Introduceti placa de baza: ");
            string Mobo = Console.ReadLine();
            Console.WriteLine("Introduceti RAM-ul: ");
            int Ram = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti procesorul: ");
            string Cpu = Console.ReadLine();
            Console.WriteLine("Introduceti placa video:");
            string Gpu = Console.ReadLine();
            Console.WriteLine("Introduceti cooler-ul: ");
            string Cooler = Console.ReadLine();
            Console.WriteLine("Introduceti Hard Disk-ul: ");
            string Hdd = Console.ReadLine();
            Console.WriteLine("Introduceti Solid State Drive-ul: ");
            string Ssd = Console.ReadLine();


            Componente componenta = new Componente(0, Mobo, Ram, Cpu, Gpu, Cooler, Hdd, Ssd);
            return componenta;

        }

        // ENUMERARI
        public enum PachetCalculator
        {
            Gaming = 1,
            Office = 2,
            Render = 3,
            Basic = 4

        };

        public const PachetCalculator PACHET_GAMING = PachetCalculator.Gaming;
        public const PachetCalculator PACHET_OFFICE = PachetCalculator.Office;
        public const PachetCalculator PACHET_RENDER = PachetCalculator.Render;
        public const PachetCalculator PACHET_BASIC = PachetCalculator.Basic;


        // WIP - TBA
        public static void AfisareCalculator()
        {

        }


    }
	}
