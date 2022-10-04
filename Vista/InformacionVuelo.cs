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
        public InformacionVuelo(Vuelo vueloSeleccionado, Aereonave avionAsignado)
        {
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
            int cantidadDeAsientosOcupados = avionAsignado.cantidadDePasajerosCargados();
            int cantidadDeAsientosDisponibles = avionAsignado.CantidadAsientos - cantidadDeAsientosOcupados;
            if (nud_cantidadDePasajeros.Value > 0)////validar  que sea enterooo
            {
                lbl_errorCantidadPasajeros.Visible = true;
                lbl_errorCantidadPasajeros.Text = "La cantidad ingresada supera los asientos disponibles";
                if (nud_cantidadDePasajeros.Value < cantidadDeAsientosDisponibles)
                {
                    lbl_errorCantidadPasajeros.Visible = false;
                    VenderPasaje frm_venderPasaje = new VenderPasaje(avionAsignado, vueloSeleccionado, (int)nud_cantidadDePasajeros.Value);
                    DialogResult resultado = frm_venderPasaje.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        actulizarDatos();
                    }
                }
            }
            else
            {
                lbl_errorCantidadPasajeros.Text = "La cantidad ingresada debe ser mayor a Cero";
                lbl_errorCantidadPasajeros.Visible = true;
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
            this.Close();
        }
    }
}
