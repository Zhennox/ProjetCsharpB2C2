using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Equipage 
    {
        private int idEq;
        private int nombreEq;
        private string nomEq;
        private List<Personne> Equipages = new List<Personne>();
        

        public int IdEq
        {
            get { return idEq; }
            set { idEq = value; }
        }

        public int NombreEq
        {
            get { return nombreEq; }
            set { nombreEq = value; }
        }

        public string NomEq
        {
            get { return nomEq; }
            set { nomEq = value; }
        }

        #region Constructeur 
        public Equipage(int idEq, int nombreEq, string nomEq)
        {
            IdEq = idEq;
            NombreEq = nombreEq;
            NomEq = nomEq;
        }
        #endregion
    }
}
