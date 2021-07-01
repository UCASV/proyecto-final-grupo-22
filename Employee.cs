using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_Vacuna.model
{
    public class Employee
    {
       public int id { set; get; }
        public string name { set; get; }
        public string email { set; get; }
        public string adress { set; get; }

        public string user { set; get; }
        public string password { set; get; }
        public virtual TipoEmployee Tipo { set; get; }

        

        public Employee()
        {
        
        }

        public Employee(string name, string email, string adress, string user1, string pass, TipoEmployee tipo)
        {
            this.name = name;
            this.email = email;
            this.adress = adress;
            this.user = user1;
            this.password = pass;
            this.Tipo = tipo;
          
        }

       
    }
}
