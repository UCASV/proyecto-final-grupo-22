using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacuna.model
{
    public class DayVaccine
    {
        public int id { set; get; }
        public virtual Pacient Pacient { set; get; }

        public virtual Index_cabin Cabin { set; get; }

        public virtual SideEffect Side { set; get; }
        public virtual TypeVaccine TypeVaccine { set; get; }
        public virtual Dosi Dosis { set; get; }

        public DayVaccine ()

        { }
        public DayVaccine(Pacient pacient, Index_cabin cabin, SideEffect side, TypeVaccine type, Dosi dosis)
        {
            this.Pacient = pacient;
            this.Cabin = cabin;
            this.Side = side;
            this.TypeVaccine = type;
            this.Dosis = dosis;
        }
    }
}