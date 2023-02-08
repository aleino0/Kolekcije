using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije
{

    class Program
    {
        class Klasa
        {
            int godina;
            string prezime;

            public Klasa(int godina, string prezime)
            {
                this.godina = godina;
                this.prezime = prezime;
            }

            public override string ToString()
            {
                string ispis = "Godina: " + this.godina +
                    " Prezime: " + this.prezime;
                return ispis;
            }

            public int Godina { get => godina; set => godina = value; }
        }

        static void Main(string[] args)
        {
            //definiranje ArrayList kolekcije
            ArrayList al = new ArrayList();

            int broj = 1;
            string ime = "ime";
            bool provjera = false;
            Klasa objekt = new Klasa(2023, "prezime");

            al.Add(objekt);
            al.Add(provjera);
            al.Add(broj);
            al.Add(ime);

            //ispis
            Console.WriteLine("------ispis svih elemenata------");
            for(int i =0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
            al.RemoveAt(2);
            

            Console.WriteLine("------ispis svih elemenata------");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            al.Insert(2, broj);

            Console.WriteLine("------ispis svih elemenata------");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            Console.ReadKey();
        }
    }
}
