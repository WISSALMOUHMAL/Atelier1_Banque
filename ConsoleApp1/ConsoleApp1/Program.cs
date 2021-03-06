using System;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Cl1 = new Client("wissal", "mouhmal", "casa");
            Client Cl2 = new Client("fati", "tahri", "rabat");
            MAD S1 = new MAD(10000);
            MAD S2 = new MAD(1000);
            MAD S3 = new MAD(500);
            Compte C1 = new Compte( Cl1 , S1);
            Compte C2 = new Compte(Cl2 , S2);
            C1.Consulter();
            C2.Consulter();
           C1.Crediter(S1);
            C1.Consulter();
           C1.Debiter(S2);
            C1.Consulter();
            C1.Virement(C2 ,S3 );
            Console.ReadKey();

        }
    }
}
