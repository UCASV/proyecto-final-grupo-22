using System;
using System.Collections.Generic;

#nullable disable


    namespace Proyecto_Vacuna.model
    {
        public class SideEffect
        {
            public int id { set; get; }
            public string side { set; get; }

        public SideEffect()
        { }
        public SideEffect(int id, string side)
            {
                this.id = id;
                this.side = side;
            }
        }
    }