using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class VoilierInscrit : Voilier
    {
        private int nombreVI;
        private string nomVI;
        private string immatriculationVI;


        public int NombreVI
        {
            get { return nombreVI; }
            set { nombreVI = value; }
        }

        public string NomVI
        {
            get { return nomVI; }
            set { nomVI = value; }
        }

        public string ImmatriculationVI
        {
            get { return immatriculationVI; }
            set { immatriculationVI = value; }
        }


        #region Constructeurs
        public VoilierInscrit(int nombreVI, string nomVI, string immatriculationVI)
        {
            NombreVI = nombreVI;
            NomVI = nomVI;
            ImmatriculationVI = immatriculationVI;
        }
        #endregion
    }
}
