using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class MenuPrincipal : Form
    {
        string nombre;
        Vendedor usuarioIngresado;
        public MenuPrincipal(string nombre, Vendedor usuarioIngresado)
        {
            this.usuarioIngresado = usuarioIngresado;
            this.nombre = nombre;
            InitializeComponent();
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.Date.ToShortDateString();
            lbl_nombreUsuario.Text = "Bienvenido " + nombre;
            dtg_infoGeneral.DataSource = Volarg.listaDeVuelos;
        }
        private void crearVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            CrearVuelo frm_agregarVuelo = new CrearVuelo();
            resultado = frm_agregarVuelo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                dtg_infoGeneral.DataSource = null;
                dtg_infoGeneral.DataSource = Volarg.listaDeVuelos;
            }
            ActualizarEnableMenuTripAviones();
        }
        private void vuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            ocultarDatosgananciaTotal(false);
            OcultarBotonVendedor(false);
            OcultarBotonPasajero(false);
            ocultarFiltrosDeVuelos(true);
            dtg_infoGeneral.DataSource = "";
            dtg_infoGeneral.DataSource = Volarg.listaDeVuelos;
            dtg_infoGeneral.Enabled = true;
            ActualizarEnableMenuTripAviones();
        }
        private void OcultarBotonPasajero(bool visible)
        {
            if (visible == true)
            {
                btn_pasajeroMasViajes.Visible = visible;
            }
            else
            {
                btn_pasajeroMasViajes.Visible = visible;
            }
        }
        private void OcultarBotonVendedor(bool visible)
        {
            if (visible == true)
            {
                btn_vendedorMasPasajesVendidos.Visible = visible;
            }
            else
            {
                btn_vendedorMasPasajesVendidos.Visible = visible;
            }
        }
        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarDatosgananciaTotal(false);
            OcultarBotonVendedor(false);
            OcultarBotonPasajero(false);
            ocultarFiltrosDeVuelos(false);
            lbl_error.Visible = false;
            dtg_infoGeneral.DataSource = Volarg.listaDeVendedores;
            dtg_infoGeneral.Enabled = false;
            ActualizarEnableMenuTripAviones();
        }
        private void avionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            ocultarDatosgananciaTotal(false);
            OcultarBotonVendedor(false);
            OcultarBotonPasajero(false);
            ocultarFiltrosDeVuelos(false);
            bmt_aviones.Enabled = false;
            List<Aereonave> auxListaAviones = Volarg.listaDeAviones;
            dtg_infoGeneral.DataSource = auxListaAviones;
            dtg_infoGeneral.Columns.RemoveAt(0);
            dtg_infoGeneral.Enabled = false;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_error.Visible = false;
            string id = dtg_infoGeneral.CurrentRow.Cells[0].Value.ToString();
            int auxIndice = Volarg.DevolverIndiceVueloPorId(id);
            InformacionVuelo frm_informacionVuelo = new InformacionVuelo(Volarg.listaDeVuelos[auxIndice], Volarg.listaDeVuelos[auxIndice].AvionAsignado, usuarioIngresado);
            if (Volarg.listaDeVuelos[auxIndice].Envigencia == true)
            {
                DialogResult resultado = frm_informacionVuelo.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    ActualizarListaVuelos();
                    lbl_error.Visible = false;
                    chb_comida.Checked = false;
                    chb_wifi.Checked = false;
                }
            }
            else
            {
                lbl_error.Visible = true;
                lbl_error.Text = "El vuelo seleccionado no esta en Vigencia";
            }
        }
        private void ActualizarListaVuelos()
        {
            dtg_infoGeneral.DataSource = "";
            dtg_infoGeneral.DataSource = Volarg.listaDeVuelos;
            dtg_infoGeneral.Enabled = true;
            ActualizarEnableMenuTripAviones();
        }
        private void listaDeDestinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            ocultarDatosgananciaTotal(false);
            OcultarBotonVendedor(false);
            OcultarBotonPasajero(false);
            ocultarFiltrosDeVuelos(false);
            dtg_infoGeneral.DataSource = "";
            List<Vuelo> auxVuelos = Volarg.DevolverListaDeVuelosOrdenada();
            dtg_infoGeneral.DataSource = auxVuelos;
            dtg_infoGeneral.Enabled = true;
            ActualizarEnableMenuTripAviones();
        }
        private void listaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            ocultarDatosgananciaTotal(false);
            OcultarBotonVendedor(false);
            OcultarBotonPasajero(true);
            ocultarFiltrosDeVuelos(false);
            List<Pasajero> auxPasajero = Volarg.listaHistorialPasajeros;
            dtg_infoGeneral.DataSource = auxPasajero;
            dtg_infoGeneral.Enabled = false;
            ActualizarEnableMenuTripAviones();
        }
        private void aereonavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            ocultarDatosgananciaTotal(false);
            OcultarBotonVendedor(false);
            OcultarBotonPasajero(false);
            ocultarFiltrosDeVuelos(false);
            bmt_listaAereonaves.Enabled = false;
            dtg_infoGeneral.DataSource = Volarg.listaDeAviones;
            dtg_infoGeneral.Columns.RemoveAt(0);
            dtg_infoGeneral.Columns.RemoveAt(1);
            dtg_infoGeneral.Columns.RemoveAt(1);
            dtg_infoGeneral.Columns.RemoveAt(1);
            dtg_infoGeneral.Columns.RemoveAt(1);
            dtg_infoGeneral.Enabled = false;
        }
        private void ActualizarEnableMenuTripAviones()
        {
            bmt_listaAereonaves.Enabled = true;
            bmt_aviones.Enabled = true;
        }
        private void vendedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            ocultarDatosgananciaTotal(false);
            OcultarBotonVendedor(true);
            OcultarBotonPasajero(false);
            ocultarFiltrosDeVuelos(false);
            dtg_infoGeneral.DataSource = Volarg.listaDeVendedores;
            dtg_infoGeneral.Enabled = false;
            ActualizarEnableMenuTripAviones();
        }
        private void btn_vendedorMayorEdad_Click(object sender, EventArgs e)
        {
            Vendedor auxVendedor;
            auxVendedor = Volarg.DevolverVendedorMasPasajesVendidos();
            MessageBox.Show(auxVendedor.MostrarDatos());
        }
        private void btn_pasajeroMasViejes_Click(object sender, EventArgs e)
        {
            Pasajero auxPasajero;
            auxPasajero = Volarg.DevolverPasajeroConMasViajes();
            MessageBox.Show(auxPasajero.MostrarDatos());
        }
        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1-Seleccionando los botones del menu de la parte superior vera la informacion correspondiente \n2-realice doble click sobre el vuelo que desea ingresar\n3-aprete el boton Salir para finalizar el programa");
        }
        private void gananciasTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtg_infoGeneral.Enabled = true;
            lbl_error.Visible = false;
            OcultarBotonVendedor(false);
            OcultarBotonPasajero(false);
            ocultarFiltrosDeVuelos(false);
            ocultarDatosgananciaTotal(true);
            dtg_infoGeneral.DataSource = "";
            dtg_infoGeneral.DataSource = Volarg.DevolverListaVuelosOrdenadaServicio();
            lbl_recaudacionTotal.Text = $"Recaudacion TOTAL $ {Volarg.DevolverRecaudacionTotal()}";
            lbl_recaudacionInternacional.Text = $"Recaudacion vuelos Internacionales $ {Volarg.CalcularGananciaVuelosInternacional()}";
            lbl_recaudacionCabotaje.Text = $"Recaudacion vuelos Cabotajes $ {Volarg.CalcularGananciaVuelosNacional()}";
        }
        private void ocultarDatosgananciaTotal(bool visible)
        {
            if (visible == true)
            {
                lbl_recaudacionTotal.Visible = visible;
                lbl_recaudacionInternacional.Visible = visible;
                lbl_recaudacionCabotaje.Visible = visible;
            }
            else
            {
                lbl_recaudacionTotal.Visible = visible;
                lbl_recaudacionInternacional.Visible = visible;
                lbl_recaudacionCabotaje.Visible = visible;
            }
        }
        private void chb_wifi_CheckedChanged(object sender, EventArgs e)
        {
            List<Vuelo> auxListaVuelo = new List<Vuelo>();
            if (chb_wifi.Checked == true)
            {
                if (chb_comida.Checked == true)
                {
                    dtg_infoGeneral.DataSource = Volarg.DevolverListaFiltrada(true, true);
                }
                else
                {
                    dtg_infoGeneral.DataSource = Volarg.DevolverListaFiltrada(true, false);
                }
            }
            else if (chb_comida.Checked == true)
            {
                dtg_infoGeneral.DataSource = Volarg.DevolverListaFiltrada(false, true);
            }
            else
            {
                ActualizarListaVuelos();
            }
        }
        private void ocultarFiltrosDeVuelos(bool visible)
        {
            if (visible == true)
            {
                lbl_filtrar.Visible = visible;
                chb_comida.Visible = visible;
                chb_wifi.Visible = visible;
            }
            else
            {
                lbl_filtrar.Visible = visible;
                chb_comida.Visible = visible;
                chb_wifi.Visible = visible;
            }
        }
        private void chb_comida_CheckedChanged(object sender, EventArgs e)
        {
            List<Vuelo> auxListaVuelo = new List<Vuelo>();
            if (chb_comida.Checked == true)
            {
                if (chb_wifi.Checked == true)
                {
                    dtg_infoGeneral.DataSource = Volarg.DevolverListaFiltrada(true, true);
                }
                else
                {
                    dtg_infoGeneral.DataSource = Volarg.DevolverListaFiltrada(true, false);
                }
            }
            else if (chb_wifi.Checked == true)
            {
                dtg_infoGeneral.DataSource = Volarg.DevolverListaFiltrada(true, false);
            }
            else
            {
                ActualizarListaVuelos();
            }
        }
    }
}
