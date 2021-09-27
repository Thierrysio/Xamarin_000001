using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_000001.Modeles;

namespace Xamarin_000001.VueModeles
{
    class TourneeVueModele : BaseVueModele
    {
        #region Attributs
        Adherent _adherent1;
        Visite _visite1;
    
        #endregion

        #region Constructeurs

        public TourneeVueModele()
        {
            CommandBoutonPage2 = new Command(ActionCommandBoutonPage2);
            _adherent1 = new Adherent(1, "nom1", "prenom1", "adresse1", 50);
            Visite1 = new Visite(DateTime.Now, _adherent1);
        }

        #endregion

        #region Getters/Setters

        public ICommand CommandBoutonPage2 { get; }
        public Visite Visite1
        {
            get
            {
                return _visite1;
            }
            set
            {
                SetProperty(ref _visite1, value);
            }
        }
        #endregion

        #region Methodes
        public void ActionCommandBoutonPage2()
        {
            Application.Current.MainPage = new NavigationPage(new Page2Vue());
        }
        #endregion
    }
}
