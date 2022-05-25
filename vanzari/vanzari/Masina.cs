using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanzari
{
    public class Masina:Obiect
    {
        String marca;
        int an_fabricatie;
       
        public string Marca { get => marca; set => marca = value; }
        public int An_fabricatie { get => an_fabricatie; set => an_fabricatie = value; }
        public Masina()
        {

        }
        public Masina(float pret, String nr_tel,String oMarca, int unAn_fabricatie):base(pret,nr_tel)
        {
            this.Marca = oMarca;
            this.An_fabricatie = unAn_fabricatie;
        }
        public override string Descriere()
        {
            return base.Descriere() + " " + this.Marca + " " + this.An_fabricatie;
        }

        public void readMasini()
        {
            Console.WriteLine("Introduceti date despre masina: ");
            Console.WriteLine("Pretul: ");
            this.Pret=float.Parse(Console.ReadLine());
            Console.WriteLine("Nr de telefon:");
            this.Nr_tel = Console.ReadLine();
            Console.WriteLine("Marca: ");
            this.Marca = Console.ReadLine();
            Console.WriteLine("An fabricatie: ");
            this.An_fabricatie = int.Parse(Console.ReadLine());
            Masina ms = new Masina(Pret,Nr_tel,Marca,An_fabricatie);
            elemente.Add(ms);
            nrElemente++;
        }
        //asa nu iasa
      /* public int cautaMasini(String Mrc)
        {
            String marcaCautat = Mrc;
            int nr = 0;
            var interogare =
            from mas in elemente
            where (Masina) mas.Marca == marcaCautat
            select mas;

           
            
            foreach (var mas in interogare)
            {
                foreach (Masina m in mas)
                {
                    Console.WriteLine(m.Descriere());
                    nr++;
                }
            }
            return nr;
        }
      */
      

    }
}
