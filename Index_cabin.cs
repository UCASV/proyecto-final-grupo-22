using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Vacuna.model
{
    public class Index_cabin
    {
        public int id { set; get; }
        public string index { set; get; }

        public Index_cabin ()
        { }
        public Index_cabin(int id, string index )
        {
            this.id = id;
            this.index = index; 
        }
    }
}
