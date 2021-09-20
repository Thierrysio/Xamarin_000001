using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_000001.Modeles;

namespace Xamarin_000001.VueModeles
{
    class VisiteVueModele : BaseVueModele
    {
        #region Attributs
        Visite _uneVisite;
        Adherent _unAdherent;

        #endregion

        #region Constructeurs

        public VisiteVueModele()
        {
            UnAdherent = new Adherent(1, "nom1", "prenom1", "adresse1",50);
            UneVisite = new Visite(DateTime.Now, UnAdherent);
        }

        #endregion

        #region Getters/Setters
        public Adherent UnAdherent
        {
            get
            {
                return _unAdherent;
            }
            set
            {
                SetProperty(ref _unAdherent, value);
            }
        }
        public Visite UneVisite
        {
            get
            {
                return _uneVisite;
            }
            set
            {
                SetProperty(ref _uneVisite, value);
            }
        }
        #endregion

        #region Methodes

        #endregion
    }
}
