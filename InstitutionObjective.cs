using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacuna.model
{
    public class InstitutionObjective
    {
        public int id { set; get; }
        public string Institution { set; get; }
        
        public InstitutionObjective ()
        { }
        public InstitutionObjective(int id, string institution)
        {
            this.id = id;
            this.Institution = institution;
        }

    }
}
