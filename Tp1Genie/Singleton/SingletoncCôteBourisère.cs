using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bourse.Singleton
{  /// <summary>
   /// Auteur : Claudel D. Roy
   /// Description : Implantation d'un pattern singleton 
   /// Date : 2023-03-15
   /// </summary>
    public class SingletoncCôteBourisère
    {
        //Variable
        private static SingletoncCôteBourisère _instance;
        private Random _rando = new Random();

        //Propriété
        public string NomCompagnie { get; }
        public string Adresse { get; }
        public int Code { get; }
        public double Valeur { get; set; }

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Constructeur
        /// </summary>
        protected SingletoncCôteBourisère(string sNomComp, string sAdresse, int iCode, double iValeur)
        {
            NomCompagnie = sNomComp;
            Adresse = sAdresse;
            Code = iCode;
            Valeur = iValeur;
        }

    /// <summary>
    /// Auteur : Claudel D. Roy
    /// Description : Retourne l'instance du Singleton
    /// </summary>

        public static SingletoncCôteBourisère GetSingletonCote(string sNomComp, string sAdresse, int iCode, double iValeur)
        {
            if (_instance == null)
            {
                _instance = new SingletoncCôteBourisère(sNomComp, sAdresse, iCode, iValeur);
            }
            return _instance;

        }

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description :Retourne les valeurs de l'augmentation ou la diminution de l'action
        /// </summary>
        public double GetValue()
        {
            double dMax = 0.05d;
            double dMin = -0.05d;

            double dModification =  _rando.NextDouble() <= 0.5 ? dMax : dMin;  
            Valeur = Valeur + dModification;
            if (Valeur <= 0.00d)
                Valeur = 0.01d;

            return Math.Round(Valeur, 2);
        }
    }
}
