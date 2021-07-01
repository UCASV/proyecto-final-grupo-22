using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacuna.model
{
    public class Dosi
    {
        public int id { set; get; }
        public string dosis { set; get; }
        
        public Dosi ()
        { }
        public Dosi(int id,string dosis)
        {
            this.id = id;
            this.dosis = dosis;
        }

       
    }
}
