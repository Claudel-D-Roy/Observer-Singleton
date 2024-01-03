using Bourse.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bourse.Singleton
{
    /// <summary>
    /// Auteur : Claudel D. Roy
    /// Description : Implantation d'un pattern singleton 
    /// Date : 2023-03-15
    /// </summary>
    public class SingletonProfit
    {

        //Variable
        private static SingletonProfit _instance;
        private double _profit;

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Constructeur
        /// </summary>
        protected SingletonProfit() { }

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Retourne l'instance du singleton
        /// </summary>
        /// <returns></returns>
        public static SingletonProfit GetSingletonProfit()
        {
            if( _instance == null ) 
                _instance = new SingletonProfit();
            return _instance;

        }
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Retourne le profit de l'actionnaire.
        /// </summary>
        /// <param name="_compte"></param>
        /// <returns></returns>
        public double RetourneProfit(TransactionBoursiere _compte)
        {
            _profit = _compte.Profit;
            return Math.Round(_profit,2); 
        }



    }
}
