using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aereonave
    {
        Pasajero[] pasajerosEnAvion;
        Dictionary<Equipaje, Pasajero> equipajesEnAvion;
        string matricula;
        int cantidadAsientos;
        int cantidadDeBaños;
        int capacidadBodega;
        bool disponible;
        double horasDeVuelo;
        public Aereonave(string matricula, int cantidadAsientos, int cantidadDeBaños, int capacidadBodega, bool disponible, double horasDeVuelo)
        {
            equipajesEnAvion = new Dictionary<Equipaje, Pasajero>();
            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadDeBaños = cantidadDeBaños;
            this.capacidadBodega = capacidadBodega;
            this.disponible = disponible;
            pasajerosEnAvion = new Pasajero[cantidadAsientos];
            this.horasDeVuelo = horasDeVuelo;
        }
        public Aereonave(string matricula, int cantidadAsientos, int cantidadDeBaños, int capacidadBodega, bool disponible, Pasajero[] pasajeros, double horasDeVuelo) : this(matricula, cantidadAsientos, cantidadDeBaños, capacidadBodega, disponible, horasDeVuelo)
        {
            pasajerosEnAvion = pasajeros;
        }
        public override string ToString()
        {
            return matricula.ToString();
        }
        public Pasajero[] PasajerosEnAvion
        {
            get { return this.pasajerosEnAvion; }
        }
        public Dictionary<Equipaje, Pasajero> EquipajeEnAvion
        {
            get { return this.equipajesEnAvion; }
        }
        public string Matricula
        {
            get { return this.matricula; }
        }
        public bool Disponible
        {
            get { return this.disponible; }
            set { disponible = value; }
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
        public double HorasDeVuelo
        {
            get { return horasDeVuelo; }
        }
        public void ResetearListas()
        {
            this.equipajesEnAvion.Clear();
            for (int i = 0; i < pasajerosEnAvion.Length; i++)
            {
                pasajerosEnAvion[i] = null;
            }
        }
        public bool BuscarIdEnArrayPasajeros(string id)
        {
            bool estaEnVuelo = false;
            if (id != null)
            {
                foreach (Pasajero item in pasajerosEnAvion)
                {
                    if (item != null)
                    {
                        if (item.Dni == id)
                        {
                            estaEnVuelo = true;
                            return estaEnVuelo;
                        }
                    }
                }
            }
            return estaEnVuelo;
        }
        public List<Equipaje> DevolverEquipajeCargados()
        {
            List<Equipaje> auxListaPasajeros = new List<Equipaje>();
            foreach (var item in equipajesEnAvion)
            {
                if (item.Key != null)
                {
                    auxListaPasajeros.Add(item.Key);
                }
            }
            return auxListaPasajeros;
        }
        public List<Pasajero> DevolverPasajerosCargados()
        {
            List<Pasajero> auxListaPasajeros = new List<Pasajero>();
            foreach (Pasajero item in pasajerosEnAvion)
            {
                if (item != null)
                {
                    auxListaPasajeros.Add(item);
                }
            }
            return auxListaPasajeros;
        }
        public void CargarPasajerosAlVuelo(List<Pasajero> listaDePasajeros)
        {
            if (listaDePasajeros != null)
            {
                foreach (Pasajero item in listaDePasajeros)
                {
                    if (item != null)
                    {
                        int indice = item.AsientoAsignado - 1;
                        pasajerosEnAvion[indice] = item;
                    }
                }
            }
        }
        public void CargarEquipajeAlVuelo(Dictionary<Equipaje, Pasajero> listaDeEquipajes)
        {
            if (listaDeEquipajes != null)
            {
                foreach (var item in listaDeEquipajes)
                {
                    if (item.Key != null)
                    {
                        equipajesEnAvion.Add(item.Key, item.Value);
                    }
                }
            }
        }
        public int cantidadDePasajerosCargados()
        {
            int acumuladorDePasajeros = 0;
            foreach (Pasajero item in pasajerosEnAvion)
            {
                if (item != null)
                {
                    acumuladorDePasajeros += 1;
                }
            }
            return acumuladorDePasajeros;
        }
        public int CalcularCantidadDeAsientosPremium()
        {
            int cantidadDeAsientosEnAvion = this.cantidadAsientos;
            double cantidadDeAsientosPremium = 0;
            if (cantidadDeAsientosEnAvion > 0)
            {
                cantidadDeAsientosPremium = cantidadDeAsientosEnAvion * 0.2;
            }
            return (int)cantidadDeAsientosPremium;
        }
    }
}
