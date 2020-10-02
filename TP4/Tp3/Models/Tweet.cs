using System;
using System.Collections.Generic;
using System.Text;

namespace Tp4.Models
{
    public class Tweet
    {
        public string identifiant;
        public string dateDeCreation;
        public string texte;
        public string nomDeLUtilisateur;
        public string identifiantDeLUtilisateur;
        public string pseudoDeLUtilisateur;



        public string Identifiant { get => identifiant; set => identifiant = value; }
        public string DateDeCreation { get => dateDeCreation; set => dateDeCreation = value; }
        public string Texte { get => texte; set => texte = value; }
        public string NomDeLUtilisateur { get => nomDeLUtilisateur; set => nomDeLUtilisateur = value; }
        public string IdentifiantDeLUtilisateur { get => identifiantDeLUtilisateur; set => identifiantDeLUtilisateur = value; }
        public string PseudoDeLUtilisateur { get => pseudoDeLUtilisateur; set => pseudoDeLUtilisateur = value; }

        public Tweet(string identifiant, string dateDeCreation, string texte, string nomDeLUtilisateur, string identifiantDeLUtilisateur, string pseudoDeLUtilisateur)
        {
            this.identifiant = identifiant;
            this.dateDeCreation = dateDeCreation;
            this.texte = texte;
            this.nomDeLUtilisateur = nomDeLUtilisateur;
            this.identifiantDeLUtilisateur = identifiantDeLUtilisateur;
            this.pseudoDeLUtilisateur = pseudoDeLUtilisateur;
        }

        public Tweet()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
