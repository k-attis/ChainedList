using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LancoltLista ll = new LancoltLista();

            Ember e = new Ember()
            {
                Nev = "Géza",
                Kor = 12
            };

            ll.hozzafuz(e);
            ll.hozzafuz(new Ember()
            {
                Nev = "Anna",
                Kor = 89
            });
            ll.hozzafuz(new Ember()
            {
                Nev = "Fanni",
                Kor = 34
            });

            ll.kiirat();

            Ember x = ll.keres(89);
            if (x == null)
                Console.WriteLine("Nincs 89 éves a listában");
            else
            {
                Console.WriteLine("Van 89 éves a listában");
                x.kiir();
            }

            Ember y = ll.ndik(2);
            Console.WriteLine("2. elem:");
            y.kiir();

            y = ll[2];
            Console.WriteLine("2. elem:");
            y.kiir();

            for (int idx = 0; idx < ll.Count(); idx++)
            {
                ll[idx].kiir();
            }


            Console.ReadKey();
        }
    }
}
