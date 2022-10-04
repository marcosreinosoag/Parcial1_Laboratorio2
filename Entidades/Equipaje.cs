using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipaje
    {
        string color;
        double peso;
        double altura;
        double ancho;
        bool deMano;
        string descripcion;

        public Equipaje(string color, double peso, double altura, double ancho, bool deMano, string descripcion)
        {
            this.Color = color;
            this.Peso = peso;
            this.Altura = altura;
            this.Ancho = ancho;
            this.DeMano = deMano;
            this.Descripcion = descripcion;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }
        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public bool DeMano
        {
            get
            {
                return deMano;
            }
            set
            {
                deMano = value;
            }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public override string ToString()
        {
            return descripcion.ToString();
        }
        public override bool Equals(object obj)
        {
            Equipaje equipaje = obj as Equipaje;
            if (equipaje is not null)
            {
                return equipaje.descripcion == this.descripcion;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (descripcion).GetHashCode();
        }
    }
}
