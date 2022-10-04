using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        string dni;
        string nombre;
        string apellido;
        DateTime fechaDeNacimiento;
        public Persona(string dni, string nombre, string apellido, DateTime fechaDeNacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public override string ToString()
        {
            return dni.ToString();
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
        public abstract string MostrarDatos();
    }
}
