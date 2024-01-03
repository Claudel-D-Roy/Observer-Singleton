using Bourse.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bourse.Observer
{ /// <summary>
  /// Auteur : Claudel D. Roy
  /// Description : Implantation d'un pattern observer
  /// Date : 2023-03-15
  /// </summary>
    public class PropObserver : GestionProp
    {

        //Variables 
        private double _moyenne = 0.00d;
        private double _montantAction = 0.00d;
        private TransactionBoursiere _compte;

        //Propriété
        public TransactionBoursiere CompteClient { 
            get { return _compte; }
            set
            {
                _compte = value;           
            }
        }
        public double MontantAction
        {
            get { return _montantAction; }
            set
            {
                _montantAction = value;
                
            }
        }
        public double Moyenne
        {
            get { return _moyenne; }
            set
            {
                _moyenne = value;
                Notifier();
            }
        }

    }
}
