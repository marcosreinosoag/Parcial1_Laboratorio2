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
            dtg_informacion.DataSource = Volarg.listaDeVuelos;
        }
        private void btn_crearVuelo_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            CrearVuelo frm_agregarVuelo = new CrearVuelo();
            resultado = frm_agregarVuelo.ShowDialog();
            if (resultado == DialogResult.OK)
            {

            }
        }
        private void btn_vendedores_Click(object sender, EventArgs e)
        {
            dtg_informacion.DataSource = Volarg.listaDeVendedores;
        }
        private void btn_vuelos_Click(object sender, EventArgs e)
        {
            dtg_informacion.DataSource = Volarg.listaDeVuelos;
        }
        private void dtg_informacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dtg_informacion.CurrentCell.RowIndex;
            VenderPasaje frm_venderPasaje = new VenderPasaje(Volarg.listaDeVuelos[indice]);
            DialogResult resultado = frm_venderPasaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //if (auxMesa[this.indiceDeMesa].Ocupada == false)//funcion
                //{
                //    pedidos = new List<Consumo>();
                //    Bar.CargarMesa(this.indiceDeMesa, pedidos);
                //    MenuPrincipal.estadoMesas();
                //}
                //cantidad = frm_ingresoDeCantidad.CantidadIngresada;
                //if (cantidad > 0)
                //{
                //    for (int i = 0; i < cantidad; i++)
                //    {
                //        this.pedidos.Add(nuevoConsumo);
                //    }
                //    CargarListaPedidosEnLista();
                //    auxMesa[this.indiceDeMesa].Pedidos = this.pedidos;
                //}
            }
        }
    }
}
