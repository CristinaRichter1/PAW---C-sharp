using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestiune_Autovehicule
{
    class Auto : Vehicul
    {
        private float putere;

        public Auto(int id, String marca, float putere): base(id, marca)
        {
            this.putere = putere;
        }

        public float Putere
        {
            get { return this.putere; }
            set { this.putere = value; }
        }

        public static bool operator<(Auto a1, Auto a2)
        {
            if (a1.Putere < a2.Putere)
                return true;
            else
                return false;
        }

        public static bool operator>(Auto a1, Auto a2)
        {
            if (a1.Putere > a2.Putere)
                return true;
            else
                return false;
        }

        public static float operator +(Auto a1, Auto a2)
        {
            return a1.Putere + a2.Putere;
        }

        public float mediePutere(Auto[] automo)
        {
            float med1 = automo[0] + automo[1];
            float med2 = automo[2] + automo[3];
            return med1 + med2;
        }
    }
}
