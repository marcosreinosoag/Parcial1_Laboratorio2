using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero
    {
        string dni;
        string nombre;
        string apellido;
        DateTime fechaDeNacimiento;
        int edad;
        int viajesRelizados;
        public Pasajero(string nombre, string apellido, string dni, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.edad = DateTime.Now.Year - fechaDeNacimiento.Year;
        }
        public string Dni
        {
            get { return this.dni; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return apellido; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
        }
        public int Edad
        {
            get { return edad; }
        }
        public int ViajesRealizados
        {
            get { return viajesRelizados; }
        }
    }
}
