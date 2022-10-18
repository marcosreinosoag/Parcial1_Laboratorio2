using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipaje
    {
        static int lastId;
        int id;
        double peso;
        double altura;
        double ancho;
        bool deMano;
        static Equipaje()
        {
            lastId = 1000;
        }
        public Equipaje(int id, double peso, double altura, double ancho, bool deMano)
        {
            lastId = id;
            this.id = id;
            lastId++;
            this.peso = peso;
            this.altura = altura;
            this.ancho = ancho;
            this.deMano = deMano;
        }
        public int Id
        {
            get { return id; }
        }
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public bool DeMano
        {
            get { return deMano; }
            set { deMano = value; }
        }
        public static int GenerarId()
        {
            return lastId;
        }
        public override string ToString()
        {
            return peso.ToString();
        }
        public override bool Equals(object obj)
        {
            Equipaje equipaje = obj as Equipaje;
            if (equipaje is not null)
            {
                return equipaje.id == this.id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (id).GetHashCode();
        }
    }
}
