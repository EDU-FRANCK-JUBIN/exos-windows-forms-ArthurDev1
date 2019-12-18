using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.DataBinding
{
    class Personne
    {
        private String nom;
        private String prenom;
        private DateTime dNaisance;
        private int age;

        public Personne(string nom, string prenom, DateTime dnaissance, int age)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.dNaisance = dnaissance;
            this.Age = age;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DNaissance { get => dNaisance; set => dNaisance = value; }
        public int Age { get => age; set => age = value; }
    }
}
