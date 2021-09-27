using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin_000001.VueModeles
{
    class Page2VueModele : BaseVueModele
    {
        #region attributs
        private int _valeur1;
        private int _valeur2;
        private int _resultat;
        #endregion

        #region Constructeurs
        public Page2VueModele ()
        {
            CommandBoutonAddition = new Command(ActionCommandBoutonAddition);

        }
        #endregion

        #region Getters/Setters
        public ICommand CommandBoutonAddition { get; }
        public int Valeur1
        {
            get
            {
                return _valeur1;
            }
            set
            {
                SetProperty(ref _valeur1, value);
            }
        }
        public int Valeur2
        {
            get
            {
                return _valeur2;
            }
            set
            {
                SetProperty(ref _valeur2, value);
            }
        }
        public int Resultat
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

        #region Methodes
        public void ActionCommandBoutonAddition()
        {
            Resultat = Valeur1 + Valeur2;

        }
        #endregion
    }
}
