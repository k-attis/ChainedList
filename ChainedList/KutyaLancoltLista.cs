using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedList
{
    class KutyaLancoltLista
    {
        Kutya Head = null;

        public void hozzafuz(Kutya Kutya)
        {
            if (Head == null)
            {
                // Üres a lista
                Head = Kutya;
            }
            else
            {
                // nem üres lista, be kell járnunk
                Kutya act = Head;
                while (act.Kovetkezo != null)
                    act = act.Kovetkezo;

                act.Kovetkezo = Kutya;
            }
        }

        public void kiirat()
        {
            Kutya act = Head;

            while (act != null)
            {
                act.kiir();
                act = act.Kovetkezo;
            }
        }

        public Kutya keres(int testsuly)
        {
            Kutya act = Head;

            while (act != null)
            {
                if (act.Testsuly == testsuly)
                    return act;
                act = act.Kovetkezo;
            }

            return null;
        }

        public Kutya ndik(int n)
        {
            Kutya act = Head;
            int idx = 0;

            while (act != null)
            {
                if (idx == n)
                    return act;
                act = act.Kovetkezo;
                idx++;
            }

            return null;
        }

        public Kutya this[int i]
        {
            get { return ndik(i); }
        }

        public int Count()
        {
            int db = 0;

            Kutya act = Head;

            while (act != null)
            {
                act = act.Kovetkezo;
                db++;
            }

            return db;
        }

        public void beszuras(Kutya Kutya, int idx)
        {
            Kutya act = Head;

            if (Head == null)
            {
                hozzafuz(Kutya);
                return;
            }

            if (idx == 0)
            {
                Kutya.Kovetkezo = Head;
                Head = Kutya;
                return;
            }

            int db = 0;

            while (act != null)
            {
                if (db == idx - 1)
                {
                    Kutya.Kovetkezo = act.Kovetkezo;
                    act.Kovetkezo = Kutya;
                    return;
                }
                act = act.Kovetkezo;
                db++;
            }

            hozzafuz(Kutya);
        }

        public void torles(int idx)
        {
            if (Head == null)
                return;

            if (idx == 0)
                Head = Head.Kovetkezo;

            int db = 0;
            Kutya act = Head;

            while (act != null)
            {
                if (db == idx - 1)
                {
                    if (act.Kovetkezo != null)
                        act.Kovetkezo = act.Kovetkezo.Kovetkezo;
                    return;
                }
                act = act.Kovetkezo;
                db++;
            }
        }
    }
}
