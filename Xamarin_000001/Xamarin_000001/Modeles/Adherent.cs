﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_000001.Modeles
{
    class Adherent
    {
        #region Attributs
        public static List<Adherent> CollClasse = new List<Adherent>();

        private int _id;
        private string _nom;
        private string _prenom;
        private string _adresse;

        #endregion
        #region Constructeurs
        public Adherent(int id, string nom, string prenom, string adresse)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _adresse = adresse;
            Adherent.CollClasse.Add(this);
        }
        #endregion
        #region Getters/Setters
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }

        #endregion
        #region Methodes
        public string GetConcat()
        {
            return this.Nom + " " + this.Prenom;
        }
        #endregion
    }
}
