using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QEQ.Models
{
    public class CategoriaPersonaje
    {
        private int _ID;
        private string _Nombre;

        public CategoriaPersonaje(int ID, string Nombre)
        {
            this.ID = ID;
            this.Nombre = Nombre;
        }

        public CategoriaPersonaje()
        {
            this.ID = ID;
            this.Nombre = "";
        }

        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}