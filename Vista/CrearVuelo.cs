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
        bool wifi;
        bool comida;
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
            double duracionDelVuelo;
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
                if (cmb_origen.SelectedItem != null)
                {
                    cmb_origen.Items.Remove(cmb_destino.SelectedItem);
                }
            }
            else
            {
                CargarDestinoNacional();
                ELugar aux = (ELugar)cmb_origen.SelectedItem;
                cmb_destino.Items.Remove(aux);
            }
        }
        private void cmb_destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            if (vueloInternacional)
            {
                //CargarOrigenInternacional();
                //cmb_destino.Items.RemoveAt(cmb_origen.SelectedIndex);
            }
            else
            {
                CargarOrigenNacional();
                ELugar aux = (ELugar)cmb_destino.SelectedItem;
                cmb_origen.Items.Remove(aux);
            }
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Vuelo auxVuelo;
            Aereonave auxAereonave;
            if (ValidarDatos(this.cmb_avionAsignado.Text, txt_duracionVuelo.Text, this.dtp_horaDeSalida.Value, this.dtp_horaDeLlegada.Value, this.cmb_origen.Text, this.cmb_destino.Text) == 6)
            {
                ELugar lugarOrigen = (ELugar)this.cmb_origen.SelectedItem;
                ELugar lugarDestino = (ELugar)this.cmb_destino.SelectedItem;
                int duracion;
                int.TryParse(txt_duracionVuelo.Text, out duracion);////funcion
                auxAereonave = Volarg.BuscarAvionPorMatricula(cmb_avionAsignado.Text);
                auxVuelo = new Vuelo(Vuelo.GenerarId(), auxAereonave, duracion, this.dtp_horaDeSalida.Value, this.dtp_horaDeLlegada.Value, lugarOrigen, lugarDestino, this.wifi, this.comida, this.vueloInternacional);
                if (auxVuelo != null)
                {
                    Volarg.CargaDeVuelo(auxVuelo);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="avionAsignado"></param>
        /// <param name="duracion"></param>
        /// <param name="fechaDeSalida"></param>
        /// <param name="fechaDeLlegada"></param>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        /// <returns>Retorna 5 si salio todo bien, sino presenta en pantalla donde estuvo el error</returns>
        private int ValidarDatos(string avionAsignado, string duracion, DateTime fechaDeSalida, DateTime fechaDeLlegada, string origen, string destino)
        {
            int retorno = 6;
            this.btn_errorItemAvion.Visible = false;
            this.btn_errorDuracion.Visible = false;
            this.btn_errorFechaSalida.Visible = false;
            this.btn_errorFechaLlegada.Visible = false;
            this.btn_errorItemOrigen.Visible = false;
            this.btn_errorItemDestino.Visible = false;
            if (Validar.ValidarString(avionAsignado) == null)
            {
                retorno -= 1;
                
                this.btn_errorItemAvion.Visible = true;
            }
            if (Validar.ValidarStringSoloNumeros(duracion, 1) == null)
            {
                this.btn_errorDuracion.Visible = true;
                retorno -= 1;
            }
            if (DateTime.Compare(fechaDeSalida, DateTime.Now) < 0)
            {
                this.btn_errorFechaSalida.Visible = true;
                retorno -= 1;
            }
            if (fechaDeLlegada < DateTime.Now)
            {
                this.btn_errorFechaLlegada.Visible = true;
                retorno -= 1;
            }
            if (Validar.ValidarString(origen) == null)
            {
                retorno -= 1;
                this.btn_errorItemOrigen.Visible = true;
            }
            if (Validar.ValidarString(destino) == null)
            {
                retorno -= 1;
                this.btn_errorItemDestino.Visible = true;
            }
            return retorno;
        }
        private void btn_errorItemAvion_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button boton = (Button)sender;
            toolTip1.SetToolTip(boton, "¡Seleccione un item!");
        }
        private void btn_errorDuracion_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button boton = (Button)sender;
            toolTip1.SetToolTip(boton, "Seleccione el boton Calcular duracion");
        }
        private void btn_errorFechaSalida_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btn_errorFechaSalida, "La fecha seleccionada debe ser Mayor o igual a la actual");
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
            cmb_destino.Items.Add(ELugar.Trelew);
            cmb_destino.Items.Add(ELugar.Tucuman);
            cmb_destino.Items.Add(ELugar.Ushuaia);
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
            cmb_origen.Items.Add(ELugar.Trelew);
            cmb_origen.Items.Add(ELugar.Tucuman);
            cmb_origen.Items.Add(ELugar.Ushuaia);
        }
        private void LimpiarCampos()
        {
            btn_generarDuracion.Enabled = true;
            txt_duracionVuelo.Text = null;
            dtp_horaDeLlegada.Value = new DateTime(2022, 02, 02, 00, 00, 00);
            dtp_horaDeLlegada.Format = DateTimePickerFormat.Time;
        }

        private void chb_comida_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_comida.Checked == true)
            {
                this.comida = true;
            }
            else
            {
                this.comida = false;
            }
        }
        private void chb_wifi_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_wifi.Checked == true)
            {
                this.wifi = true;
            }
            else
            {
                this.comida = false;
            }
        }


    }
}
