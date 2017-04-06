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

            // 0. hely teszt

            Console.WriteLine("***Beszúrás teszt***");

            ll.beszuras(new Ember()
            {
                Nev = "Nulla",
                Kor = 0
            }
            , 0
            );

            ll.beszuras(new Ember()
            {
                Nev = "1",
                Kor = 1
            }
            , 1
            );

            ll.beszuras(new Ember()
            {
                Nev = "3",
                Kor = 3
            }
            , 3
            );

            ll.beszuras(new Ember()
            {
                Nev = "100",
                Kor = 100
            }
            , 100
            );

            ll.kiirat();

            Console.WriteLine("***Törlés teszt***");


            ll.torles(0);
            ll.torles(1);
            ll.kiirat();

            Console.WriteLine("***Kutya teszt***");
            KutyaLancoltLista kll = new KutyaLancoltLista();

            kll.hozzafuz(new Kutya()
            {
                Nev = "Bloki_0",
                Testsuly = 0
            });

            kll.beszuras(new Kutya()
            {
                Nev = "Bloki_00",
                Testsuly = 1
            },0);

            kll.hozzafuz(new Kutya()
            {
                Nev = "Spárga_32",
                Testsuly = 32
            });

            kll.hozzafuz(new Kutya()
            {
                Nev = "Barna",
                Testsuly = 45
            });

            kll.torles(3);
            kll.kiirat();


            Console.ReadKey();
        }
    }
}
