using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class Volarg
    {
        public static List<Aereonave> listaDeAviones;
        public static List<Vendedor> listaDeVendedores;
        public static List<Vuelo> listaDeVuelos;
        public static List<Pasajero> listaHistorialPasajeros;
        public static double recaudacionTotal = 0;

        static Volarg()
        {
            listaHistorialPasajeros = new List<Pasajero>();
            CargaListaDeVendedores();
            CargaListaDeAviones();
            CargaListaDeVuelos();
        }
        public static double DevolverRecaudacionTotal()
        {
            return Volarg.recaudacionTotal;
        }
        /// <summary>
        /// Busca el id del Pasajero en la lista listaHistorialPasajeros
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Devuelve el indice del pasajero encontrado, caso contrario -1</returns>
        public static int BuscarIdEnListas(string id)
        {
            int index = -1;
            if (id != null)
            {
                foreach (Pasajero item in listaHistorialPasajeros)
                {
                    if (item.Dni == id)
                    {
                        index = listaHistorialPasajeros.IndexOf(item);
                        return index;
                    }
                }
            }
            return index;
        }
        public static int DevolverIndiceVueloPorId(string id)
        {
            int index = -1;
            if (id != null)
            {
                int auxId = Validar.ConvertirStringAEntero(id);
                foreach (Vuelo item in listaDeVuelos)
                {
                    if (item.Id == auxId)
                    {
                        index = listaDeVuelos.IndexOf(item);
                        return index;
                    }
                }
            }
            return index;
        }
        public static double CalcularGananciaVuelosInternacional()
        {
            double internacional = 0;

            foreach (Vuelo item in listaDeVuelos)
            {
                if (item.Internacional == true)
                {
                    internacional += item.RecaudacionTotal;
                }
            }
            return internacional;
        }
        public static double CalcularGananciaVuelosNacional()
        {
            double nacional = 0;

            foreach (Vuelo item in listaDeVuelos)
            {
                if (item.Internacional == false)
                {
                    nacional += item.RecaudacionTotal;
                }
            }
            return nacional;
        }
        public static void CargarPasajeroEnHistorial(Pasajero auxPasajero)
        {
            if (auxPasajero != null)
            {
                listaHistorialPasajeros.Add(auxPasajero);
            }
        }
        public static void CargaDeVuelo(Vuelo vueloCreado)
        {
            if (vueloCreado != null)
            {
                listaDeVuelos.Add(vueloCreado);
            }
        }
        private static void CargaListaDeVuelos()
        {
            listaDeVuelos = new List<Vuelo>();
            double duracionInternacional = Vuelo.CalcularDuracionDeVuelo(true);
            double duracionNacional = Vuelo.CalcularDuracionDeVuelo(false);
            DateTime horaSalidaVuelo1 = new DateTime(2022, 12, 12, 00, 00, 00);
            Vuelo vueloUno = new Vuelo(Vuelo.GenerarId(), true, listaDeAviones[0], duracionInternacional, horaSalidaVuelo1, horaSalidaVuelo1.AddHours(8), ELugar.BuenosAires, ELugar.Miami, true, true, true, 3000);
            Vuelo vueloDos = new Vuelo(Vuelo.GenerarId(), false, listaDeAviones[2], duracionNacional, horaSalidaVuelo1, horaSalidaVuelo1.AddHours(2), ELugar.BuenosAires, ELugar.Bariloche, true, true, false, 15000);
            Vuelo vueloTres = new Vuelo(Vuelo.GenerarId(), false, listaDeAviones[5], duracionNacional, horaSalidaVuelo1, horaSalidaVuelo1.AddHours(3), ELugar.Cordoba, ELugar.Jujuy, true, false, false, 10000);
            Vuelo vueloCuatro = new Vuelo(Vuelo.GenerarId(), false, listaDeAviones[3], duracionNacional, horaSalidaVuelo1, horaSalidaVuelo1.AddHours(4), ELugar.Corrientes, ELugar.Jujuy, true, false, false, 10000);
            Vuelo vueloCinco = new Vuelo(Vuelo.GenerarId(), false, listaDeAviones[3], duracionNacional, horaSalidaVuelo1, horaSalidaVuelo1.AddHours(2), ELugar.Corrientes, ELugar.Jujuy, false, true, false, 3500);
            listaDeVuelos.Add(vueloUno);
            listaDeVuelos.Add(vueloDos);
            listaDeVuelos.Add(vueloTres);
            listaDeVuelos.Add(vueloCuatro);
            listaDeVuelos.Add(vueloCinco);
            recaudacionTotal = 41500;
        }
        private static void CargaListaDeVendedores()
        {
            listaDeVendedores = new List<Vendedor>();
            Vendedor vendedorUno = new Vendedor("40333444", "123", "Marcos", "Reinoso", new DateTime(1997, 03, 20), 10);
            Vendedor vendedorDos = new Vendedor("30353788", "abc123", "Roberto", "Gomez", new DateTime(2002, 08, 6), 2);
            Vendedor vendedorTres = new Vendedor("20162522", "222asd", "Juan", "Perez", new DateTime(1990, 12, 18), 3);
            Vendedor vendedorCuatro = new Vendedor("16558466", "333ads", "Juliana", "Fernandez", new DateTime(1999, 03, 12), 5);
            listaDeVendedores.Add(vendedorUno);
            listaDeVendedores.Add(vendedorDos);
            listaDeVendedores.Add(vendedorTres);
            listaDeVendedores.Add(vendedorCuatro);
        }
        public static string DevolverNombreVendedor(string id)
        {
            if (id != null)
            {
                foreach (Vendedor item in listaDeVendedores)
                {
                    if (item.Usuario == id)
                    {
                        return item.Nombre;
                    }
                }
            }
            return "El id no existe";
        }
        public static bool VerificarUsuarioYClave(string usuario, string clave)
        {
            foreach (Vendedor item in listaDeVendedores)
            {
                if (item.Usuario == usuario && item.VerificarClave(clave))
                {
                    return true;
                }
            }
            return false;
        }
        public static Vendedor DevolverVandedorPorUsuario(string usuario)
        {
            for (int i = 0; i < listaDeVendedores.Count; i++)
            {

                if (listaDeVendedores[i].Usuario == usuario)
                {
                    return listaDeVendedores[i];
                }
            }
            return null;
        }
        private static void CargaListaDeAviones()
        {
            listaDeAviones = new List<Aereonave>();
            Pasajero pasajeroUno = new Pasajero("Marcos", "Reinoso", "40344444", new DateTime(1997, 02, 22), 1, 13);
            Pasajero pasajeroDos = new Pasajero("Martin", "Perez", "40342224", new DateTime(1999, 01, 20), 2, 5);
            Pasajero pasajeroTres = new Pasajero("Jose", "Perez", "40111111", new DateTime(1995, 01, 20), 2, 5);
            listaHistorialPasajeros.Add(pasajeroUno);
            listaHistorialPasajeros.Add(pasajeroDos);
            listaHistorialPasajeros.Add(pasajeroTres);
            int cantidadDeAsientos = 50;
            Pasajero[] pasajeros = new Pasajero[cantidadDeAsientos];
            pasajeros[0] = pasajeroUno;
            pasajeros[1] = pasajeroDos;
            Aereonave avionUno = new Aereonave("STR99877", cantidadDeAsientos, 2, 4, false, pasajeros, 50);
            Aereonave avionDos = new Aereonave("ABB88053", 150, 4, 350, true, 139);
            Aereonave avionTres = new Aereonave("SRR99877", 250, 5, 700, true, 1300);
            Aereonave avionCuatro = new Aereonave("HHY99877", 200, 3, 500, true, 165);
            Aereonave avionCinco = new Aereonave("ABC88053", 100, 1, 350, true, 84);
            Aereonave avionSeis = new Aereonave("TKY79877", 160, 2, 300, true, 106);
            Aereonave avionSiete = new Aereonave("SRR99877", 250, 3, 500, true, 2300);
            listaDeAviones.Add(avionUno);
            listaDeAviones.Add(avionDos);
            listaDeAviones.Add(avionTres);
            listaDeAviones.Add(avionCuatro);
            listaDeAviones.Add(avionCinco);
            listaDeAviones.Add(avionSeis);
            listaDeAviones.Add(avionSiete);
        }
        public static int BuscarIndiceAvionPorMatricula(string matriculaAvion)
        {
            int indice = -1;
            foreach (Aereonave item in listaDeAviones)
            {
                if (item.Matricula == matriculaAvion)
                {
                    indice = listaDeAviones.IndexOf(item);
                    return indice;
                }
            }
            return indice;
        }
        public static Pasajero DevolverPasajeroConMasViajes()
        {
            Pasajero auxPasajeroMasViajes = null;
            int i = 0;
            foreach (Pasajero item in listaHistorialPasajeros)
            {
                if (i == 0)
                {
                    auxPasajeroMasViajes = item;
                    i++;
                }
                if (item.ViajesRealizados > auxPasajeroMasViajes.ViajesRealizados)
                {
                    auxPasajeroMasViajes = item;
                }
            }
            return auxPasajeroMasViajes;
        }
        public static Vendedor DevolverVendedorMasPasajesVendidos()
        {
            Vendedor auxVendedorMasPasajes = null;
            int i = 0;
            foreach (Vendedor item in listaDeVendedores)
            {
                if (i == 0)
                {
                    auxVendedorMasPasajes = item;
                    i++;
                }
                if (item.CantidadDePasajesVendidos > auxVendedorMasPasajes.CantidadDePasajesVendidos)
                {
                    auxVendedorMasPasajes = item;
                }
            }
            return auxVendedorMasPasajes;
        }
        public static List<Vuelo> DevolverListaDeVuelosOrdenada()
        {
            List<Vuelo> auxListaVuelos = Volarg.listaDeVuelos;
            auxListaVuelos.Sort(CompararVuelosPorRecaudacionTotal);
            return auxListaVuelos;
        }
        static int CompararVuelosPorRecaudacionTotal(Vuelo vuelo1, Vuelo vuelo2)
        {
            return (int)vuelo2.RecaudacionTotal - (int)vuelo1.RecaudacionTotal;
        }
        public static List<Pasajero> DevolverListaDePasajerosOrdenada()
        {
            List<Pasajero> auxListaPasajeros = Volarg.listaHistorialPasajeros;
            auxListaPasajeros.Sort(CompararPasajerosPorCantidadDeVuelos);
            return auxListaPasajeros;
        }
        static int CompararPasajerosPorCantidadDeVuelos(Pasajero a, Pasajero b)
        {
            return a.ViajesRealizados - b.ViajesRealizados;
        }
        public static List<Vuelo> DevolverListaVuelosOrdenadaServicio()
        {
            List<Vuelo> auxListaPasajeros = Volarg.listaDeVuelos;
            auxListaPasajeros.Sort(CompararVuelosPorServicio);
            return auxListaPasajeros;
        }
        static int CompararVuelosPorServicio(Vuelo a, Vuelo b)
        {
            if (a.Internacional)
            {
                if (b.Internacional == false)
                {
                    return 1;
                }
            }
            else
            {
                if (b.Internacional == true)
                {
                    return -1;
                }
            }
            return 0;
        }
        public static void CargarPasajeroEnhistorial(List<Pasajero> listaPasajeros)
        {
            int indicePasajeroABuscar;
            foreach (Pasajero item in listaPasajeros)
            {
                if (item != null)
                {
                    indicePasajeroABuscar = Volarg.BuscarIdEnListas(item.Dni);
                    if (indicePasajeroABuscar == -1)
                    {
                        Volarg.CargarPasajeroEnHistorial(item);
                    }
                    else
                    {
                        Volarg.listaHistorialPasajeros[indicePasajeroABuscar] = item;
                    }
                }
            }
        }
        public static List<Vuelo> DevolverListaFiltrada(bool wifi, bool comida)
        {
            List<Vuelo> auxListaVuelo = new List<Vuelo>();

            foreach (Vuelo item in Volarg.listaDeVuelos)
            {
                if (item != null && item.Comida == comida && item.Wifi == wifi)
                {
                    auxListaVuelo.Add(item);
                }
            }
            return auxListaVuelo;
        }
    }
}
