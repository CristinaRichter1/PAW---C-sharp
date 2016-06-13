using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programari_cabinet_medical
{   
    public class Programare
    {
        private readonly int cod;
        private String numePacient;
        private DateTime data;
        public enum Specialitate { Interna, Recuperare, Orl };
        private Specialitate specialitate;        

        internal Specialitate Specialitate1
        {
            get { return specialitate; }
            set { specialitate = value; }
        }

        public Programare(int cod, String numePacient, DateTime data, int specialitate)
        {
            if (data.Hour > 7 && data.Hour < 19)
            {
                this.data = data;
                this.cod = cod;
                this.numePacient = numePacient;
                this.specialitate = (Specialitate)specialitate;
            }
            else
            {
                throw new Exception("Ora trebuie sa fie intre 8:00 si 18:00!");
            }
        }

        public int Cod
        {
            get { return this.cod; }
        }

        public String NumePacient
        {
            get { return this.numePacient; }
            set { numePacient = value; }
        }

        public DateTime Data
        {
            get { return this.data; }
            set
            {
                if (data.Hour > 7 || data.Hour < 19)
                {
                    this.data = value;
                }
            }
        }

        public override string ToString()
        {
            return this.Cod + " " + this.NumePacient + " " + this.Specialitate1;
        }
    }
}
