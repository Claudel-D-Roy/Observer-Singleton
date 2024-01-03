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
    internal class SingletonMoyenneJours
    {
        //Variable
        protected static SingletonMoyenneJours _instance;
        private List<double> _moyenne = new List<double>();

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Constructeur
        /// </summary>
        protected SingletonMoyenneJours()
        {
        }


        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Retourne l'instance d'un singleton 
        /// </summary>
        /// <returns></returns>
        public static SingletonMoyenneJours GetSingletonMoyenne()
        {
            if (_instance == null)
                _instance = new SingletonMoyenneJours();
            return _instance;

        }

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Recoit un chiffre pour l'ajouter à une liste.
        /// </summary>
        /// <param name="dMoyenne"></param>
        public void GetDouble(double dMoyenne)
        {

            if(_moyenne.Count >= 20)
            {
                _moyenne.RemoveAt(0);
            }
            
            _moyenne.Add(dMoyenne);

        }

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Retourne la moyenne de la liste.
        /// </summary>
        /// <returns></returns>
        public double ReturnAvg()
        {
            return _moyenne.Average();
        }
    }
}
