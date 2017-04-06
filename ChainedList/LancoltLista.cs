using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainedList
{
    class LancoltLista
    {
        Ember Head = null;

        public void hozzafuz(Ember ember)
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

        public void kiirat()
        {
            Ember act = Head;

            while (act != null)
            {
                act.kiir();
                act = act.Kovetkezo;
            }
        }

        public Ember keres(int kor)
        {
            Ember act = Head;

            while (act != null)
            {
                if (act.Kor == kor)
                    return act;
                act = act.Kovetkezo;
            }

            return null;
        }

        public Ember ndik(int n)
        {
            Ember act = Head;
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

        public Ember this[int i]
        {
            get { return ndik(i); }
        }

        public int Count()
        {
            int db = 0;

            Ember act = Head;

            while (act != null)
            {
                act = act.Kovetkezo;
                db++;
            }

            return db;
        }

        public void beszuras(Ember ember, int idx)
        {
            Ember act = Head;

            if (Head == null)
            {
                hozzafuz(ember);
                return;
            }

            if (idx==0)
            {
                ember.Kovetkezo = null;
                Head = ember;
                return;              
            }

            int db = 0;

            while (act != null)
            {
                if(db == idx-1)
                {
                    ember.Kovetkezo = act.Kovetkezo;
                    act.Kovetkezo = ember;
                    return;
                }
                act = act.Kovetkezo;
                db++;
            }

            hozzafuz(ember);
        }
    }
}
