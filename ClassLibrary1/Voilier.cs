using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class Voilier
    {
        private int idV;
        private string nomV;
        private string marqueV;
        private string immatriculationV;

        public int IdV
        {
            get { return idV; }
            set { idV = value; }
        }

        public string NomV
        {
            get { return nomV; }
            set { nomV = value; }
        }

        public string MarqueV
        {
            get { return marqueV; }
            set { marqueV = value; }
        }

        public string ImmatriculationV
        {
            get { return immatriculationV; }
            set { immatriculationV = value; }
        }


        #region Constructeurs
        public Voilier(int idV, string nomV, string marqueV, string immatriculationV)
        {
            IdV = idV;
            NomV = nomV;
            MarqueV = marqueV;
            ImmatriculationV = immatriculationV;
        }
        #endregion

    }
}
