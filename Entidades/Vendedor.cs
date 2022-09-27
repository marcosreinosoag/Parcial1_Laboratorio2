using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        string usuario;
        string clave;
        string nombre;
        string apellido;

        public Vendedor(string usuario, string clave, string nombre, string apellido)
        {
            this.usuario = usuario;
            this.clave = clave;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string Usuario
        {
            get { return this.usuario; }
        }
        public string Nombre
        {
            get { return this.nombre; }
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

    }
}
