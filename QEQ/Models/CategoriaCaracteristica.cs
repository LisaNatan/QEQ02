using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace QEQ.Models
{
    public class CategoriaCaracteristica
    {
       
        private int _ID;
        private string _Nombre;

        [Required(ErrorMessage = "Campo obligatorio.")]
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        [Required(ErrorMessage = "Campo obligatorio.")]
        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public CategoriaCaracteristica()
        {
            _ID = ID;
            _Nombre = Nombre;
        }

        public CategoriaCaracteristica(int ID, string Nombre)
        {
            _ID = ID;
            _Nombre = Nombre;
        }
    }
}