using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_id;
        private string usu_nombreUsuario;
        private string usu_contrasenia;
        private string usu_apellidoNombre;
        protected string rol_codigo;

        public Usuario(String usu_nombreUsuario, String usu_contrasenia) {
            this.usu_nombreUsuario = usu_nombreUsuario;
            this.usu_contrasenia = usu_contrasenia;
        }

        public int Usu_id
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Usu_nombreUsuario
        {
            get { 
                return usu_nombreUsuario;
            }
            set { 
                usu_nombreUsuario = value; 
            }
        }

        public string Usu_contrasenia
        {
            get
            {
                return usu_contrasenia;
            }
            set
            {
                usu_contrasenia = value;
            }
        }

        public string Usu_apellidoNombre
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Rol_codigo
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
