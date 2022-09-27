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
    public partial class VenderPasaje : Form
    {
        Vuelo vueloSeleccionado;
        public VenderPasaje(Vuelo vueloSeleccionado)
        {
            this.vueloSeleccionado = vueloSeleccionado;
            InitializeComponent();
        }

        private void VenderPasaje_Load(object sender, EventArgs e)
        {
            txb_idVuelo.Text = vueloSeleccionado.AvionAsignado;
            txb_origen.Text = vueloSeleccionado.Origen.ToString();
            txb_destino.Text = vueloSeleccionado.Destino.ToString();
            chb_wifi.Checked = vueloSeleccionado.Wifi;
            chb_comida.Checked = vueloSeleccionado.Comida;
        }
    }
}
