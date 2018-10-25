using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace QEQ.Models
{
    public class Usuario
    {
        private string _NombreUsuario;
        private string _Password;
        private bool _EsAdmin;
        private int _Monedas;

        [Required(ErrorMessage = "Campo obligatorio.")]
        public string NombreUsuario
        {
            get
            {
                return _NombreUsuario;
            }

            set
            {
                _NombreUsuario = value;
            }
        }

        [Required(ErrorMessage = "Campo obligatorio.")]
        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }

        public bool EsAdmin
        {
            get
            {
                return _EsAdmin;
            }

            set
            {
                _EsAdmin = value;
            }
        }

        public int Monedas
        {
            get
            {
                return _Monedas;
            }

            set
            {
                _Monedas = value;
            }
        }

        public Usuario ()
        {
            _NombreUsuario = NombreUsuario;
            _Password = Password;
            _EsAdmin = EsAdmin;
            _Monedas = Monedas; 
        }

        public Usuario(string Usuario, string Password)
        {
            _NombreUsuario = Usuario;
            _Password = Password;
            _EsAdmin = false;
            _Monedas = 0; 
        }
    }
}