using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedList
{
    class Ember
    {
        public Ember Kovetkezo = null; // Next

        public String Nev;
        public int Kor;

        public void kiir()
        {
            Console.WriteLine("Nev:{0}, Kor:{1}",
                Nev, 
                Kor);
        }
    }
}
