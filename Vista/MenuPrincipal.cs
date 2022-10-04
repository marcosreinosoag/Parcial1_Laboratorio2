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
        public MenuPrincipal(string nombre)
        {
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
            dtg_infoGeneral.DataSource = Volarg.listaDeVuelos;
            dtg_infoGeneral.Enabled = true;
            ActualizarEnableMenuTripAviones();
        }
        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtg_infoGeneral.DataSource = Volarg.listaDeVendedores;
            dtg_infoGeneral.Enabled = false;
            ActualizarEnableMenuTripAviones();
        }
        private void avionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avionesToolStripMenuItem.Enabled = false;
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
            int indice = dtg_infoGeneral.CurrentCell.RowIndex;
            InformacionVuelo frm_informacionVuelo = new InformacionVuelo(Volarg.listaDeVuelos[indice], Volarg.listaDeVuelos[indice].AvionAsignado);
            if (Volarg.listaDeVuelos[indice].Envigencia == true)
            {
                DialogResult resultado = frm_informacionVuelo.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    ActualizarListaVuelos();
                    lbl_error.Visible = false;
                }
            }
            else
            {
                lbl_error.Text = "El vuelo seleccionado no esta en Vigencia";
            }
        }
        private void ActualizarListaVuelos()
        {
            dtg_infoGeneral.DataSource = Volarg.listaDeVuelos;
            dtg_infoGeneral.Enabled = true;
            ActualizarEnableMenuTripAviones();
        }
        private void listaDeDestinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Vuelo> auxVuelos = Volarg.DevolverListaDeVuelosOrdenada();
            dtg_infoGeneral.DataSource = auxVuelos;
            dtg_infoGeneral.Enabled = false;
            ActualizarEnableMenuTripAviones();
        }

        private void listaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Pasajero> auxPasajero = Volarg.listaHistorialPasajeros;
            dtg_infoGeneral.DataSource = auxPasajero;
            dtg_infoGeneral.Enabled = false;
            ActualizarEnableMenuTripAviones();
        }

        private void aereonavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aereonavesToolStripMenuItem.Enabled = false;
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
            aereonavesToolStripMenuItem.Enabled = true;
            avionesToolStripMenuItem.Enabled = true;
        }

        private void vendedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dtg_infoGeneral.DataSource = Volarg.listaDeVendedores;
            dtg_infoGeneral.Enabled = false;
            btn_vendedorMayorEdad.Visible = true;
            ActualizarEnableMenuTripAviones();
        }

        private void btn_vendedorMayorEdad_Click(object sender, EventArgs e)
        {
            Vendedor auxVendedor;
            auxVendedor = Volarg.DevolverVendedorMayorEdad();
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
    }
}
