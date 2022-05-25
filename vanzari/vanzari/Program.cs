using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanzari
{
    class Program
    {
        static void Main(string[] args)
        {
            Masina m = new Masina();
            Imobil imb = new Imobil();
            int nr_vanzari,i=0,op;
            Console.WriteLine("Introduceti nr de anunturi de vanzari din ziar: ");
            nr_vanzari = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Alegeti o optiune:\n 1.Adaugare vanzari masini\n2.Adaugare vanzari imobile");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            m.readMasini();
                            i++;
                            break;
                        }
                    case 2:
                        {
                            imb.readImobile();
                            i++;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Optiune introdusa gresit!");
                            break;
                        }
                }

            } while (i < nr_vanzari);
            Console.WriteLine("Lista cu anunturi vanzari: ");
            m.Write2Console();
            string marcaCautat;
            int nr_m;
            Console.WriteLine("Introduceti marca masinii pe care o cautati: ");
            marcaCautat=Console.ReadLine();
            Console.WriteLine("Lista de masini cu marca cautata: ");
            nr_m=m.cauta1(marcaCautat);
            Console.WriteLine("Nr de masini cu marca cautata este: " + nr_m);
            Console.ReadKey();
        }
    }
}
