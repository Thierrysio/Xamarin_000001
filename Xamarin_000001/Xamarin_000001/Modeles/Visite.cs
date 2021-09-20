using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_000001.Modeles
{
    class Visite
    {
        #region Attributs

        public static List<Visite> CollClasse = new List<Visite>();
        private Adherent _lAdherent;
        private DateTime _heure;
        private Tournee _laTournee;
        #endregion

        #region Constructeurs

        public Visite(DateTime heure, Adherent lAdherent)
        {
            Visite.CollClasse.Add(this);
            _heure = heure;
            _lAdherent = lAdherent;
            this.AjoutTournee();
        }


        #endregion

        #region Getters/Setters
        public DateTime Heure { get => _heure; set => _heure = value; }
        public Adherent LAdherent { get => _lAdherent; set => _lAdherent = value; }
        public Tournee LaTournee { get => _laTournee; set => _laTournee = value; }

        #endregion

        #region Methodes
        public void AjoutTournee()
        {
            bool param = false;
            if (Tournee.CollClasse.Count == 0) Tournee.CreerTournee(this.Heure);
            foreach (Tournee uneTournee in Tournee.CollClasse)
            {
                if (uneTournee.LaDate.Date == this.Heure.Date)
                {
                    //uneTournee.LesVisites.Add(this);
                    uneTournee.AjoutVisite(this);
                    break;
                }
                else
                {
                    param = true;
                }
            }

            if (param == true) Tournee.CreerTourneeGestionVisite(this.Heure, this);
        }
        #endregion
    }
}

