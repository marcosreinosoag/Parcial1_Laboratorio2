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
    public partial class CobroPasajero : Form
    {
        double precioTotal;
        public CobroPasajero(double total)
        {
            this.precioTotal = total;
            InitializeComponent();
        }

        private void CobroPasajero_Load(object sender, EventArgs e)
        {
            rdb_efectivo.Checked = true;
            this.txb_totalCuenta.Text = "$" + precioTotal.ToString();
            this.txb_totalCuenta.Enabled = false;
            this.txb_tarjetaDeCredito.Visible = false;
            this.txb_mes.Visible = false;
            this.txb_anio.Visible = false;
            this.txb_codSeguridad.Visible = false;
            this.lbl_barra.Visible = false;
            this.lbl_codSeg.Visible = false;
            this.lbl_fechaVto.Visible = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void rdb_tajetaDeDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_tajetaDeDebito.Checked == true)
            {
                CargarDatosParaTarjeta();
            }
        }

        private void rdb_efectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_efectivo.Checked == true)
            {
                this.txb_totalCuenta.Text = "$" + precioTotal.ToString();
                this.txb_tarjetaDeCredito.Visible = false;
                this.txb_mes.Visible = false;
                this.txb_anio.Visible = false;
                this.txb_codSeguridad.Visible = false;
                this.lbl_barra.Visible = false;
                this.lbl_codSeg.Visible = false;
                this.lbl_fechaVto.Visible = false;
            }
        }
        private void rdb_tarjetaDeCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_tarjetaDeCredito.Checked == true)
            {
                CargarDatosParaTarjeta();
            }
        }
        private void CargarDatosParaTarjeta()
        {
            this.txb_totalCuenta.Text = "$" + precioTotal.ToString();
            this.txb_tarjetaDeCredito.Visible = true;
            this.txb_codSeguridad.Visible = true;
            this.lbl_barra.Visible = true;
            this.txb_mes.Visible = true;
            this.txb_anio.Visible = true;
            this.lbl_codSeg.Visible = true;
            this.lbl_fechaVto.Visible = true;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (rdb_efectivo.Checked == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (Validar.ValidarStringSoloNumeros(txb_tarjetaDeCredito.Text, 1) != null)
                {
                    if (Validar.ValidarStringSoloNumeros(txb_mes.Text, 1, 12) != null && Validar.ValidarStringSoloNumeros(txb_anio.Text, 1) != null)
                    {
                        if (Validar.ValidarStringSoloNumeros(txb_codSeguridad.Text, 1) != null)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Codigo de seguridad invalido");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Revisar la fecha de vencimiento");
                    }
                }
                else
                {
                    MessageBox.Show("Error! Reingrese la tarjeta");
                }
            }
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1-Debe cargar los datos correspondiente al la carga de tarjeta o efectivo \n2-seleccione el boton aceptar\n3-Si algun campo no fue completado correctamente se visualizara el boton de error, \n en el cual posando el mouse arriba le indicara que corregir");
        }
    }
}
