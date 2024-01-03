using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bourse.Observer
{   /// <summary>
    /// Auteur : Claudel D. Roy
    /// Description : Implantation d'un pattern observer
    /// Date : 2023-03-15
    /// </summary>
    public abstract class GestionProp
    {
        //Variable
        private List<IObservateur> _listObservateurs = new List<IObservateur>();
        private double _moyenne = 0.00d;

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Permet d'ajouter des Observateur a la liste
        /// </summary>
        /// <param name="o"></param>
        public void Add(IObservateur o)
        {
            _listObservateurs.Add(o);
        }
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Permet de notifier tout les observateurs inscrit du changement
        /// </summary>
        public void Notifier()
        {
            foreach (IObservateur o in _listObservateurs)
            {
                o.Update();
            }
        }


    }
}
