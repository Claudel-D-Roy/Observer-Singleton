using Bourse.Observer;
using Bourse.Singleton;
using Bourse.State;

namespace Tp1Genie
{
    /// <summary>
    /// Auteur : Claudel D. Roy
    /// Description : Programme qui simule des achats et des ventes bourisère.
    /// Date : 2023-03-15
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Actionnaire
            TransactionBoursiere Actionnaire1 = new TransactionBoursiere("Alice");
            TransactionBoursiere Actionnaire2 = new TransactionBoursiere("Béatrice");
            TransactionBoursiere Actionnaire3 = new TransactionBoursiere("Camille");

            //Changement Boursier
            PropObserver ChangementBourse = new PropObserver();
            ChangementBourse.Add(new Observateur(ChangementBourse));

            //Valeur Boursière
            SingletoncCôteBourisère ValeurBourse = SingletoncCôteBourisère.GetSingletonCote("MegaCorpo", "121212 rue Argent", 32345, 5.00d);

            //Moyenne
            SingletonMoyenneJours MoyenneBoursiereJours = SingletonMoyenneJours.GetSingletonMoyenne();

            //Profit
            SingletonProfit Profit = SingletonProfit.GetSingletonProfit();

            //Variable
            int iJours = 0;
            double dDerniereValeurDuJour = 0.00d;

            //années
            for (int i = 1; i < 11; i++)
            {
                //jours
                for (int j = 0; j < 260; j++)
                {
                    //minutes
                    for (int k = 0; k < 450; k++)
                    {
                     
                        if (k == 449)
                            dDerniereValeurDuJour = ValeurBourse.GetValue();
                        else
                            ValeurBourse.GetValue();
                    }

                    MoyenneBoursiereJours.GetDouble(dDerniereValeurDuJour);
                    iJours++;
                    ChangementBourse.MontantAction = dDerniereValeurDuJour;
                    if (iJours >= 20)
                    {     
                            ChangementBourse.CompteClient = Actionnaire1;
                            ChangementBourse.Moyenne = MoyenneBoursiereJours.ReturnAvg();

                        if (i > 1)
                        {                     
                                ChangementBourse.CompteClient = Actionnaire2;
                                ChangementBourse.Moyenne = MoyenneBoursiereJours.ReturnAvg();
                        }

                        if (i > 2)
                        {
                            ChangementBourse.CompteClient = Actionnaire3;
                                ChangementBourse.Moyenne = MoyenneBoursiereJours.ReturnAvg();
                        }
                    }

                    Console.WriteLine($"Jour : {iJours}");

                }

                Console.WriteLine($"Année : {i}");
            }

            Console.WriteLine("Après 10 ans, voici les profits et/ou perte des actionnaires.");
            Console.WriteLine("Alice : " + Profit.RetourneProfit(Actionnaire1));
            Console.WriteLine("Béatrice : " + Profit.RetourneProfit(Actionnaire2));
            Console.WriteLine("Camille : " + Profit.RetourneProfit(Actionnaire3));

            Console.WriteLine("================================================================");
            if (Profit.RetourneProfit(Actionnaire1) > Profit.RetourneProfit(Actionnaire2) && Profit.RetourneProfit(Actionnaire1) > Profit.RetourneProfit(Actionnaire3))
                Console.WriteLine("Alice est l'actionnaire qui a fait le plus de profit");
            else if (Profit.RetourneProfit(Actionnaire2) > Profit.RetourneProfit(Actionnaire1) && Profit.RetourneProfit(Actionnaire2) > Profit.RetourneProfit(Actionnaire3))
                Console.WriteLine("Béatrice est l'actionnaire qui a fait le plus de profit");
            else if (Profit.RetourneProfit(Actionnaire3) > Profit.RetourneProfit(Actionnaire1) && Profit.RetourneProfit(Actionnaire3) > Profit.RetourneProfit(Actionnaire2))
                Console.WriteLine("Camille est l'actionnaire qui a fait le plus de profit.");

            Console.WriteLine("================================================================");
        }
    }
}