using System;
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
        Trellew,
        Tucuman,
        PuertoMadryn,
        Usuahuaia,
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
        int duracion;
        DateTime horaDeSalida;
        DateTime horaDeLlegada;
        ELugar origen;
        ELugar destino;
        bool wifi;
        bool comida;
        bool internacional;

        static Vuelo()
        {
            lastId = 1000;
        }
        public Vuelo(int id, Aereonave avionAsignado, int duracion, DateTime horaDeSalida, DateTime horaDeLlegada, ELugar origen, ELugar destino, bool wifi, bool comida, bool internacional)
        {
            lastId = id;
            this.id = id;
            lastId++;
            this.avionAsignado = avionAsignado;
            this.duracion = duracion;
            this.horaDeSalida = horaDeSalida;
            this.horaDeLlegada = horaDeLlegada;
            this.origen = origen;
            this.destino = destino;
            this.wifi = wifi;
            this.comida = comida;
            this.internacional = internacional;
        }
        public static int CalcularDuracionDeVuelo(bool vueloInternacional)
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
        public string AvionAsignado
        {
            get { return this.avionAsignado.Matricula; }
        }
        public DateTime HoraDeSalida
        {
            get { return this.horaDeSalida; }
        }
        public int DuracionDelVuelo
        {
            get { return this.duracion; }
        }
        public DateTime HoraDeLlegada
        {
            get
            {
                return this.horaDeLlegada;
            }
        }
        public ELugar Origen
        {
            get { return this.origen; }
        }
        public ELugar Destino
        {
            get
            {
                return this.destino;
            }
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
    }
}
