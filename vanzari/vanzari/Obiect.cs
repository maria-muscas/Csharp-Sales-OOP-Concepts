using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanzari
{
    public abstract class Obiect
    {
        float pret;
        String nr_tel;
        protected static List<Obiect> elemente = new List<Obiect>();
        protected static int nrElemente = 0;

        public float Pret { get => pret; set => pret = value; }
        public string Nr_tel { get => nr_tel; set => nr_tel = value; }

        public Obiect()
        {

        }
        public Obiect (float unPret, String unNr_tel)
        {
           this.Pret=unPret;
           this.Nr_tel=unNr_tel;
        }

        public virtual String Descriere()
        {
            return this.Pret + " " + this.nr_tel;
        }
        public void Write2Console()
        {
            for(int i=0;i<nrElemente;i++)
            {
                if (elemente[i] is Masina)
                    Console.WriteLine(elemente[i].Descriere());
                else
                    if (elemente[i] is Imobil)
                    Console.WriteLine(elemente[i].Descriere());

            }
        }
        public int cauta1(String mrc)
        {
            String marcaCautat = mrc;
            int nr = 0;
            foreach(Masina m in elemente)
            {
                if (m.Marca == marcaCautat)
                {
                    Console.WriteLine(m.Descriere());
                    nr++;

                }
                   
            }
            return nr;
        }
    }
}
