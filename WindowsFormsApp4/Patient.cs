using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    [Serializable]

    public class Patient
    {
        private string cin;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private int poid;
        private int longueur;
        private string adresse;
        private string tel;

        public Patient(string cin,string nom, string prenom, DateTime dateNaissance, int poid, int longueur, string adresse, string tel)
        {
            this.Cin = cin;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.Poid = poid;
            this.Longueur = longueur;
            this.Adresse = adresse;
            this.Tel = tel;
            
            
        }

        public string Cin
        {
            get
            {
                return cin;
            }
            set
            {
                if (value.Length < 5) throw new Exception("Cin incorrect");
                cin = value.ToUpper();
            }
        }
        public string Nom { 
            get
            {
                return nom;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.All(char.IsDigit)) throw new Exception("Nom invalide");
                nom = value;
            }
        }
        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.All(char.IsDigit)) throw new Exception("Prenom invalide");
                prenom = value;
            }
        }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public int Poid { get => poid; set => poid = value; }
        public int Longueur { get => longueur; set => longueur = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Tel {
            get
            {
                return tel;
            }
            set
            {
                if (value.Length != 10) throw new Exception("Numéro de téléphone invalide");
                tel = value;
            } 

        }
    }
}
