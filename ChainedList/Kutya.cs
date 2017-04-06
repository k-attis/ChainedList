using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedList
{
    class Kutya
    {
        public Kutya Kovetkezo = null; // Next

        public String Nev;
        public int  Testsuly;

        public void kiir()
        {
            Console.WriteLine("Nev:{0}, Testsuly:{1}",
                Nev,
                Testsuly);
        }
    }
}
