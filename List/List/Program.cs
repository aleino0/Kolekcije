using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        class Klasa
        {
            int godina;
            string ime, prezime;

            public Klasa(int godina, string prezime)
            {
                this.godina = godina;
                this.prezime = prezime;
               
            }

            public override string ToString()
            {
                string ispis = "Godina: " + this.godina +
                    "Ime: " + this.ime +
                    " Prezime: " + this.prezime;
                return ispis;
            }

            public int Godina { get => godina; set => godina = value; }
            public string Prezime { get => prezime; set => prezime = value; }
            public string Ime { get => ime; set => ime = value; }
        }

        static void Main(string[] args)
        {
            List<Klasa> ListaObjekata = new List<Klasa>();
            int godina;
            string prezime;
               
            for(int i =0;i<3;i++)
            {
                Console.WriteLine("Unesi godinu: ");
                godina = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Unesi prezime: ");
                prezime = Console.ReadLine();
                Klasa objekt = new Klasa(godina, prezime);

                ListaObjekata.Add(objekt);
            }

            foreach(Klasa o in ListaObjekata)
            {
                if(o.Godina<2023)
                {
                    o.Ime = "Gabriel";
                    Console.WriteLine(o.Prezime);
                    Console.WriteLine(o.Ime);
                }
            }

            Console.ReadKey();
        }
    }
}