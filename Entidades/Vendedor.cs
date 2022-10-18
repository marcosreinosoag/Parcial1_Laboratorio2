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
        int cantidadDePasajesVendidos;

        public Vendedor(string dni, string clave, string nombre, string apellido, DateTime fechaNacimiento,int pasajesVendidos) : base(dni, nombre, apellido, fechaNacimiento)
        {
            this.usuario = dni;
            this.clave = clave;
            this.cantidadDePasajesVendidos = pasajesVendidos;
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
        public int CantidadDePasajesVendidos
        {
            get { return cantidadDePasajesVendidos; }
            set { this.cantidadDePasajesVendidos += value; }
        }
        public override string MostrarDatos()
        {
            string datos = $" El vendedor {this.Nombre} {this.Apellido} tiene {this.CantidadDePasajesVendidos} pasajes vendidos.";
            return datos;
        }
        public override string ToString()
        {
            int edad = DateTime.Now.Year - FechaDeNacimiento.Year;
            return $"{this.Nombre} \n {this.Apellido} \n {edad.ToString()}";
        }
        public override bool Equals(object obj)
        {
            Vendedor vendedor = obj as Vendedor;
            if (vendedor is not null)
            {
                return vendedor.usuario == this.usuario;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (usuario, clave).GetHashCode();
        }
    }
}
