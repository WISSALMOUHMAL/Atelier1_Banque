using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MAD
    {
        double valeur;
        public MAD(double val)
        {
            this.valeur = val;
        }
        public MAD add(MAD val)
        {
            this.valeur += val.valeur;
            return this;
        }
        public int comparer(MAD val)
        {
            if (this.valeur >= val.valeur) 
            return 1;
            else
                return -1;
        }
        public MAD sous(MAD val)
        {
            this.valeur -= val.valeur;
            return this;
        }
        public string showVal()
        {

            string s = valeur.ToString();
            return s;

        }

    }
}
