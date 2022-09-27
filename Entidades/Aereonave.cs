using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aereonave
    {
        Pasajero[] claseComun;
        Pasajero[] clasePremium;
        string matricula;
        int cantidadAsientos;
        int cantidadDeBaños;
        int capacidadBodega;
        bool disponible;

        public Aereonave(string matricula, int cantidadAsientos, int cantidadDeBaños, int capacidadBodega, bool disponible)
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadDeBaños = cantidadDeBaños;
            this.capacidadBodega = capacidadBodega;
            this.disponible = disponible;
            DistibuirCantidadDeAsientos(cantidadAsientos);
        }
        public bool Disponible
        {
            get { return this.disponible; }
        }
        public string Matricula
        {
            get { return this.matricula; }
        }
        public int CantidadAsientos
        {
            get { return this.cantidadAsientos; }
        }
        public int CantidadDeBaños
        {
            get { return this.cantidadDeBaños; }
        }
        public int CapacidadBodega
        {
            get { return this.capacidadBodega; }
        }
        private void DistibuirCantidadDeAsientos(int cantidad)
        {
            if (cantidad > 0)
            {
                int calcularPorcentaje = cantidad * (int)0.2;
                int cantidadAsientosClaseComun = cantidad - calcularPorcentaje;
                int cantidadAsientosClasePremiun = calcularPorcentaje;
                claseComun = new Pasajero[cantidadAsientosClaseComun];
                clasePremium = new Pasajero[cantidadAsientosClasePremiun];
            }
        }
    }
}
