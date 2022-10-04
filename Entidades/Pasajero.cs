using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : Persona
    {
        int edad;
        int viajesRelizados;
        int asientoAsignado;
        public Pasajero(string nombre, string apellido, string dni, DateTime fechaDeNacimiento, int asientoAsignado, int viajesRelizados) : base(dni, nombre, apellido, fechaDeNacimiento)
        {
            this.edad = DateTime.Now.Year - fechaDeNacimiento.Year;
            this.asientoAsignado = asientoAsignado;
            this.viajesRelizados = viajesRelizados;
        }
        public override string ToString()
        {
            return $"{this.Nombre} \n {this.Apellido} \n {this. edad.ToString()}";
        }
        public int Edad
        {
            get { return edad; }
        }
        public int ViajesRealizados
        {
            get { return viajesRelizados; }
            set { this.viajesRelizados += value; }
        }
        public override string MostrarDatos()
        {
            return this.ToString();
        }
        public int AsientoAsignado
        {
            get
            {
                return this.asientoAsignado;
            }
            set
            {
                this.asientoAsignado = value;
            }
        }
        public override bool Equals(object obj)
        {
            Pasajero pasajero = obj as Pasajero;
            if (pasajero is not null)
            {
                return pasajero.Dni == this.Dni;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (Dni).GetHashCode();
        }
    }
}

