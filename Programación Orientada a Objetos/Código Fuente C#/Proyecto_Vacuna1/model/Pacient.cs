using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacuna.model
{
    public class Pacient
    {
        public int id { set; get; }
        public string DUI { set; get; }
        public string name { set; get; }
        public string adress { set; get; }
        public string phone { set; get; }
        public string email { set; get; }
        public virtual Disease Disease { set; get; }
        public virtual InstitutionObjective Institution { set; get; }


        public Pacient()
        {

        }
        public Pacient (string DUI, string name, string adress, string phone, string email, Disease disease, InstitutionObjective institutionObjective)
        {
            this.DUI = DUI;
            this.name = name;
            this.adress = adress;
            this.phone = phone;
            this.email = email;
            this.Disease = disease;
            this.Institution = Institution;


        }
    }
}
