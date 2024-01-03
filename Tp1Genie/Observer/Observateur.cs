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
    public class Observateur : IObservateur
    {
        //Variable
        private double _Moyenne = 0.00d;
        private double _MontantAction = 0.00d;
        private PropObserver _propriété = null;

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Constructeur
        /// </summary>
        /// <param name="prop"></param>
        public Observateur(PropObserver prop)
        {
            _propriété = prop;

        }

        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Tache realiser lorsque les propriétés a été mise a jour
        /// </summary>
        public void Update()
        {
            TransactionBoursiere a = _propriété.CompteClient;
            Console.WriteLine($"Ancienne moyenne : {_Moyenne} \nNouvelle moyenne : {_propriété.Moyenne}");
            _MontantAction = _propriété.MontantAction;
            _Moyenne = _propriété.Moyenne;


            if (_MontantAction < (_Moyenne * 0.90d))
                a.Achat(_MontantAction, _Moyenne);
            else if (_MontantAction > (_Moyenne * 0.90d))
                a.Vente(_MontantAction, _Moyenne);

        }
    }
}
