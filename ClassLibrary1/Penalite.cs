using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Penalite
    {
        private int idP;
        private string typeP;
        private int nombreP;


        public int IdP
        {
            get { return idP; }
            set { idP = value; }
        }

        public string TypeP
        {
            get { return typeP; }
            set { typeP = value; }
        }
        public int NombreP
        {
            get { return nombreP; }
            set { nombreP = value; }
        }


        #region Constructeur 
        public Penalite(int idP, string typeP, int nombreP)
        {
            IdP = idP;
            TypeP = typeP;
            NombreP = nombreP;
        }
        #endregion
    }
}
