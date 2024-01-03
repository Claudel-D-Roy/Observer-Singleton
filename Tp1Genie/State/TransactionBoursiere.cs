using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bourse.State {
    /// <summary>
    /// Auteur : Claudel D. Roy
    /// Description : Implantation d'un pattern State
    /// Date : 2023-03-15
    /// </summary>
    public class TransactionBoursiere
    {
        //Variable
        private string _nomPropriétaire;
        //Propriété
        public double Profit { get; set; }
        public ProfilABS Transaction { get; set; }

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Constructeur
        /// </summary>
        public TransactionBoursiere(string nomPropriétaire)
        {
            _nomPropriétaire = nomPropriétaire;
            Transaction = new ProfilPetitBudget(12000.00d, this);

        }
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Méthode qui s'occupe d'afficher le résultat de l'achat
        /// </summary>
        public string Achat(double dMontant, double dMoyenneMob)
        {
            string sResultat = Transaction.Achat(dMontant, dMoyenneMob);
            
            sResultat += "\t\n" + "Nom de l'actionnaire: "+ _nomPropriétaire + "\nType de compte: " + Transaction.GetType().Name;
            Console.WriteLine(sResultat);
            Console.WriteLine("==========================================================================");
            return sResultat;

        }
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Méthode qui s'occupe d'afficher le résultat de la vente
        /// </summary>
        public string Vente(double dMontant, double dMoyenneMob)
        {
            string sResultat = Transaction.Vente(dMontant, dMoyenneMob);
           
            sResultat += "\t\n" + "Nom de l'actionnaire: " + _nomPropriétaire + "\nType de compte: " + Transaction.GetType().Name;
            Console.WriteLine(sResultat);
            Console.WriteLine("==========================================================================");
            return sResultat;
        }

    }
}
