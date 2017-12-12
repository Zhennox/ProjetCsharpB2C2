using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Entreprise
    {
        private int idE;
        private string nomE;
        private string adresseE;
        private int telephoneE;


        public int IdE
        {
            get { return idE; }
            set { idE = value; }
        }

        public string NomE
        {
            get { return nomE; }
            set { nomE = value; }
        }

        public string AdresseE
        {
            get { return adresseE; }
            set { adresseE = value; }
        }

        public int TelephoneE
        {
            get { return telephoneE; }
            set { telephoneE = value; }
        }


        #region Constructeur 
        public Entreprise( int idE, string nomE, string adresseE, int telephoneE)
        {
            IdE = idE;
            NomE = nomE;
            AdresseE = adresseE;
            TelephoneE = telephoneE;
        }
        #endregion
    }
}
