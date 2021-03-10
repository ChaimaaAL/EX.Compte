using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class MAD
    {
        private double valeur;

        public MAD(double valeur)
        {
            this.valeur = valeur;
        }

        public static MAD operator +(MAD v1, MAD v2)
        {
            return new MAD(v1.valeur + v2.valeur);
        }

        public static MAD operator -(MAD v1, MAD v2)
        {
            return new MAD(v1.valeur - v2.valeur);
        }
        public static bool operator >=(MAD v1, MAD v2)
        {
            if (v1.valeur >= v2.valeur)
            {
                return true;
            }
            else { return false; }
        }

        public static bool operator <=(MAD v1, MAD v2)
        {
            if (v1.valeur <= v2.valeur)
            {
                return true;
            }
            else { return false; }
        }

        public void Afficher()
        {
            Console.WriteLine("La valeur  " + valeur + " MAD");
        }
    }
}
