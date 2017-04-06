using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedList
{
    class Program
    {
        static Ember Head = null;

        static void hozzafuz(Ember ember)
        {
            if (Head == null)
            {
                // Üres a lista
                Head = ember;
            }
            else
            {
                // nem üres lista, be kell járnunk
                Ember act = Head;
                while (act.Kovetkezo != null)
                    act = act.Kovetkezo;

                act.Kovetkezo = ember;
            }
        }

        static void kiirat()
        {
            Ember act = Head;

            while(act!=null)
            {
                Console.WriteLine("Nev:{0}, Kor:{1}", act.Nev, act.Kor);
                act = act.Kovetkezo;
            }
        }

        static void Main(string[] args)
        {
            Ember e = new Ember()
            {
                Nev = "Géza",
                Kor = 12
            };

            hozzafuz(e);
            hozzafuz(new Ember()
            {
                Nev = "Anna",
                Kor = 89
            });
            hozzafuz(new Ember()
            {
                Nev="Fanni",
                Kor=34
            });

            kiirat();

            Console.ReadKey();
        }
    }
}
