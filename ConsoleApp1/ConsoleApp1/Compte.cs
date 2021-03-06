using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Compte
    {
        private readonly Client Titulaire;
        private static int cpt = 0 ;
        private readonly int num_compte;
        private MAD solde;
        private static MAD plafond= new MAD( 2000);
       
       public Compte(Client c, MAD s )
        {
            this.num_compte = ++cpt;
            this.Titulaire = c;
            this.solde = s;
        }
        public void Consulter()
        {
            Console.WriteLine(" Le numero de compte est : " + this.num_compte + " Le solde est: " + this.solde.showVal());
           
        }
        public bool Crediter( MAD Sum)
        {
            this.solde = this.solde.add(Sum) ;
            return true;

        }
        public bool Debiter(MAD Sum)
        {
            if(this.solde.comparer(Sum) == 1 && Sum.comparer(plafond) == -1)
            {
                this.solde = this.solde.sous(Sum);
                return true;
            }
            else
            {
                Console.WriteLine(" Solde insuffisant ");
                return false;
            }
           
        }
       public bool Virement( Compte C , MAD Sum)
        {
            if (this.solde.comparer(Sum) == 1 && Sum.comparer(plafond) == -1)
            {
                this.Debiter(Sum);
                C.Crediter(Sum);

            return true;
            }
            else return false;
            }
        }
}
