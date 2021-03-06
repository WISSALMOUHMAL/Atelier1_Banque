using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        public Client()
        {
            this.nom = " ";
            this.prenom = " ";
            this.adresse = " ";
        }
        public Client( string nom , string pre , string adr)
        {
            this.nom = nom;
            this.prenom = pre;
            this.adresse = adr;
        }
        public void AfficherCli()
        {
            Console.WriteLine(" Le nom est : " + this.nom);
            Console.WriteLine(" Le prenom est : " + this.prenom);
            Console.WriteLine(" Ladresse est : " + this.adresse);

        }
    }
}
