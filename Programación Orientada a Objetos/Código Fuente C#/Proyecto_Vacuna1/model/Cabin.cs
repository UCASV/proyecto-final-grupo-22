using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacuna.model
{
    public class Cabin
    {
        public int Id { set; get; }
        public virtual Index_cabin index_cabin_1 { set; get; }

        public string adress { set; get; }

        public string phone { set; get; }

        public string email { set; get; }

        public DateTime dateTime { set; get; }

        public virtual Employee employee { set; get; }

        public Cabin()
        { }
        public Cabin(Index_cabin index_Cabin, string adress, string phone, string email, DateTime dateTime, Employee employee)
        {
            this.index_cabin_1 = index_Cabin;
            this.adress = adress;
            this.phone = phone;
            this.email = email;
            this.dateTime = dateTime;
            this.employee = employee;
        }
    }
}
