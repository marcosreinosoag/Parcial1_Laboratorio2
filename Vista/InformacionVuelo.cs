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
    public partial class InformacionVuelo : Form
    {
        Vuelo vueloSeleccionado;
        Aereonave avionAsignado;
        Vendedor usuarioIngresado;
        public InformacionVuelo(Vuelo vueloSeleccionado, Aereonave avionAsignado, Vendedor usuarioIngresado)
        {
            this.usuarioIngresado = usuarioIngresado;
            this.avionAsignado = avionAsignado;
            this.vueloSeleccionado = vueloSeleccionado;
            InitializeComponent();
        }
        private void InformacionVuelo_Load(object sender, EventArgs e)
        {
            txb_idVuelo.Text = vueloSeleccionado.MatriculaAvionAsignado;
            txb_origen.Text = vueloSeleccionado.Origen.ToString();
            txb_destino.Text = vueloSeleccionado.Destino.ToString();
            chb_wifi.Checked = vueloSeleccionado.Wifi;
            chb_comida.Checked = vueloSeleccionado.Comida;
            actulizarDatos();
        }

        private void btn_cargarPasajeros_Click(object sender, EventArgs e)
        {
            lbl_errorPasajeros.Text = "";
            lbl_errorPasajeros.ForeColor = Color.Red;
            int cantidadDeAsientosOcupados = avionAsignado.cantidadDePasajerosCargados();
            int cantidadDeAsientosDisponibles = avionAsignado.CantidadAsientos - cantidadDeAsientosOcupados;
            if (nud_cantidadDePasajeros.Value > 0)////validar  que sea enterooo
            {
                lbl_errorPasajeros.Text = "La cantidad ingresada supera los asientos disponibles";
                if (nud_cantidadDePasajeros.Value < cantidadDeAsientosDisponibles)
                {
                    lbl_errorPasajeros.Visible = false;
                    VenderPasaje frm_venderPasaje = new VenderPasaje(avionAsignado, vueloSeleccionado, (int)nud_cantidadDePasajeros.Value);
                    DialogResult resultado = frm_venderPasaje.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        actulizarDatos();
                        usuarioIngresado.CantidadDePasajesVendidos = (int)nud_cantidadDePasajeros.Value;
                        lbl_errorPasajeros.Text = "Carga realizada correctamente";
                        lbl_errorPasajeros.ForeColor = Color.Green;
                        lbl_errorPasajeros.Visible = true;
                    }
                }
            }
            else
            {
                lbl_errorPasajeros.Text = "La cantidad ingresada debe ser mayor a Cero";
                lbl_errorPasajeros.Visible = true;
            }
        }
        private void actulizarDatos()
        {
            List<Pasajero> auxListPasajeros = avionAsignado.DevolverPasajerosCargados();
            dtg_infoGeneral.DataSource = auxListPasajeros;
        }
        private void btn_infoPasajeros_Click(object sender, EventArgs e)
        {
            actulizarDatos();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btn_equipaje_Click(object sender, EventArgs e)
        {
            Dictionary<Equipaje, Pasajero> equipajes = avionAsignado.EquipajeEnAvion;
            dtg_infoGeneral.DataSource = equipajes.Keys.ToList();
        }

        private void btn_finalizarVuelo_Click(object sender, EventArgs e)
        {
            vueloSeleccionado.Envigencia = false;
            avionAsignado.Disponible = false;
            avionAsignado.ResetearListas();
            this.DialogResult = DialogResult.Cancel;
            Volarg.recaudacionTotal += vueloSeleccionado.RecaudacionTotal;
            this.Close();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1- seleccionando los botones pasajeros o equipaje se informara en pantalla lo indicado \n2-Si la cantidad ingresada de pasajeros es la correspondiente seleccione el boton cargar pasajeros y lo llevara al una pestaña para cargar los pasajeros solicitados\n3-aprete el boton finalizar para cerrar el vuelo\n4-Cancelar para salir");
        }
    }
}
