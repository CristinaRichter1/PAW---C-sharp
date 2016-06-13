using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Programari_cabinet_medical
{
    public class Cabinet
    {
        public delegate void DelegatAdaugareProgramare(Programare p);
        DelegatAdaugareProgramare AdaugareProgramare;

        private List<Programare> listaProgramari = new List<Programare>();
        public Programare this[int index]
        {
            get { return listaProgramari[index]; }
            set { listaProgramari[index] = value; }
        }

        public List<Programare> ListaProgramari
        {
            get { return listaProgramari; }
            set { listaProgramari = value; }
        }

        public Cabinet() { }

        public int NumarProgramari
        {
            get { return listaProgramari.Count; }
        }

        public void AfisareInformatii(Programare p)
        {
            Console.WriteLine("Ultima programare a fost: " + p.ToString());
        }

        public void AdaugaProgramare(Programare p)
        {
            listaProgramari.Add(p);
            AdaugareProgramare = new DelegatAdaugareProgramare(AfisareInformatii);
            AdaugareProgramare(p);
        }

        public Programare[] ObtineProgramari(DateTime d)
        {
            Programare[] programari = new Programare[listaProgramari.Count];
            int i = 0;
            foreach (Programare p in listaProgramari)
            {
                if (p.Data.Day == d.Day)
                {
                    programari[i] = p;
                    i++;
                }
            }
            return programari;
        }
    }
}