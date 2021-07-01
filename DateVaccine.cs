using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace Proyecto_Vacuna.model
{
    public class DateVaccine
    {
        public int id { set; get; }
        public string name { set; get; }
        public virtual Index_cabin Cabin1 { set; get; }
        
        public virtual Pacient Pacient { set; get; }

        
        public DateTime date { set; get; }
        public virtual TypeVaccine Type { set; get; }
        public virtual Dosi dosis { set; get; }

        public DateVaccine()
        { }

        public DateVaccine(Index_cabin cabin, Pacient pacient, DateTime date, TypeVaccine type, Dosi dosis, string name)
        {
            this.Cabin1 = cabin;
            this.Pacient = pacient;
            this.date = date;
            this.Type = type;
            this.dosis = dosis;
            this.name = name;

        }

       

    }
}