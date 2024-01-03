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
    public interface IObservateur
    {
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Méthode qui s'occupe de la mise à jour des informations.
        /// </summary>
        void Update();
    }
}
