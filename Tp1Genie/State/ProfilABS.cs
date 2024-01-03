using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bourse.State
{/// <summary>
 /// Auteur : Claudel D. Roy
 /// Description : Implantation d'un pattern State
 /// Date : 2023-03-15
 /// </summary>
    public abstract class ProfilABS
    {
        //Variable
        protected TransactionBoursiere _compte;
        protected double _balance;
        protected double _commission;
        protected double _limiteSupBalance;
        protected double _limiteInfBalance;
        protected double _NombreAchat;
        protected double _MontantAchat;
        protected double _MontantVente;


        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Méthode qui s'occupe de l'achat
        /// </summary>
        /// <param name="dMontant"></param>
        /// <param name="dMoyenneMob"></param>
        /// <returns></returns>
        public abstract string Achat(double dMontant, double dMoyenneMob);
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Méthode qui s'occupe de la vente
        /// </summary>
        /// <returns></returns>
        public abstract string Vente(double dMontant, double dMoyenneMob);
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Méthode qui s'occupe des changement d'état des profils
        /// </summary>
        /// <returns></returns>
        public abstract ProfilABS ChangementEtat();
    }
}
