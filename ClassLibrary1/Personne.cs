using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Personne
    {
        private int idPe;
        private string nomPe;
        private string prenomPe;
        private string adressePe;
        private int telephonePe;
        private string nomEquipePe;
        private string roleEquipePe;


        public int IdPe
        {
            get { return idPe; }
            set { value = idPe; }
        }

        public string NomPe
        {
            get { return nomPe; }
            set { value = nomPe; }
        }

        public string PrenomPe
        {
            get { return prenomPe; }
            set { value = prenomPe; }
        }

        public string AdressePe
        {
            get { return adressePe; }
            set { value = adressePe; }
        }

        public int TelephonePe
        {
            get { return telephonePe; }
            set { value = telephonePe; }
        }

        public string NomEquipePe
        {
            get { return nomEquipePe; }
            set { value = nomEquipePe; }
        }

        public string RoleEquipePe
        {
            get { return roleEquipePe; }
            set { value = roleEquipePe; }
        }


        public Personne(int idPe, string nomPe, string prenomPe, string adressePe, int telephonePe, string nomEquipePe, string roleEquipePe)
        {
            IdPe = idPe;
            NomPe = nomPe;
            PrenomPe = prenomPe;
            AdressePe = adressePe;
            TelephonePe = telephonePe;
            NomEquipePe = nomEquipePe;
            RoleEquipePe = roleEquipePe;
        }
    }
}
