using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacuna.model
{
    public class Disease
    {
       public int id { set; get; }
        public string disease { set; get; }
        
        public Disease ()
        { }
        public Disease(int id,string disease )
        {
            this.id = id;
            this.disease = disease;
        }

      

        
    }
}
