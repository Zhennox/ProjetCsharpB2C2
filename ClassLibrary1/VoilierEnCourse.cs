using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class VoilierEnCourse : VoilierInscrit
    {
        private int nombreVEC;
        private string nomVEC;
        private string immatriculationVEC;


        public int NombreVEC
        {
            get { return nombreVEC; }
            set { nombreVEC = value; }
        }

        public string NomVEC
        {
            get { return nomVEC; }
            set { nomVEC = value; }
        }

        public string ImmatriculationVEC
        {
            get { return immatriculationVEC; }
            set { immatriculationVEC = value; }
        }


        #region Constructeurs
        public VoilierEnCourse(int nombreVEC, string nomVEC, string immatriculationVEC)
        {
            NombreVEC = nombreVEC;
            NomVEC = nomVEC;
            ImmatriculationVEC = immatriculationVEC;
        }
        #endregion
    }
}
