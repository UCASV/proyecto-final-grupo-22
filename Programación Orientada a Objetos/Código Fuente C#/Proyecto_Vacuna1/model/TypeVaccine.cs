using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacuna.model
{
    public class TypeVaccine
    {
        public int id { set; get; }
        public string type_Vaccine { set; get; }

        public TypeVaccine()
        { }
        public TypeVaccine(int id, string type_Vaccine)
        {
            this.id = id;
            this.type_Vaccine = type_Vaccine;
        }
    }
}
