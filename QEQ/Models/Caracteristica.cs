using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QEQ.Models
{
    public class Caracteristica
    {
        private int _ID;
        private string _Nombre;
        private int _IDCategoria;
        private string _Pregunta;

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

        [Required(ErrorMessage = "Campo obligatorio.")]
        public int IDCategoria
        {
            get
            {
                return _IDCategoria;
            }

            set
            {
                _IDCategoria = value;
            }
        }

        [Required(ErrorMessage = "Campo obligatorio.")]
        public string Pregunta
        {
            get
            {
                return _Pregunta;
            }

            set
            {
                _Pregunta = value;
            }
        }

        public Caracteristica()
        {
            _ID = ID;
            _Nombre = Nombre;
            _IDCategoria = IDCategoria;
            _Pregunta = Pregunta;
        }

        public Caracteristica(int ID, string Nombre, int IDCategoria, string Pregunta)
        {
            _ID = ID;
            _Nombre = Nombre;
            _IDCategoria = IDCategoria;
            _Pregunta = Pregunta;
        }
    }
}
