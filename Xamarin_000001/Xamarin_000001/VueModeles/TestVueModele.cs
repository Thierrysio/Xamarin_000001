using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_000001.Modeles;

namespace Xamarin_000001.VueModeles
{
    class TestVueModele : BaseVueModele
    {
        #region Attributs
        private Adherent _adherent1;
        #endregion
        #region Constructeurs
        public TestVueModele()
        {
            _adherent1 = new Adherent(1, "nom1", "prenom1", "adresse1");
        }
        #endregion
        #region Getters/Setters
        public Adherent Adherent1
        {
            get
            {
                return _adherent1;
            }
            set
            {
                SetProperty(ref _adherent1, value);
            }
        }
        #endregion
        #region methodes
        #endregion
    }
}
