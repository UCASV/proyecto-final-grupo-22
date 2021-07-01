using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacuna.model
{
    public class TipoEmployee
    {
        public int Id { set; get; }
        public string type { set; get; }
        
        public TipoEmployee()
        { }
        public TipoEmployee (int id, string type)
        {
            this.Id = id;
            this.type = type;
        }
    }



}