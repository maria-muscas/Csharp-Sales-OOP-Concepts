using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanzari
{
    public class Imobil:Obiect
    {
        String tip;
        float suprafata;
        int nr_camere;
        
        public string Tip { get => tip; set => tip = value; }
        public float Suprafata { get => suprafata; set => suprafata = value; }
        public int Nr_camere { get => nr_camere; set => nr_camere = value; }
        public Imobil()
        {

        }
        public Imobil(float pret, String nr_tel,String unTip,float oSuprafata, int cNr_camere ):base(pret,nr_tel)
        {
            this.Tip = unTip;
            this.Suprafata = oSuprafata;
            this.Nr_camere = cNr_camere;
        }

        public override String Descriere()
        {
            return base.Descriere() + " " + this.Tip + " " + this.Suprafata + " " + this.Nr_camere;
        }
        public void readImobile()
        {
           
            Console.WriteLine("Introduceti date despre imobil: ");
            Console.WriteLine("Pretul: ");
            this.Pret = float.Parse(Console.ReadLine());
            Console.WriteLine("Nr de telefon:");
            this.Nr_tel = Console.ReadLine();
            Console.WriteLine("Tipul:");
            this.Tip = Console.ReadLine();
            Console.WriteLine("Suprafata: ");
            this.Suprafata = float.Parse(Console.ReadLine());
            Console.WriteLine("Nr camere: ");
            this.Nr_camere = int.Parse(Console.ReadLine());
            Imobil imob = new Imobil(Pret,Nr_tel,Tip,Suprafata,Nr_camere);
            elemente.Add(imob);
            nrElemente++;
        }
    }
}
