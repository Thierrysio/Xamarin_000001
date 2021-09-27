using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin_000001.Modeles;

namespace Xamarin_000001.VueModeles
{
    class Page3VueModele : BaseVueModele
    {
        #region Attributs

        private ObservableCollection<Adherent> _listeAdherents;
        
        #endregion

        #region Constructeurs

        public Page3VueModele()
        {
            new Adherent(1, "nom 1", "prenom 1", "Adresse 1", 1);
            new Adherent(2, "nom 1", "prenom 1", "Adresse 1", 1);
            new Adherent(3, "nom 1", "prenom 1", "Adresse 1", 1);
            new Adherent(4, "nom 1", "prenom 1", "Adresse 1", 1);
            new Adherent(5, "nom 1", "prenom 1", "Adresse 1", 1);
            new Adherent(6, "nom 1", "prenom 1", "Adresse 1", 1);
            new Adherent(7, "nom 1", "prenom 1", "Adresse 1", 1);
            new Adherent(8, "nom 1", "prenom 1", "Adresse 1", 1);
            new Adherent(9, "nom 1", "prenom 1", "Adresse 1", 1);
            new Adherent(10, "nom 1", "prenom 1", "Adresse 1", 1);

            ListeAdherents = Adherent.GetListAll();

        }

        #endregion

        #region Getters/Setters
        public ObservableCollection<Adherent> ListeAdherents
        {
            get
            {
                return _listeAdherents;
            }
            set
            {
                SetProperty(ref _listeAdherents, value);
            }
        }

        #endregion

        #region Methodes

        #endregion
    }
}
