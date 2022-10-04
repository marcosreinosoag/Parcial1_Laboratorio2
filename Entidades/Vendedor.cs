using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Persona
    {
        string usuario;
        string clave;

        public Vendedor(string dni, string clave, string nombre, string apellido, DateTime fechaNacimiento) : base(dni, nombre, apellido, fechaNacimiento)
        {
            this.usuario = dni;
            this.clave = clave;
        }
        public string Usuario
        {
            get { return this.usuario; }
        }
        public bool VerificarClave(string clave)
        {
            bool retorno = false;
            if (clave == this.clave)
            {
                retorno = true;
            }
            return retorno;
        }
        public override string MostrarDatos()
        {
            return "hola2";
        }
        public override string ToString()
        {
            return usuario.ToString();
        }
    }
}
