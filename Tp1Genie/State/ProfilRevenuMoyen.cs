using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bourse.State
{/// <summary>
 /// Auteur : Claudel D. Roy
 /// Description : Implantation d'un pattern State
 /// Date : 2023-03-15
 /// </summary>
    public class ProfilRevenuMoyen : ProfilABS
    {
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : constructeur
        /// </summary>
        public ProfilRevenuMoyen(double dBalance, TransactionBoursiere compte)
        {
            _balance = dBalance;
            _compte = compte;
            Initialiser();
        }
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Initiation du profil
        /// </summary>
        private void Initialiser()
        {
            _commission = 10.00d;
            _limiteSupBalance = 1000000.00d;
            _limiteInfBalance = 500000.00d;



        }
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Change l'état du profil
        /// <returns></returns>
        public override ProfilABS ChangementEtat()
        {
            if (_balance >= _limiteSupBalance)
                return new ProfilBillGates(_balance, _compte);
            else if (_balance < _limiteInfBalance)
                return new ProfilPetitBudget(_balance, _compte);
            else
                return this;
        }
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Méthode qui s'occupe de l'achat du profil
        /// </summary>
        public override string Achat(double dMontant, double dMoyenneMob)
        {
            double dAchat = 0.00d;
            double dNbrAchat = 0.00d;

      

                if (dMontant < dMoyenneMob * 0.95d)
                {
                    dAchat = _balance * 0.75d;
                    dNbrAchat = dAchat / dMontant;
                    _NombreAchat += dNbrAchat;
                    _MontantAchat += dMontant * dNbrAchat;
                    _balance -= (dMontant * dNbrAchat) - _commission;
                    Console.WriteLine("ok Moyen");
                    _compte.Transaction = ChangementEtat();

                    return _balance.ToString();

                }
                else
                    return _balance.ToString();
            
        }
        /// <summary>
        /// Auteur : Claudel D. Roy
        /// Description : Méthode qui s'occupe de la vente du profil
        /// </summary>
        /// <returns></returns>
        public override string Vente(double dMontant, double dMoyenneMob)
        {
        
                if (_NombreAchat == 0)
                    return _balance.ToString();
                else
                {
                    if (dMontant > dMoyenneMob * 0.95d)
                    {
                        _balance += (dMontant * _NombreAchat) + _commission;
                        _MontantVente += dMontant * _NombreAchat;
                        _compte.Profit = _MontantVente - _MontantAchat;
                        _NombreAchat = 0;
                        Console.WriteLine("Merci! Moyen");
                        _compte.Transaction = ChangementEtat();
                      
                        return _balance.ToString();
                    }
                    return _balance.ToString();
                }
            
        }
    }
}
