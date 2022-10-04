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

        static Volarg()
        {
            listaHistorialPasajeros = new List<Pasajero>();
            CargaListaDeVendedores();
            CargaListaDeAviones();
            CargaListaDeVuelos();
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
            double duracion = Vuelo.CalcularDuracionDeVuelo(true);
            DateTime horaSalidaVuelo1 = new DateTime(2022, 12, 12, 00, 00, 00);
            Vuelo vueloUno = new Vuelo(Vuelo.GenerarId(), listaDeAviones[0], duracion, horaSalidaVuelo1, horaSalidaVuelo1.AddHours(8), ELugar.BuenosAires, ELugar.Miami, true, true, true);
            listaDeVuelos.Add(vueloUno);
        }
        private static void CargaListaDeVendedores()
        {
            listaDeVendedores = new List<Vendedor>();
            Vendedor vendedorUno = new Vendedor("40333444", "123", "Marcos", "Reinoso", new DateTime(1997, 03, 20));
            Vendedor vendedorDos = new Vendedor("30353788", "abc", "Roberto", "Gomez", new DateTime(2002, 08, 6));
            Vendedor vendedorTres = new Vendedor("20162522", "222", "Juan", "Perez", new DateTime(1990, 12, 18));
            Vendedor vendedorCuatro = new Vendedor("16558466", "333", "Juliana", "Fernandez", new DateTime(1999, 03, 12));
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
        private static void CargaListaDeAviones()
        {
            listaDeAviones = new List<Aereonave>();
            Pasajero pasajeroUno = new Pasajero("marcos", "Reinoso", "40344444", new DateTime(1997, 02, 22), 1, 13);
            Pasajero pasajeroDos = new Pasajero("martin", "perez", "40342224", new DateTime(1999, 01, 20), 2, 5);
            Pasajero pasajeroTres = new Pasajero("Jose", "perez", "40111111", new DateTime(1995, 01, 20), 2, 5);
            listaHistorialPasajeros.Add(pasajeroUno);
            listaHistorialPasajeros.Add(pasajeroDos);
            listaHistorialPasajeros.Add(pasajeroTres);
            int cantidadDeAsientos = 50;
            Pasajero[] pasajeros = new Pasajero[cantidadDeAsientos];
            pasajeros[0] = pasajeroUno;
            pasajeros[1] = pasajeroDos;
            Aereonave avionUno = new Aereonave("STR99877", cantidadDeAsientos, 2, 100, false, pasajeros, 50);
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
        public static Aereonave BuscarAvionPorMatricula(string matriculaAvion)
        {
            Aereonave auxAvion = null;
            foreach (Aereonave item in listaDeAviones)
            {
                if (item.Matricula == matriculaAvion)
                {
                    auxAvion = item;
                    return auxAvion;
                }
            }
            return auxAvion;
        }
    }
}
