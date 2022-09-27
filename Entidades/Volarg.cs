using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class Volarg
    {
        public static List<Aereonave> listaDeAviones;
        public static List<Vendedor> listaDeVendedores;
        public static List<Vuelo> listaDeVuelos;
        public static List<Pasajero> listaDePasajeros;

        static Volarg()
        {
            CargaListaDeVendedores();
            CargaListaDeAviones();
            CargaListaDeVuelos();
        }
        private static void CargaListaDeVuelos()
        {
            listaDeVuelos = new List<Vuelo>();
            int duracion = Vuelo.CalcularDuracionDeVuelo(true);
            DateTime horaSalidaVuelo1 = new DateTime(2022, 12, 12, 00, 00, 00);
            Vuelo vueloUno = new Vuelo(Vuelo.GenerarId(),listaDeAviones[0], duracion, horaSalidaVuelo1, horaSalidaVuelo1.AddHours(8), ELugar.BuenosAires, ELugar.Miami,true,true,true);
            listaDeVuelos.Add(vueloUno);
        }
        private static void CargaListaDeVendedores()
        {
            listaDeVendedores = new List<Vendedor>();
            Vendedor vendedorUno = new Vendedor("40333444", "123", "Marcos", "Reinoso");
            listaDeVendedores.Add(vendedorUno);
        }
        private static void CargaListaDeAviones()
        {
            listaDeAviones = new List<Aereonave>();
            Aereonave avionUno = new Aereonave("str99877", 50, 2, 100, false);
            Aereonave avionDos = new Aereonave("abb88053", 150, 4, 350, true);
            Aereonave avionTres = new Aereonave("srr99877", 350, 5, 700, true);
            listaDeAviones.Add(avionUno);
            listaDeAviones.Add(avionDos);
            listaDeAviones.Add(avionTres);
        }
        public static string DevolverNombreUsuario(string id)
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
    }
}
