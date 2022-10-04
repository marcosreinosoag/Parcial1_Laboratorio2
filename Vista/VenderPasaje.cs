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
        Aereonave avionAsignado;
        Vuelo vueloAsignado;
        int errorEquipajeCargado;
        List<Pasajero> auxPasajerosCargados;
        List<Equipaje> auxEquipajesCargados;
        Dictionary<Equipaje, Pasajero> auxEquipajesYPasajeros;
        int cantidadDePasajes;
        int indicePasajeroExistente;
        int contadorPasajero = 1;
        int cantidadPasajerosCargadosPremium = 0;
        int cantidadPasajerosCargadosTurista = 0;
        double precioFinalPasajes;
        bool equipajeManoCargado;
        bool equipajeBodega1Cargado;
        bool equipajeBodega2Cargado;
        public VenderPasaje(Aereonave avionAsignado, Vuelo vueloAsignado, int cantidadDePasajes)
        {
            this.vueloAsignado = vueloAsignado;
            this.cantidadDePasajes = cantidadDePasajes;
            this.avionAsignado = avionAsignado;
            InitializeComponent();
        }
        private void VenderPasaje_Load(object sender, EventArgs e)
        {
            auxPasajerosCargados = new List<Pasajero>();
            auxEquipajesCargados = new List<Equipaje>();
            auxEquipajesYPasajeros = new Dictionary<Equipaje, Pasajero>();
            btn_realizarPago.Visible = false;
            lbl_numeroPasajero.Text = $"Pasajero {contadorPasajero}";
            CargarAsientosDisponibles();
            cmb_numeroAsiento.SelectedIndex = 0;
        }
        private void btn_cargarPasajero_Click(object sender, EventArgs e)
        {
            lbl_error.Text = "";
            if (ValidarDatos(txb_nombre.Text, txb_apellido.Text, dtp_fechaNacimiento.Value) == 3 )
            {
                if (errorEquipajeCargado == 0)
                {
                    this.equipajeBodega1Cargado = false;
                    this.equipajeBodega2Cargado = false;
                    this.equipajeManoCargado = false;
                    int asientoAsignado = Validar.ConvertirStringAEntero(cmb_numeroAsiento.SelectedItem.ToString());
                    Pasajero auxPasajero;
                    if (indicePasajeroExistente == -1)
                    {
                        auxPasajero = new Pasajero(txb_nombre.Text, txb_apellido.Text, txb_dni.Text, dtp_fechaNacimiento.Value, asientoAsignado, 1);
                    }
                    else
                    {
                        auxPasajero = Volarg.listaHistorialPasajeros[indicePasajeroExistente];
                        auxPasajero.AsientoAsignado = asientoAsignado;
                        auxPasajero.ViajesRealizados = 1;
                    }
                    if (auxPasajero != null)
                    {
                        contadorPasajero += 1;
                        this.auxPasajerosCargados.Add(auxPasajero);
                        CargarPasajeroAListaAuxiliar(auxPasajero);
                        if (chx_clasePremium.Checked == true)
                        {
                            cantidadPasajerosCargadosPremium += 1;
                        }
                        else
                        {
                            cantidadPasajerosCargadosTurista += 1;
                        }
                        if (contadorPasajero > cantidadDePasajes)
                        {
                            btn_cargarPasajero.Visible = false;
                            btn_realizarPago.Visible = true;
                        }
                        else
                        {
                            lbl_numeroPasajero.Text = $"Pasajero {contadorPasajero}";
                            auxEquipajesCargados.Clear();
                            cmb_numeroAsiento.Items.RemoveAt(cmb_numeroAsiento.SelectedIndex);
                            LimpiarDatos();
                        }
                        cmb_numeroAsiento.Enabled = true;
                        CargarPasajeroEnLista();
                    }
                }
                else
                {
                    lbl_error.Visible = true;
                    lbl_error.Text = "Debe Completar la carga del equipaje para continuar";
                }
            }
        }
        private void CargarPasajeroAListaAuxiliar(Pasajero auxPasajero)
        {
            foreach (Equipaje item in auxEquipajesCargados)
            {
                if (item != null)
                {
                    auxEquipajesYPasajeros.Add(item, auxPasajero);
                }
            }
        }
        private void CargarAsientosDisponibles()
        {
            Pasajero[] pasajeros = avionAsignado.PasajerosEnAvion;
            for (int i = 0; i < pasajeros.Length; i++)
            {
                if (pasajeros[i] == null)
                {
                    cmb_numeroAsiento.Items.Add(i + 1);
                }
            }
        }
        private void cmb_numeroAsiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int asientosPremium = avionAsignado.CalcularCantidadDeAsientosPremium();
            int valorItemSeleccionado = Validar.ConvertirStringAEntero(cmb_numeroAsiento.SelectedItem.ToString());
            chx_clasePremium.Checked = false;
            chx_claseTurista.Checked = true;
            chb_equipaje2Bodega.Checked = false;
            if (valorItemSeleccionado <= asientosPremium)
            {
                chx_clasePremium.Checked = true;
                chx_claseTurista.Checked = false;
            }
        }
        private int ValidarDatos(string nombre, string apellido, DateTime fechaDeNacimiento)
        {
            int retorno = 3;
            this.btn_errorDni.Visible = false;
            this.btn_errorNombre.Visible = false;
            this.btn_errorApellido.Visible = false;
            this.btn_errorFechaNacimiento.Visible = false;
            if (Validar.ValidarStringSoloLetras(nombre) == null)
            {
                this.btn_errorNombre.Visible = true;
                retorno -= 1;
            }
            if (Validar.ValidarStringSoloLetras(apellido) == null)
            {
                this.btn_errorApellido.Visible = true;
                retorno -= 1;
            }
            int CalcularAnios = DateTime.Now.Year - fechaDeNacimiento.Year;
            if (CalcularAnios < 1)
            {
                this.btn_errorFechaNacimiento.Visible = true;
                retorno -= 1;
            }
            return retorno;
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btn_cargarEquipaje_Click(object sender, EventArgs e)
        {
            Equipaje auxEquipaje;
            double peso;
            double altura;
            double ancho;
            errorEquipajeCargado = 0;
            cmb_numeroAsiento.Enabled = false;
            if (chb_equipajeDeMano.Checked == true && equipajeManoCargado == false)
            {
                equipajeManoCargado = false;
                errorEquipajeCargado += 1;
                if (ValidarDatos(txb_color0.Text, txb_peso0.Text, txb_altura0.Text, txb_ancho0.Text, txb_descripcion0.Text, btn_errorColor0, btn_errorPeso0, btn_errorAltura0, btn_errorAncho0, btn_errorDescripcion0, chx_clasePremium.Checked) == 5)
                {
                    peso = Validar.ConvertirStringADouble(txb_peso0.Text);
                    altura = Validar.ConvertirStringADouble(txb_altura0.Text);
                    ancho = Validar.ConvertirStringADouble(txb_ancho0.Text);
                    auxEquipaje = new Equipaje(txb_color0.Text, peso, altura, ancho, true, txb_descripcion0.Text);
                    if (auxEquipaje != null)
                    {
                        equipajeManoCargado = true;
                        this.auxEquipajesCargados.Add(auxEquipaje);
                        auxEquipaje = null;
                        errorEquipajeCargado -= 1;
                    }
                }
            }
            if (chb_equipaje1Bodega.Checked == true && equipajeBodega1Cargado == false)
            {
                equipajeBodega1Cargado = false;
                errorEquipajeCargado += 1;
                if (ValidarDatos(txb_color1.Text, txb_peso1.Text, txb_altura1.Text, txb_ancho1.Text, txb_descripcion1.Text, btn_errorColor1, btn_errorPeso1, btn_errorAltura1, btn_errorAncho1, btn_errorDescripcion1, chx_clasePremium.Checked) == 5)
                {
                    peso = Validar.ConvertirStringADouble(txb_peso1.Text);
                    altura = Validar.ConvertirStringADouble(txb_altura1.Text);
                    ancho = Validar.ConvertirStringADouble(txb_ancho1.Text);
                    auxEquipaje = new Equipaje(txb_color1.Text, peso, altura, ancho, true, txb_descripcion1.Text);
                    if (auxEquipaje != null)
                    {
                        equipajeBodega1Cargado = true;
                        this.auxEquipajesCargados.Add(auxEquipaje);
                        auxEquipaje = null;
                        errorEquipajeCargado -= 1;
                    }
                }
            }
            if (chb_equipaje2Bodega.Checked == true && equipajeBodega2Cargado == false)
            {
                equipajeBodega2Cargado = false;
                errorEquipajeCargado += 1;
                if (ValidarDatos(txb_color2.Text, txb_peso2.Text, txb_altura2.Text, txb_ancho2.Text, txb_descripcion2.Text, btn_errorColor2, btn_errorPeso2, btn_errorAltura2, btn_errorAncho2, btn_errorDescripcion2, true) == 5)
                {
                    peso = Validar.ConvertirStringADouble(txb_peso2.Text);
                    altura = Validar.ConvertirStringADouble(txb_altura2.Text);
                    ancho = Validar.ConvertirStringADouble(txb_ancho2.Text);
                    auxEquipaje = new Equipaje(txb_color2.Text, peso, altura, ancho, true, txb_descripcion2.Text);
                    if (auxEquipaje != null)
                    {
                        equipajeBodega2Cargado = true;
                        this.auxEquipajesCargados.Add(auxEquipaje);
                        auxEquipaje = null;
                        errorEquipajeCargado -= 1;
                    }
                }
            }
        }
        private int ValidarDatos(string color, string peso, string altura, string ancho, string descripcion, Button btn_errorColor, Button btn_errorPeso, Button btn_errorAltura, Button btn_errorAncho, Button btn_errorDescripcion, bool clasePremium)
        {
            int retorno = 5;
            int pesoMaximo = 25;
            btn_errorPeso.Visible = false;
            btn_errorColor.Visible = false;
            btn_errorAltura.Visible = false;
            btn_errorAncho.Visible = false;
            btn_errorDescripcion.Visible = false;
            if (clasePremium == true)
            {
                pesoMaximo = 21;
            }

            if (Validar.ValidarStringSoloLetras(color) == null)
            {
                btn_errorColor.Visible = true;
                retorno -= 1;
            }
            if (Validar.ValidarStringSoloNumerosConComa(peso, 1, pesoMaximo) == null)
            {
                btn_errorPeso.Visible = true;
                retorno -= 1;
            }
            if (Validar.ValidarStringSoloNumerosConComa(altura, 1) == null)
            {
                btn_errorAltura.Visible = true;
                retorno -= 1;
            }
            if (Validar.ValidarStringSoloNumerosConComa(ancho, 1) == null)//a validar
            {
                btn_errorAncho.Visible = true;
                retorno -= 1;
            }
            if (Validar.ValidarStringSoloLetras(descripcion) == null)
            {
                btn_errorDescripcion.Visible = true;
                retorno -= 1;
            }
            return retorno;
        }
        private void chx_clasePremium_CheckedChanged(object sender, EventArgs e)
        {
            chb_equipaje2Bodega.Visible = false;
            if (chx_clasePremium.Checked == true)
            {
                chb_equipaje2Bodega.Visible = true;
            }
        }
        private void chb_equipaje1Bodega_CheckedChanged(object sender, EventArgs e)
        {
            gbx_equipajeBodega1.Visible = false;
            btn_cargarEquipaje.Visible = false;
            if (chb_equipaje1Bodega.Checked == true)
            {
                errorEquipajeCargado = 1;//////////////////por el visible no hace falta?
                gbx_equipajeBodega1.Visible = true;
                btn_cargarEquipaje.Visible = true;
            }
        }
        private void chb_equipaje2Bodega_CheckedChanged(object sender, EventArgs e)
        {
            gbx_equipajeBodega2.Visible = false;
            btn_cargarEquipaje.Visible = false;
            if (chb_equipaje2Bodega.Checked == true)
            {
                errorEquipajeCargado = 1;
                gbx_equipajeBodega2.Visible = true;
                btn_cargarEquipaje.Visible = true;
            }
        }
        private void chb_equipajeDeMano_CheckedChanged(object sender, EventArgs e)
        {
            gbx_equipajeMano.Visible = false;
            btn_cargarEquipaje.Visible = false;
            if (chb_equipajeDeMano.Checked == true)
            {
                gbx_equipajeMano.Visible = true;
                errorEquipajeCargado = 1;
                btn_cargarEquipaje.Visible = true;
            }
        }
        private void LimpiarDatos()
        {
            cmb_numeroAsiento.SelectedIndex = 0;
            chb_equipaje1Bodega.Checked = false;
            chb_equipaje2Bodega.Checked = false;
            chb_equipajeDeMano.Checked = false;
            txb_dni.Clear();
            txb_nombre.Clear();
            txb_apellido.Clear();
            dtp_fechaNacimiento.Value = DateTime.Now;
            txb_altura0.Clear();
            txb_altura1.Clear();
            txb_altura2.Clear();
            txb_ancho0.Clear();
            txb_ancho1.Clear();
            txb_ancho2.Clear();
            txb_color0.Clear();
            txb_color1.Clear();
            txb_color2.Clear();
            txb_descripcion0.Clear();
            txb_descripcion1.Clear();
            txb_descripcion2.Clear();
            txb_peso0.Clear();
            txb_peso1.Clear();
            txb_peso2.Clear();
        }
        public void CargarPasajeroEnLista()
        {
            double acumTotal = 0;
            lbx_pasajesCargados.Items.Clear();
            if (vueloAsignado.Comida == true || vueloAsignado.Wifi == true)
            {
                if (vueloAsignado.Comida == true)
                {
                    acumTotal += 500;
                }
                if (vueloAsignado.Wifi == true)
                {
                    acumTotal += 200;
                }
                lbx_pasajesCargados.Items.Add("- Costo Adicional Por Servicios: $ " + acumTotal);
            }
            if (cantidadPasajerosCargadosPremium > 0)
            {
                double valorPasajePremuim = CalcularValorPasaje(true, vueloAsignado.DuracionDelVuelo, chx_claseTurista.Checked);
                for (int i = 0; i < cantidadPasajerosCargadosPremium; i++)
                {
                    lbx_pasajesCargados.Items.Add("- Pasajero Pasaje Premium: $ " + valorPasajePremuim);
                    acumTotal += valorPasajePremuim;
                }
            }
            if (cantidadPasajerosCargadosTurista > 0)
            {
                double valorPasajeTurista = CalcularValorPasaje(false, vueloAsignado.DuracionDelVuelo, chx_claseTurista.Checked);
                for (int i = 0; i < cantidadPasajerosCargadosTurista; i++)
                {
                    lbx_pasajesCargados.Items.Add("- Pasajero Pasaje Turista: $ " + valorPasajeTurista);
                    acumTotal += valorPasajeTurista;
                }
            }
            double iva = CalcularIva(acumTotal);
            lbx_pasajesCargados.Items.Add("- iva: $ " + iva);
            acumTotal += iva;
            lbx_pasajesCargados.Items.Add("- TOTAL: $ " + acumTotal);
            precioFinalPasajes = acumTotal;
        }
        private double CalcularValorPasaje(bool internacional, double horasDeVuelo, bool claseTurista)
        {
            double valorfinal = 0;
            double porcentajeAdicional = 0;
            if (internacional == true)
            {
                valorfinal = horasDeVuelo * 100;
                if (claseTurista == false)
                {
                    porcentajeAdicional = valorfinal * 0.15;
                    return valorfinal + porcentajeAdicional;
                }
                return valorfinal;
            }
            valorfinal = horasDeVuelo * 50;
            if (claseTurista == false)
            {
                porcentajeAdicional = valorfinal * 0.15;
                return valorfinal + porcentajeAdicional;
            }
            return valorfinal;
        }
        private double CalcularIva(double precio)
        {
            double calcularPorcentaje;
            calcularPorcentaje = precio * 0.21;
            return calcularPorcentaje;
        }
        private void btn_realizarPago_Click(object sender, EventArgs e)
        {
            CobroPasajero frm_cobroPasajero = new CobroPasajero(precioFinalPasajes);
            DialogResult resultado = frm_cobroPasajero.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                CargarPasajeroEnhistorial(auxPasajerosCargados);
                avionAsignado.CargarPasajerosAlVuelo(auxPasajerosCargados);
                avionAsignado.CargarEquipajeAlVuelo(auxEquipajesYPasajeros);
                vueloAsignado.RecaudacionTotal = precioFinalPasajes;
                this.DialogResult = DialogResult.OK;
            }
        }
        private void CargarPasajeroEnhistorial(List<Pasajero> listaPasajeros)
        {
            int indicePasajeABuscar;
            foreach (Pasajero item in listaPasajeros)
            {
                if (item != null)
                {
                    indicePasajeABuscar = Volarg.BuscarIdEnListas(item.Dni);
                    if (indicePasajeABuscar == -1)
                    {
                        Volarg.CargarPasajeroEnHistorial(item);
                    }
                    else
                    {
                        Volarg.listaHistorialPasajeros[indicePasajeroExistente] = item;
                    }
                }
            }
        }
        private void btn_buscarPasajero_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = true;
            lbl_error.Text = "";
            if (Validar.ValidarStringSoloNumeros(txb_dni.Text, 1000000) == null)
            {
                this.btn_errorDni.Visible = true;
            }
            else
            {
                int indicePasajero = Volarg.BuscarIdEnListas(txb_dni.Text);
                bool estaEnVuelo = avionAsignado.BuscarIdEnArrayPasajeros(txb_dni.Text);
                if (estaEnVuelo)
                {
                    lbl_error.Text = "El pasajero ya se encuentra cargado en el vuelo";
                }
                else if (indicePasajero > -1)
                {
                    VisibilidadDeCamposPasajero(true);
                    AccesibilidadDeCamposPasajero(false);
                    txb_nombre.Text = Volarg.listaHistorialPasajeros[indicePasajero].Nombre;
                    txb_apellido.Text = Volarg.listaHistorialPasajeros[indicePasajero].Apellido;
                    dtp_fechaNacimiento.Value = Volarg.listaHistorialPasajeros[indicePasajero].FechaDeNacimiento;
                    indicePasajeroExistente = indicePasajero;
                }
                else
                {
                    VisibilidadDeCamposPasajero(true);
                    AccesibilidadDeCamposPasajero(true);
                    indicePasajeroExistente = indicePasajero;
                }
            }
        }
        private void VisibilidadDeCamposPasajero(bool esVisible)
        {
            if (esVisible)
            {
                txb_dni.Enabled = false;
                txb_nombre.Visible = true;
                txb_apellido.Visible = true;
                dtp_fechaNacimiento.Visible = true;
                btn_cargarPasajero.Visible = true;
                lbl_fechaNacimiento.Visible = true;
            }
            else
            {
                lbl_fechaNacimiento.Visible = false;
                txb_nombre.Visible = false;
                txb_apellido.Visible = false;
                dtp_fechaNacimiento.Visible = false;
                btn_cargarPasajero.Visible = false;
            }
        }
        private void AccesibilidadDeCamposPasajero(bool accesible)
        {
            if (accesible)
            {
                txb_nombre.Enabled = true;
                txb_apellido.Enabled = true;
                dtp_fechaNacimiento.Enabled = true;
            }
            else
            {
                txb_nombre.Enabled = false;
                txb_apellido.Enabled = false;
                dtp_fechaNacimiento.Enabled = false;
            }
        }

        private void btn_errorPeso0_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button btn_generico = (Button)sender;
            toolTip1.SetToolTip(btn_generico, "¡Si la clase es Premium el peso maximo es: 21 kg sino: 25 Kg!");
        }

        private void btn_errorAltura0_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button btn_generico = (Button)sender;
            toolTip1.SetToolTip(btn_generico, "¡El numero ingresado debe ser mayor a 1!");
        }

        private void btn_errorAncho0_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button btn_generico = (Button)sender;
            toolTip1.SetToolTip(btn_generico, "¡El numero ingresado debe ser mayor a 1!");
        }

        private void btn_errorColor0_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button btn_generico = (Button)sender;
            toolTip1.SetToolTip(btn_generico, "¡Debe ingresar unicamente letras!");
        }

        private void btn_errorDescripcion1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button btn_generico = (Button)sender;
            toolTip1.SetToolTip(btn_generico, "¡La descripcion no puede quedar en blanco!");
        }

        private void btn_errorDni_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button btn_generico = (Button)sender;
            toolTip1.SetToolTip(btn_generico, "¡Ingrese un numero mayor a 1000000!");
        }

        private void btn_errorNombre_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button btn_generico = (Button)sender;
            toolTip1.SetToolTip(btn_generico, "¡Ingrese unicamente letras!");
        }

        private void btn_errorFechaNacimiento_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            Button btn_generico = (Button)sender;
            toolTip1.SetToolTip(btn_generico, "¡La fecha de nacimiento debe ser menor a la actual!");
        }
    }
}
