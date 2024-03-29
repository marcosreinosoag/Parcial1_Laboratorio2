﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ELugar
    {
        BuenosAires,
        SantaRosa,
        Bariloche,
        Corrientes,
        Cordoba,
        Jujuy,
        Mendoza,
        Neuquen,
        Posadas,
        Iguazu,
        Salta,
        SantiagoDelEstero,
        Trelew,
        Tucuman,
        PuertoMadryn,
        Ushuaia,
        Recife,
        Roma,
        Acapulco,
        Miami,
    }
    public class Vuelo
    {
        static int lastId;
        int id;
        Aereonave avionAsignado;
        double duracionDelVuelo;
        DateTime horaDeSalida;
        DateTime horaDeLlegada;
        ELugar origen;
        ELugar destino;
        bool wifi;
        bool comida;
        bool internacional;
        double recaudacionTotal;
        bool enVigencia;
        static Vuelo()
        {
            lastId = 1000;
        }
        public Vuelo(int id,bool enVigencia, Aereonave avionAsignado, double duracionVuelo, DateTime horaDeSalida, DateTime horaDeLlegada, ELugar origen, ELugar destino, bool wifi, bool comida, bool internacional, double recaudacionTotal)
        {
            lastId = id;
            this.id = id;
            lastId++;
            this.avionAsignado = avionAsignado;
            this.duracionDelVuelo = duracionVuelo;
            this.horaDeSalida = horaDeSalida;
            this.horaDeLlegada = horaDeLlegada;
            this.origen = origen;
            this.destino = destino;
            this.wifi = wifi;
            this.comida = comida;
            this.internacional = internacional;
            this.recaudacionTotal = recaudacionTotal;
            this.enVigencia = enVigencia;
        }
        public static double CalcularDuracionDeVuelo(bool vueloInternacional)
        {
            Random numeroAleatorio = new Random();
            if (vueloInternacional == true)
            {
                return numeroAleatorio.Next(8, 12);
            }
            return numeroAleatorio.Next(2, 5);
        }
        
        public int Id
        {
            get { return id; }
        }
        public Aereonave AvionAsignado
        {
            get { return this.avionAsignado; }
        }
        public double RecaudacionTotal
        {
            get { return this.recaudacionTotal; }
            set { recaudacionTotal += value; }
        }
        public bool Envigencia
        {
            get { return this.enVigencia; }
            set { enVigencia = value; }
        }
        public string Estado
        {
            get
            {
                int cantidadPasajeros = avionAsignado.cantidadDePasajerosCargados();
                if (cantidadPasajeros < AvionAsignado.PasajerosEnAvion.Length)
                {
                    return "Disponible";
                }
                else
                {
                    return "Completo";
                }
            }
        }
        public string AsientosOcupados
        {
            get
            {
                int cantidadPasajeros = avionAsignado.cantidadDePasajerosCargados();
                string retorno = $"{cantidadPasajeros}/{AvionAsignado.PasajerosEnAvion.Length}";
                return retorno;
            }
        }
        public string MatriculaAvionAsignado
        {
            get { return this.avionAsignado.Matricula; }
        }
        public DateTime HoraDeSalida
        {
            get { return this.horaDeSalida; }
        }
        public double DuracionDelVuelo
        {
            get { return this.duracionDelVuelo; }
        }
        public DateTime HoraDeLlegada
        {
            get { return this.horaDeLlegada; }
        }
        public ELugar Origen
        {
            get { return this.origen; }
        }
        public ELugar Destino
        {
            get { return this.destino; }
        }
        public bool Wifi
        {
            get { return this.wifi; }
        }
        public bool Comida
        {
            get { return this.comida; }
        }
        public bool Internacional
        {
            get { return this.internacional; }
        }
        public static int GenerarId()
        {
            return lastId;
        }
        public override string ToString()
        {
            return id.ToString();
        }
        public override bool Equals(object obj)
        {
            Vuelo vuelo = obj as Vuelo;
            if (vuelo is not null)
            {
                return vuelo.id == this.id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (id).GetHashCode();
        }
        public static double CalcularValorPasaje(bool internacional, double horasDeVuelo, bool claseTurista)
        {
            double valorfinal = 0;
            double porcentajeAdicional = 0;
            if (internacional == true)
            {
                valorfinal = horasDeVuelo * 100;
                if (claseTurista == false)
                {
                    porcentajeAdicional = valorfinal * 0.15;
                    return valorfinal + porcentajeAdicional;
                }
                return valorfinal;
            }
            valorfinal = horasDeVuelo * 50;
            if (claseTurista == false)
            {
                porcentajeAdicional = valorfinal * 0.15;
                return valorfinal + porcentajeAdicional;
            }
            return valorfinal;
        }
        public static double CalcularIva(double precio)
        {
            double calcularPorcentaje;
            calcularPorcentaje = precio * 0.21;
            return calcularPorcentaje;
        }
    }
}
