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
        private string _resultat;
        #endregion
        #region Constructeurs
        public TestVueModele()
        {
            _adherent1 = new Adherent(1, "enfaillite", "melusine", "adresse1");
            Resultat = Adherent1.GetConcat();
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
        public string Resultat
        {
            get
            {
                return _resultat;
            }
            set
            {
                SetProperty(ref _resultat, value);
            }
        }
        #endregion
        #region methodes
        #endregion
    }
}
