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
    public partial class CrearVuelo : Form
    {
        bool vueloInternacional;
        public CrearVuelo()
        {
            InitializeComponent();
        }
        private void AgregarVuelo_Load(object sender, EventArgs e)
        {
            CargarOrigenNacional();
            CargarDestinoNacional();
            CargarAvionesDisponibles();
        }
        private void chx_internacional_CheckedChanged(object sender, EventArgs e)
        {
            if (chx_internacional.Checked == true)
            {
                vueloInternacional = true;
                cmb_origen.Text = null;
                cmb_destino.Text = null;
                CargarDestinoInternacional();
                CargarOrigenInternacional();
            }
            else
            {
                vueloInternacional = false;
                cmb_origen.Text = null;
                cmb_destino.Text = null;
                CargarDestinoNacional();
                CargarOrigenNacional();
            }
        }
        private void btn_generarDuracion_Click(object sender, EventArgs e)
        {
            DateTime horaDeLlegada;
            int duracionDelVuelo;
            horaDeLlegada = dtp_horaDeSalida.Value;
            duracionDelVuelo = Vuelo.CalcularDuracionDeVuelo(vueloInternacional);
            txt_duracionVuelo.Text = duracionDelVuelo.ToString();
            dtp_horaDeLlegada.Value = horaDeLlegada.AddHours(duracionDelVuelo);
            dtp_horaDeLlegada.Format = DateTimePickerFormat.Custom;
        }
        private void cmb_origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            if (vueloInternacional)
            {
                CargarDestinoInternacional();
                cmb_destino.Items.Remove(cmb_origen.SelectedItem);
            }
            else
            {
                CargarDestinoNacional();
                cmb_destino.Items.Remove(cmb_origen.SelectedItem);
            }
        }
        private void cmb_destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            if (vueloInternacional)
            {
                CargarOrigenInternacional();
                cmb_origen.Items.Remove(cmb_destino.SelectedItem);
            }
            else
            {
                CargarOrigenNacional();
                cmb_origen.Items.Remove(cmb_destino.SelectedItem);
            }

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }
        private void CargarAvionesDisponibles()
        {
            foreach (Aereonave item in Volarg.listaDeAviones)
            {
                if (item.Disponible == true)
                {
                    cmb_avionAsignado.Items.Add(item.Matricula);
                }
            }
        }
        private void CargarOrigenInternacional()
        {
            cmb_origen.Items.Clear();
            cmb_origen.Items.Add(ELugar.BuenosAires);
            cmb_origen.Items.Add(ELugar.Acapulco);
            cmb_origen.Items.Add(ELugar.Miami);
            cmb_origen.Items.Add(ELugar.Recife);
            cmb_origen.Items.Add(ELugar.Roma);
        }
        private void CargarDestinoInternacional()
        {
            cmb_destino.Items.Clear();
            cmb_destino.Items.Add(ELugar.BuenosAires);
            cmb_destino.Items.Add(ELugar.Acapulco);
            cmb_destino.Items.Add(ELugar.Miami);
            cmb_destino.Items.Add(ELugar.Recife);
            cmb_destino.Items.Add(ELugar.Roma);
        }
        private void CargarDestinoNacional()
        {
            cmb_destino.Items.Clear();
            cmb_destino.Items.Add(ELugar.BuenosAires);
            cmb_destino.Items.Add(ELugar.Bariloche);
            cmb_destino.Items.Add(ELugar.Cordoba);
            cmb_destino.Items.Add(ELugar.Corrientes);
            cmb_destino.Items.Add(ELugar.Iguazu);
            cmb_destino.Items.Add(ELugar.Jujuy);
            cmb_destino.Items.Add(ELugar.Mendoza);
            cmb_destino.Items.Add(ELugar.Neuquen);
            cmb_destino.Items.Add(ELugar.Posadas);
            cmb_destino.Items.Add(ELugar.PuertoMadryn);
            cmb_destino.Items.Add(ELugar.Salta);
            cmb_destino.Items.Add(ELugar.SantaRosa);
            cmb_destino.Items.Add(ELugar.SantiagoDelEstero);
            cmb_destino.Items.Add(ELugar.Trellew);
            cmb_destino.Items.Add(ELugar.Tucuman);
            cmb_destino.Items.Add(ELugar.Usuahuaia);
        }
        private void CargarOrigenNacional()
        {
            cmb_origen.Items.Clear();
            cmb_origen.Items.Add(ELugar.BuenosAires);
            cmb_origen.Items.Add(ELugar.Bariloche);
            cmb_origen.Items.Add(ELugar.Cordoba);
            cmb_origen.Items.Add(ELugar.Corrientes);
            cmb_origen.Items.Add(ELugar.Iguazu);
            cmb_origen.Items.Add(ELugar.Jujuy);
            cmb_origen.Items.Add(ELugar.Mendoza);
            cmb_origen.Items.Add(ELugar.Neuquen);
            cmb_origen.Items.Add(ELugar.Posadas);
            cmb_origen.Items.Add(ELugar.PuertoMadryn);
            cmb_origen.Items.Add(ELugar.Salta);
            cmb_origen.Items.Add(ELugar.SantaRosa);
            cmb_origen.Items.Add(ELugar.SantiagoDelEstero);
            cmb_origen.Items.Add(ELugar.Trellew);
            cmb_origen.Items.Add(ELugar.Tucuman);
            cmb_origen.Items.Add(ELugar.Usuahuaia);
        }
        private void LimpiarCampos()
        {
            btn_generarDuracion.Enabled = true;
            txt_duracionVuelo.Text = null;
            dtp_horaDeLlegada.Value = new DateTime(2022, 02, 02, 00, 00, 00);
            dtp_horaDeLlegada.Format = DateTimePickerFormat.Time;
        }
    }
}
