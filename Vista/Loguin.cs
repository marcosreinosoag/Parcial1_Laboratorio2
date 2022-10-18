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
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado;
            string claveIngresada;
            usuarioIngresado = txb_usuario.Text;
            claveIngresada = txb_clave.Text;
            if (Volarg.VerificarUsuarioYClave(usuarioIngresado, claveIngresada))
            {
                string nombreDelVendedor = Volarg.DevolverNombreVendedor(usuarioIngresado);
                MenuPrincipal frm_menuPrincipal = new MenuPrincipal(nombreDelVendedor, Volarg.DevolverVandedorPorUsuario(usuarioIngresado));
                frm_menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                lbl_error.Text = "Datos Incorrectos";
            }
        }
        private void btn_autocompletar_Click(object sender, EventArgs e)
        {
            txb_usuario.Text = "40333444";
            txb_clave.Text = "123";
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1-Debe cargar los datos correspondiente al Vendedor \n2-aprete el boton ingresar\n3-Si algun campo no fue completado correctamente se visualizara un mensaje de error");
        }
    }
}
