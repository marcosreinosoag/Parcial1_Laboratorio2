
namespace Vista
{
    partial class VenderPasaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VenderPasaje));
            this.btn_realizarPago = new System.Windows.Forms.Button();
            this.chx_clasePremium = new System.Windows.Forms.CheckBox();
            this.chx_claseTurista = new System.Windows.Forms.CheckBox();
            this.cmb_numeroAsiento = new System.Windows.Forms.ComboBox();
            this.lbl_numeroAsiento = new System.Windows.Forms.Label();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            this.dtp_fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.gbx_cargaPasajeros = new System.Windows.Forms.GroupBox();
            this.btn_buscarPasajero = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.chb_equipaje2Bodega = new System.Windows.Forms.CheckBox();
            this.lbl_numeroPasajero = new System.Windows.Forms.Label();
            this.chb_equipaje1Bodega = new System.Windows.Forms.CheckBox();
            this.chb_equipajeDeMano = new System.Windows.Forms.CheckBox();
            this.btn_errorFechaNacimiento = new System.Windows.Forms.Button();
            this.btn_errorApellido = new System.Windows.Forms.Button();
            this.btn_errorNombre = new System.Windows.Forms.Button();
            this.btn_errorDni = new System.Windows.Forms.Button();
            this.btn_cargarPasajero = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.gbx_equipajeMano = new System.Windows.Forms.GroupBox();
            this.btn_errorAncho0 = new System.Windows.Forms.Button();
            this.btn_errorDescripcion0 = new System.Windows.Forms.Button();
            this.btn_errorAltura0 = new System.Windows.Forms.Button();
            this.btn_errorPeso0 = new System.Windows.Forms.Button();
            this.btn_errorColor0 = new System.Windows.Forms.Button();
            this.txb_ancho0 = new System.Windows.Forms.TextBox();
            this.lbl_EquipajeMano = new System.Windows.Forms.Label();
            this.txb_color0 = new System.Windows.Forms.TextBox();
            this.txb_peso0 = new System.Windows.Forms.TextBox();
            this.txb_altura0 = new System.Windows.Forms.TextBox();
            this.txb_descripcion0 = new System.Windows.Forms.TextBox();
            this.bl_equipajeBodega = new System.Windows.Forms.Label();
            this.txb_descripcion1 = new System.Windows.Forms.TextBox();
            this.txb_ancho1 = new System.Windows.Forms.TextBox();
            this.txb_altura1 = new System.Windows.Forms.TextBox();
            this.txb_peso1 = new System.Windows.Forms.TextBox();
            this.txb_color1 = new System.Windows.Forms.TextBox();
            this.gbx_equipajeBodega1 = new System.Windows.Forms.GroupBox();
            this.btn_errorAltura1 = new System.Windows.Forms.Button();
            this.btn_errorColor1 = new System.Windows.Forms.Button();
            this.btn_errorDescripcion1 = new System.Windows.Forms.Button();
            this.btn_errorAncho1 = new System.Windows.Forms.Button();
            this.btn_errorPeso1 = new System.Windows.Forms.Button();
            this.gbx_equipajeBodega2 = new System.Windows.Forms.GroupBox();
            this.btn_errorAncho2 = new System.Windows.Forms.Button();
            this.btn_errorDescripcion2 = new System.Windows.Forms.Button();
            this.btn_errorPeso2 = new System.Windows.Forms.Button();
            this.btn_errorAltura2 = new System.Windows.Forms.Button();
            this.btn_errorColor2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_descripcion2 = new System.Windows.Forms.TextBox();
            this.txb_color2 = new System.Windows.Forms.TextBox();
            this.txb_ancho2 = new System.Windows.Forms.TextBox();
            this.txb_altura2 = new System.Windows.Forms.TextBox();
            this.txb_peso2 = new System.Windows.Forms.TextBox();
            this.btn_cargarEquipaje = new System.Windows.Forms.Button();
            this.lbx_pasajesCargados = new System.Windows.Forms.ListBox();
            this.btn_Info = new System.Windows.Forms.Button();
            this.gbx_cargaPasajeros.SuspendLayout();
            this.gbx_equipajeMano.SuspendLayout();
            this.gbx_equipajeBodega1.SuspendLayout();
            this.gbx_equipajeBodega2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_realizarPago
            // 
            this.btn_realizarPago.Location = new System.Drawing.Point(634, 506);
            this.btn_realizarPago.Name = "btn_realizarPago";
            this.btn_realizarPago.Size = new System.Drawing.Size(281, 29);
            this.btn_realizarPago.TabIndex = 3;
            this.btn_realizarPago.Text = "Realizar Pago";
            this.btn_realizarPago.UseVisualStyleBackColor = true;
            this.btn_realizarPago.Click += new System.EventHandler(this.btn_realizarPago_Click);
            // 
            // chx_clasePremium
            // 
            this.chx_clasePremium.AutoSize = true;
            this.chx_clasePremium.BackColor = System.Drawing.Color.Transparent;
            this.chx_clasePremium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chx_clasePremium.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chx_clasePremium.Enabled = false;
            this.chx_clasePremium.ForeColor = System.Drawing.Color.White;
            this.chx_clasePremium.Location = new System.Drawing.Point(18, 45);
            this.chx_clasePremium.Name = "chx_clasePremium";
            this.chx_clasePremium.Size = new System.Drawing.Size(106, 19);
            this.chx_clasePremium.TabIndex = 25;
            this.chx_clasePremium.Text = "Clase Premium";
            this.chx_clasePremium.UseVisualStyleBackColor = false;
            this.chx_clasePremium.CheckedChanged += new System.EventHandler(this.chx_clasePremium_CheckedChanged);
            // 
            // chx_claseTurista
            // 
            this.chx_claseTurista.AutoSize = true;
            this.chx_claseTurista.BackColor = System.Drawing.Color.Transparent;
            this.chx_claseTurista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chx_claseTurista.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chx_claseTurista.Enabled = false;
            this.chx_claseTurista.ForeColor = System.Drawing.Color.White;
            this.chx_claseTurista.Location = new System.Drawing.Point(295, 45);
            this.chx_claseTurista.Name = "chx_claseTurista";
            this.chx_claseTurista.Size = new System.Drawing.Size(92, 19);
            this.chx_claseTurista.TabIndex = 26;
            this.chx_claseTurista.Text = "Clase Turista";
            this.chx_claseTurista.UseVisualStyleBackColor = false;
            // 
            // cmb_numeroAsiento
            // 
            this.cmb_numeroAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_numeroAsiento.FormattingEnabled = true;
            this.cmb_numeroAsiento.Location = new System.Drawing.Point(95, 73);
            this.cmb_numeroAsiento.Name = "cmb_numeroAsiento";
            this.cmb_numeroAsiento.Size = new System.Drawing.Size(153, 23);
            this.cmb_numeroAsiento.TabIndex = 27;
            this.cmb_numeroAsiento.SelectedIndexChanged += new System.EventHandler(this.cmb_numeroAsiento_SelectedIndexChanged);
            // 
            // lbl_numeroAsiento
            // 
            this.lbl_numeroAsiento.AutoSize = true;
            this.lbl_numeroAsiento.ForeColor = System.Drawing.Color.White;
            this.lbl_numeroAsiento.Location = new System.Drawing.Point(6, 76);
            this.lbl_numeroAsiento.Name = "lbl_numeroAsiento";
            this.lbl_numeroAsiento.Size = new System.Drawing.Size(64, 15);
            this.lbl_numeroAsiento.TabIndex = 28;
            this.lbl_numeroAsiento.Text = "N° Asiento";
            // 
            // txb_dni
            // 
            this.txb_dni.Location = new System.Drawing.Point(44, 151);
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.PlaceholderText = "Ingrese Dni";
            this.txb_dni.Size = new System.Drawing.Size(347, 23);
            this.txb_dni.TabIndex = 33;
            // 
            // lbl_fechaNacimiento
            // 
            this.lbl_fechaNacimiento.AutoSize = true;
            this.lbl_fechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(14, 275);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(123, 15);
            this.lbl_fechaNacimiento.TabIndex = 32;
            this.lbl_fechaNacimiento.Text = "Fecha De Nacimiento:";
            this.lbl_fechaNacimiento.Visible = false;
            // 
            // dtp_fechaNacimiento
            // 
            this.dtp_fechaNacimiento.Location = new System.Drawing.Point(149, 267);
            this.dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            this.dtp_fechaNacimiento.Size = new System.Drawing.Size(242, 23);
            this.dtp_fechaNacimiento.TabIndex = 31;
            this.dtp_fechaNacimiento.Visible = false;
            // 
            // txb_apellido
            // 
            this.txb_apellido.Location = new System.Drawing.Point(15, 228);
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.PlaceholderText = "Ingrese Apellido";
            this.txb_apellido.Size = new System.Drawing.Size(376, 23);
            this.txb_apellido.TabIndex = 30;
            this.txb_apellido.Visible = false;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(15, 190);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PlaceholderText = "Ingrese Nombre";
            this.txb_nombre.Size = new System.Drawing.Size(376, 23);
            this.txb_nombre.TabIndex = 29;
            this.txb_nombre.Visible = false;
            // 
            // gbx_cargaPasajeros
            // 
            this.gbx_cargaPasajeros.BackColor = System.Drawing.Color.Black;
            this.gbx_cargaPasajeros.Controls.Add(this.btn_buscarPasajero);
            this.gbx_cargaPasajeros.Controls.Add(this.lbl_error);
            this.gbx_cargaPasajeros.Controls.Add(this.chb_equipaje2Bodega);
            this.gbx_cargaPasajeros.Controls.Add(this.lbl_numeroPasajero);
            this.gbx_cargaPasajeros.Controls.Add(this.chb_equipaje1Bodega);
            this.gbx_cargaPasajeros.Controls.Add(this.chb_equipajeDeMano);
            this.gbx_cargaPasajeros.Controls.Add(this.btn_errorFechaNacimiento);
            this.gbx_cargaPasajeros.Controls.Add(this.btn_errorApellido);
            this.gbx_cargaPasajeros.Controls.Add(this.btn_errorNombre);
            this.gbx_cargaPasajeros.Controls.Add(this.btn_errorDni);
            this.gbx_cargaPasajeros.Controls.Add(this.btn_cargarPasajero);
            this.gbx_cargaPasajeros.Controls.Add(this.txb_dni);
            this.gbx_cargaPasajeros.Controls.Add(this.lbl_fechaNacimiento);
            this.gbx_cargaPasajeros.Controls.Add(this.dtp_fechaNacimiento);
            this.gbx_cargaPasajeros.Controls.Add(this.txb_apellido);
            this.gbx_cargaPasajeros.Controls.Add(this.txb_nombre);
            this.gbx_cargaPasajeros.Controls.Add(this.lbl_numeroAsiento);
            this.gbx_cargaPasajeros.Controls.Add(this.cmb_numeroAsiento);
            this.gbx_cargaPasajeros.Controls.Add(this.chx_claseTurista);
            this.gbx_cargaPasajeros.Controls.Add(this.chx_clasePremium);
            this.gbx_cargaPasajeros.ForeColor = System.Drawing.Color.Black;
            this.gbx_cargaPasajeros.Location = new System.Drawing.Point(3, 0);
            this.gbx_cargaPasajeros.Name = "gbx_cargaPasajeros";
            this.gbx_cargaPasajeros.Size = new System.Drawing.Size(447, 379);
            this.gbx_cargaPasajeros.TabIndex = 34;
            this.gbx_cargaPasajeros.TabStop = false;
            // 
            // btn_buscarPasajero
            // 
            this.btn_buscarPasajero.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarPasajero.Image")));
            this.btn_buscarPasajero.Location = new System.Drawing.Point(6, 143);
            this.btn_buscarPasajero.Name = "btn_buscarPasajero";
            this.btn_buscarPasajero.Size = new System.Drawing.Size(32, 37);
            this.btn_buscarPasajero.TabIndex = 44;
            this.btn_buscarPasajero.UseVisualStyleBackColor = true;
            this.btn_buscarPasajero.Click += new System.EventHandler(this.btn_buscarPasajero_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(64, 350);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 15);
            this.lbl_error.TabIndex = 43;
            this.lbl_error.Visible = false;
            // 
            // chb_equipaje2Bodega
            // 
            this.chb_equipaje2Bodega.AutoSize = true;
            this.chb_equipaje2Bodega.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_equipaje2Bodega.ForeColor = System.Drawing.Color.White;
            this.chb_equipaje2Bodega.Location = new System.Drawing.Point(295, 109);
            this.chb_equipaje2Bodega.Name = "chb_equipaje2Bodega";
            this.chb_equipaje2Bodega.Size = new System.Drawing.Size(123, 19);
            this.chb_equipaje2Bodega.TabIndex = 42;
            this.chb_equipaje2Bodega.Text = "Equipaje 2 Bodega";
            this.chb_equipaje2Bodega.UseVisualStyleBackColor = true;
            this.chb_equipaje2Bodega.Visible = false;
            this.chb_equipaje2Bodega.CheckedChanged += new System.EventHandler(this.chb_equipaje2Bodega_CheckedChanged);
            // 
            // lbl_numeroPasajero
            // 
            this.lbl_numeroPasajero.AutoSize = true;
            this.lbl_numeroPasajero.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_numeroPasajero.ForeColor = System.Drawing.Color.White;
            this.lbl_numeroPasajero.Location = new System.Drawing.Point(173, 10);
            this.lbl_numeroPasajero.Name = "lbl_numeroPasajero";
            this.lbl_numeroPasajero.Size = new System.Drawing.Size(0, 20);
            this.lbl_numeroPasajero.TabIndex = 41;
            // 
            // chb_equipaje1Bodega
            // 
            this.chb_equipaje1Bodega.AutoSize = true;
            this.chb_equipaje1Bodega.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_equipaje1Bodega.ForeColor = System.Drawing.Color.White;
            this.chb_equipaje1Bodega.Location = new System.Drawing.Point(149, 109);
            this.chb_equipaje1Bodega.Name = "chb_equipaje1Bodega";
            this.chb_equipaje1Bodega.Size = new System.Drawing.Size(123, 19);
            this.chb_equipaje1Bodega.TabIndex = 40;
            this.chb_equipaje1Bodega.Text = "Equipaje 1 Bodega";
            this.chb_equipaje1Bodega.UseVisualStyleBackColor = true;
            this.chb_equipaje1Bodega.CheckedChanged += new System.EventHandler(this.chb_equipaje1Bodega_CheckedChanged);
            // 
            // chb_equipajeDeMano
            // 
            this.chb_equipajeDeMano.AutoSize = true;
            this.chb_equipajeDeMano.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_equipajeDeMano.ForeColor = System.Drawing.Color.White;
            this.chb_equipajeDeMano.Location = new System.Drawing.Point(6, 109);
            this.chb_equipajeDeMano.Name = "chb_equipajeDeMano";
            this.chb_equipajeDeMano.Size = new System.Drawing.Size(121, 19);
            this.chb_equipajeDeMano.TabIndex = 39;
            this.chb_equipajeDeMano.Text = "Equipaje de Mano";
            this.chb_equipajeDeMano.UseVisualStyleBackColor = true;
            this.chb_equipajeDeMano.CheckedChanged += new System.EventHandler(this.chb_equipajeDeMano_CheckedChanged);
            // 
            // btn_errorFechaNacimiento
            // 
            this.btn_errorFechaNacimiento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorFechaNacimiento.BackColor = System.Drawing.Color.Black;
            this.btn_errorFechaNacimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorFechaNacimiento.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorFechaNacimiento.Image")));
            this.btn_errorFechaNacimiento.Location = new System.Drawing.Point(401, 263);
            this.btn_errorFechaNacimiento.Name = "btn_errorFechaNacimiento";
            this.btn_errorFechaNacimiento.Size = new System.Drawing.Size(25, 27);
            this.btn_errorFechaNacimiento.TabIndex = 37;
            this.btn_errorFechaNacimiento.UseVisualStyleBackColor = false;
            this.btn_errorFechaNacimiento.Visible = false;
            this.btn_errorFechaNacimiento.MouseHover += new System.EventHandler(this.btn_errorFechaNacimiento_MouseHover);
            // 
            // btn_errorApellido
            // 
            this.btn_errorApellido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorApellido.BackColor = System.Drawing.Color.Black;
            this.btn_errorApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorApellido.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorApellido.Image")));
            this.btn_errorApellido.Location = new System.Drawing.Point(401, 224);
            this.btn_errorApellido.Name = "btn_errorApellido";
            this.btn_errorApellido.Size = new System.Drawing.Size(25, 28);
            this.btn_errorApellido.TabIndex = 36;
            this.btn_errorApellido.UseVisualStyleBackColor = false;
            this.btn_errorApellido.Visible = false;
            this.btn_errorApellido.MouseHover += new System.EventHandler(this.btn_errorNombre_MouseHover);
            // 
            // btn_errorNombre
            // 
            this.btn_errorNombre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorNombre.BackColor = System.Drawing.Color.Black;
            this.btn_errorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorNombre.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorNombre.Image")));
            this.btn_errorNombre.Location = new System.Drawing.Point(401, 190);
            this.btn_errorNombre.Name = "btn_errorNombre";
            this.btn_errorNombre.Size = new System.Drawing.Size(25, 28);
            this.btn_errorNombre.TabIndex = 36;
            this.btn_errorNombre.UseVisualStyleBackColor = false;
            this.btn_errorNombre.Visible = false;
            this.btn_errorNombre.MouseHover += new System.EventHandler(this.btn_errorNombre_MouseHover);
            // 
            // btn_errorDni
            // 
            this.btn_errorDni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorDni.BackColor = System.Drawing.Color.Black;
            this.btn_errorDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorDni.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorDni.Image")));
            this.btn_errorDni.Location = new System.Drawing.Point(401, 147);
            this.btn_errorDni.Name = "btn_errorDni";
            this.btn_errorDni.Size = new System.Drawing.Size(25, 28);
            this.btn_errorDni.TabIndex = 36;
            this.btn_errorDni.UseVisualStyleBackColor = false;
            this.btn_errorDni.Visible = false;
            this.btn_errorDni.MouseHover += new System.EventHandler(this.btn_errorDni_MouseHover);
            // 
            // btn_cargarPasajero
            // 
            this.btn_cargarPasajero.Location = new System.Drawing.Point(161, 317);
            this.btn_cargarPasajero.Name = "btn_cargarPasajero";
            this.btn_cargarPasajero.Size = new System.Drawing.Size(102, 22);
            this.btn_cargarPasajero.TabIndex = 34;
            this.btn_cargarPasajero.Text = "CargarPasajero";
            this.btn_cargarPasajero.UseVisualStyleBackColor = true;
            this.btn_cargarPasajero.Visible = false;
            this.btn_cargarPasajero.Click += new System.EventHandler(this.btn_cargarPasajero_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(12, 506);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(173, 29);
            this.btn_cancelar.TabIndex = 35;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // gbx_equipajeMano
            // 
            this.gbx_equipajeMano.Controls.Add(this.btn_errorAncho0);
            this.gbx_equipajeMano.Controls.Add(this.btn_errorDescripcion0);
            this.gbx_equipajeMano.Controls.Add(this.btn_errorAltura0);
            this.gbx_equipajeMano.Controls.Add(this.btn_errorPeso0);
            this.gbx_equipajeMano.Controls.Add(this.btn_errorColor0);
            this.gbx_equipajeMano.Controls.Add(this.txb_ancho0);
            this.gbx_equipajeMano.Controls.Add(this.lbl_EquipajeMano);
            this.gbx_equipajeMano.Controls.Add(this.txb_color0);
            this.gbx_equipajeMano.Controls.Add(this.txb_peso0);
            this.gbx_equipajeMano.Controls.Add(this.txb_altura0);
            this.gbx_equipajeMano.Controls.Add(this.txb_descripcion0);
            this.gbx_equipajeMano.Location = new System.Drawing.Point(456, 2);
            this.gbx_equipajeMano.Name = "gbx_equipajeMano";
            this.gbx_equipajeMano.Size = new System.Drawing.Size(468, 121);
            this.gbx_equipajeMano.TabIndex = 36;
            this.gbx_equipajeMano.TabStop = false;
            this.gbx_equipajeMano.Visible = false;
            // 
            // btn_errorAncho0
            // 
            this.btn_errorAncho0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorAncho0.BackColor = System.Drawing.Color.Black;
            this.btn_errorAncho0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorAncho0.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorAncho0.Image")));
            this.btn_errorAncho0.Location = new System.Drawing.Point(390, 34);
            this.btn_errorAncho0.Name = "btn_errorAncho0";
            this.btn_errorAncho0.Size = new System.Drawing.Size(25, 28);
            this.btn_errorAncho0.TabIndex = 56;
            this.btn_errorAncho0.UseVisualStyleBackColor = false;
            this.btn_errorAncho0.Visible = false;
            this.btn_errorAncho0.MouseHover += new System.EventHandler(this.btn_errorAncho0_MouseHover);
            // 
            // btn_errorDescripcion0
            // 
            this.btn_errorDescripcion0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorDescripcion0.BackColor = System.Drawing.Color.Black;
            this.btn_errorDescripcion0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorDescripcion0.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorDescripcion0.Image")));
            this.btn_errorDescripcion0.Location = new System.Drawing.Point(412, 71);
            this.btn_errorDescripcion0.Name = "btn_errorDescripcion0";
            this.btn_errorDescripcion0.Size = new System.Drawing.Size(25, 28);
            this.btn_errorDescripcion0.TabIndex = 55;
            this.btn_errorDescripcion0.UseVisualStyleBackColor = false;
            this.btn_errorDescripcion0.Visible = false;
            this.btn_errorDescripcion0.MouseHover += new System.EventHandler(this.btn_errorDescripcion1_MouseHover);
            // 
            // btn_errorAltura0
            // 
            this.btn_errorAltura0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorAltura0.BackColor = System.Drawing.Color.Black;
            this.btn_errorAltura0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorAltura0.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorAltura0.Image")));
            this.btn_errorAltura0.Location = new System.Drawing.Point(258, 34);
            this.btn_errorAltura0.Name = "btn_errorAltura0";
            this.btn_errorAltura0.Size = new System.Drawing.Size(25, 28);
            this.btn_errorAltura0.TabIndex = 49;
            this.btn_errorAltura0.UseVisualStyleBackColor = false;
            this.btn_errorAltura0.Visible = false;
            this.btn_errorAltura0.MouseHover += new System.EventHandler(this.btn_errorAltura0_MouseHover);
            // 
            // btn_errorPeso0
            // 
            this.btn_errorPeso0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorPeso0.BackColor = System.Drawing.Color.Black;
            this.btn_errorPeso0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorPeso0.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorPeso0.Image")));
            this.btn_errorPeso0.Location = new System.Drawing.Point(126, 34);
            this.btn_errorPeso0.Name = "btn_errorPeso0";
            this.btn_errorPeso0.Size = new System.Drawing.Size(25, 28);
            this.btn_errorPeso0.TabIndex = 48;
            this.btn_errorPeso0.UseVisualStyleBackColor = false;
            this.btn_errorPeso0.Visible = false;
            this.btn_errorPeso0.MouseHover += new System.EventHandler(this.btn_errorPeso0_MouseHover);
            // 
            // btn_errorColor0
            // 
            this.btn_errorColor0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorColor0.BackColor = System.Drawing.Color.Black;
            this.btn_errorColor0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorColor0.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorColor0.Image")));
            this.btn_errorColor0.Location = new System.Drawing.Point(156, 72);
            this.btn_errorColor0.Name = "btn_errorColor0";
            this.btn_errorColor0.Size = new System.Drawing.Size(25, 28);
            this.btn_errorColor0.TabIndex = 42;
            this.btn_errorColor0.UseVisualStyleBackColor = false;
            this.btn_errorColor0.Visible = false;
            this.btn_errorColor0.MouseHover += new System.EventHandler(this.btn_errorColor0_MouseHover);
            // 
            // txb_ancho0
            // 
            this.txb_ancho0.Location = new System.Drawing.Point(289, 38);
            this.txb_ancho0.Name = "txb_ancho0";
            this.txb_ancho0.PlaceholderText = "Ingrese Ancho";
            this.txb_ancho0.Size = new System.Drawing.Size(95, 23);
            this.txb_ancho0.TabIndex = 39;
            // 
            // lbl_EquipajeMano
            // 
            this.lbl_EquipajeMano.AutoSize = true;
            this.lbl_EquipajeMano.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EquipajeMano.ForeColor = System.Drawing.Color.White;
            this.lbl_EquipajeMano.Location = new System.Drawing.Point(166, 10);
            this.lbl_EquipajeMano.Name = "lbl_EquipajeMano";
            this.lbl_EquipajeMano.Size = new System.Drawing.Size(138, 20);
            this.lbl_EquipajeMano.TabIndex = 47;
            this.lbl_EquipajeMano.Text = "Equipaje De Mano";
            // 
            // txb_color0
            // 
            this.txb_color0.Location = new System.Drawing.Point(14, 76);
            this.txb_color0.Name = "txb_color0";
            this.txb_color0.PlaceholderText = "Ingrese Color";
            this.txb_color0.Size = new System.Drawing.Size(136, 23);
            this.txb_color0.TabIndex = 37;
            // 
            // txb_peso0
            // 
            this.txb_peso0.Location = new System.Drawing.Point(14, 38);
            this.txb_peso0.Name = "txb_peso0";
            this.txb_peso0.PlaceholderText = "Ingrese Peso";
            this.txb_peso0.Size = new System.Drawing.Size(95, 23);
            this.txb_peso0.TabIndex = 40;
            // 
            // txb_altura0
            // 
            this.txb_altura0.Location = new System.Drawing.Point(157, 38);
            this.txb_altura0.Name = "txb_altura0";
            this.txb_altura0.PlaceholderText = "Ingrese Altura";
            this.txb_altura0.Size = new System.Drawing.Size(95, 23);
            this.txb_altura0.TabIndex = 38;
            // 
            // txb_descripcion0
            // 
            this.txb_descripcion0.Location = new System.Drawing.Point(187, 76);
            this.txb_descripcion0.Name = "txb_descripcion0";
            this.txb_descripcion0.PlaceholderText = "Ingrese Descripcion";
            this.txb_descripcion0.Size = new System.Drawing.Size(219, 23);
            this.txb_descripcion0.TabIndex = 41;
            // 
            // bl_equipajeBodega
            // 
            this.bl_equipajeBodega.AutoSize = true;
            this.bl_equipajeBodega.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bl_equipajeBodega.ForeColor = System.Drawing.Color.White;
            this.bl_equipajeBodega.Location = new System.Drawing.Point(167, 10);
            this.bl_equipajeBodega.Name = "bl_equipajeBodega";
            this.bl_equipajeBodega.Size = new System.Drawing.Size(141, 20);
            this.bl_equipajeBodega.TabIndex = 48;
            this.bl_equipajeBodega.Text = "Equipaje 1 Bodega";
            // 
            // txb_descripcion1
            // 
            this.txb_descripcion1.Location = new System.Drawing.Point(188, 77);
            this.txb_descripcion1.Name = "txb_descripcion1";
            this.txb_descripcion1.PlaceholderText = "Ingrese Descripcion";
            this.txb_descripcion1.Size = new System.Drawing.Size(219, 23);
            this.txb_descripcion1.TabIndex = 46;
            // 
            // txb_ancho1
            // 
            this.txb_ancho1.Location = new System.Drawing.Point(289, 37);
            this.txb_ancho1.Name = "txb_ancho1";
            this.txb_ancho1.PlaceholderText = "Ingrese Ancho";
            this.txb_ancho1.Size = new System.Drawing.Size(95, 23);
            this.txb_ancho1.TabIndex = 45;
            // 
            // txb_altura1
            // 
            this.txb_altura1.Location = new System.Drawing.Point(157, 37);
            this.txb_altura1.Name = "txb_altura1";
            this.txb_altura1.PlaceholderText = "Ingrese Altura";
            this.txb_altura1.Size = new System.Drawing.Size(95, 23);
            this.txb_altura1.TabIndex = 44;
            // 
            // txb_peso1
            // 
            this.txb_peso1.Location = new System.Drawing.Point(15, 36);
            this.txb_peso1.Name = "txb_peso1";
            this.txb_peso1.PlaceholderText = "Ingrese Peso";
            this.txb_peso1.Size = new System.Drawing.Size(94, 23);
            this.txb_peso1.TabIndex = 43;
            // 
            // txb_color1
            // 
            this.txb_color1.Location = new System.Drawing.Point(13, 76);
            this.txb_color1.Name = "txb_color1";
            this.txb_color1.PlaceholderText = "Ingrese Color";
            this.txb_color1.Size = new System.Drawing.Size(137, 23);
            this.txb_color1.TabIndex = 42;
            // 
            // gbx_equipajeBodega1
            // 
            this.gbx_equipajeBodega1.Controls.Add(this.bl_equipajeBodega);
            this.gbx_equipajeBodega1.Controls.Add(this.txb_descripcion1);
            this.gbx_equipajeBodega1.Controls.Add(this.btn_errorAltura1);
            this.gbx_equipajeBodega1.Controls.Add(this.btn_errorColor1);
            this.gbx_equipajeBodega1.Controls.Add(this.btn_errorDescripcion1);
            this.gbx_equipajeBodega1.Controls.Add(this.btn_errorAncho1);
            this.gbx_equipajeBodega1.Controls.Add(this.btn_errorPeso1);
            this.gbx_equipajeBodega1.Controls.Add(this.txb_ancho1);
            this.gbx_equipajeBodega1.Controls.Add(this.txb_altura1);
            this.gbx_equipajeBodega1.Controls.Add(this.txb_peso1);
            this.gbx_equipajeBodega1.Controls.Add(this.txb_color1);
            this.gbx_equipajeBodega1.Location = new System.Drawing.Point(456, 129);
            this.gbx_equipajeBodega1.Name = "gbx_equipajeBodega1";
            this.gbx_equipajeBodega1.Size = new System.Drawing.Size(468, 123);
            this.gbx_equipajeBodega1.TabIndex = 49;
            this.gbx_equipajeBodega1.TabStop = false;
            this.gbx_equipajeBodega1.Visible = false;
            // 
            // btn_errorAltura1
            // 
            this.btn_errorAltura1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorAltura1.BackColor = System.Drawing.Color.Black;
            this.btn_errorAltura1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorAltura1.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorAltura1.Image")));
            this.btn_errorAltura1.Location = new System.Drawing.Point(258, 33);
            this.btn_errorAltura1.Name = "btn_errorAltura1";
            this.btn_errorAltura1.Size = new System.Drawing.Size(25, 28);
            this.btn_errorAltura1.TabIndex = 50;
            this.btn_errorAltura1.UseVisualStyleBackColor = false;
            this.btn_errorAltura1.Visible = false;
            this.btn_errorAltura1.MouseHover += new System.EventHandler(this.btn_errorAltura0_MouseHover);
            // 
            // btn_errorColor1
            // 
            this.btn_errorColor1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorColor1.BackColor = System.Drawing.Color.Black;
            this.btn_errorColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorColor1.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorColor1.Image")));
            this.btn_errorColor1.Location = new System.Drawing.Point(157, 73);
            this.btn_errorColor1.Name = "btn_errorColor1";
            this.btn_errorColor1.Size = new System.Drawing.Size(25, 28);
            this.btn_errorColor1.TabIndex = 51;
            this.btn_errorColor1.UseVisualStyleBackColor = false;
            this.btn_errorColor1.Visible = false;
            this.btn_errorColor1.MouseHover += new System.EventHandler(this.btn_errorColor0_MouseHover);
            // 
            // btn_errorDescripcion1
            // 
            this.btn_errorDescripcion1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorDescripcion1.BackColor = System.Drawing.Color.Black;
            this.btn_errorDescripcion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorDescripcion1.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorDescripcion1.Image")));
            this.btn_errorDescripcion1.Location = new System.Drawing.Point(413, 73);
            this.btn_errorDescripcion1.Name = "btn_errorDescripcion1";
            this.btn_errorDescripcion1.Size = new System.Drawing.Size(25, 28);
            this.btn_errorDescripcion1.TabIndex = 52;
            this.btn_errorDescripcion1.UseVisualStyleBackColor = false;
            this.btn_errorDescripcion1.Visible = false;
            this.btn_errorDescripcion1.MouseHover += new System.EventHandler(this.btn_errorDescripcion1_MouseHover);
            // 
            // btn_errorAncho1
            // 
            this.btn_errorAncho1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorAncho1.BackColor = System.Drawing.Color.Black;
            this.btn_errorAncho1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorAncho1.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorAncho1.Image")));
            this.btn_errorAncho1.Location = new System.Drawing.Point(390, 33);
            this.btn_errorAncho1.Name = "btn_errorAncho1";
            this.btn_errorAncho1.Size = new System.Drawing.Size(25, 28);
            this.btn_errorAncho1.TabIndex = 53;
            this.btn_errorAncho1.UseVisualStyleBackColor = false;
            this.btn_errorAncho1.Visible = false;
            this.btn_errorAncho1.MouseHover += new System.EventHandler(this.btn_errorAncho0_MouseHover);
            // 
            // btn_errorPeso1
            // 
            this.btn_errorPeso1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorPeso1.BackColor = System.Drawing.Color.Black;
            this.btn_errorPeso1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorPeso1.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorPeso1.Image")));
            this.btn_errorPeso1.Location = new System.Drawing.Point(125, 32);
            this.btn_errorPeso1.Name = "btn_errorPeso1";
            this.btn_errorPeso1.Size = new System.Drawing.Size(25, 28);
            this.btn_errorPeso1.TabIndex = 54;
            this.btn_errorPeso1.UseVisualStyleBackColor = false;
            this.btn_errorPeso1.Visible = false;
            this.btn_errorPeso1.MouseHover += new System.EventHandler(this.btn_errorPeso0_MouseHover);
            // 
            // gbx_equipajeBodega2
            // 
            this.gbx_equipajeBodega2.Controls.Add(this.btn_errorAncho2);
            this.gbx_equipajeBodega2.Controls.Add(this.btn_errorDescripcion2);
            this.gbx_equipajeBodega2.Controls.Add(this.btn_errorPeso2);
            this.gbx_equipajeBodega2.Controls.Add(this.btn_errorAltura2);
            this.gbx_equipajeBodega2.Controls.Add(this.btn_errorColor2);
            this.gbx_equipajeBodega2.Controls.Add(this.label4);
            this.gbx_equipajeBodega2.Controls.Add(this.txb_descripcion2);
            this.gbx_equipajeBodega2.Controls.Add(this.txb_color2);
            this.gbx_equipajeBodega2.Controls.Add(this.txb_ancho2);
            this.gbx_equipajeBodega2.Controls.Add(this.txb_altura2);
            this.gbx_equipajeBodega2.Controls.Add(this.txb_peso2);
            this.gbx_equipajeBodega2.Location = new System.Drawing.Point(456, 258);
            this.gbx_equipajeBodega2.Name = "gbx_equipajeBodega2";
            this.gbx_equipajeBodega2.Size = new System.Drawing.Size(468, 121);
            this.gbx_equipajeBodega2.TabIndex = 55;
            this.gbx_equipajeBodega2.TabStop = false;
            this.gbx_equipajeBodega2.Visible = false;
            // 
            // btn_errorAncho2
            // 
            this.btn_errorAncho2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorAncho2.BackColor = System.Drawing.Color.Black;
            this.btn_errorAncho2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorAncho2.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorAncho2.Image")));
            this.btn_errorAncho2.Location = new System.Drawing.Point(390, 34);
            this.btn_errorAncho2.Name = "btn_errorAncho2";
            this.btn_errorAncho2.Size = new System.Drawing.Size(25, 28);
            this.btn_errorAncho2.TabIndex = 59;
            this.btn_errorAncho2.UseVisualStyleBackColor = false;
            this.btn_errorAncho2.Visible = false;
            this.btn_errorAncho2.MouseHover += new System.EventHandler(this.btn_errorAncho0_MouseHover);
            // 
            // btn_errorDescripcion2
            // 
            this.btn_errorDescripcion2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorDescripcion2.BackColor = System.Drawing.Color.Black;
            this.btn_errorDescripcion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorDescripcion2.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorDescripcion2.Image")));
            this.btn_errorDescripcion2.Location = new System.Drawing.Point(413, 80);
            this.btn_errorDescripcion2.Name = "btn_errorDescripcion2";
            this.btn_errorDescripcion2.Size = new System.Drawing.Size(25, 28);
            this.btn_errorDescripcion2.TabIndex = 58;
            this.btn_errorDescripcion2.UseVisualStyleBackColor = false;
            this.btn_errorDescripcion2.Visible = false;
            this.btn_errorDescripcion2.MouseHover += new System.EventHandler(this.btn_errorDescripcion1_MouseHover);
            // 
            // btn_errorPeso2
            // 
            this.btn_errorPeso2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorPeso2.BackColor = System.Drawing.Color.Black;
            this.btn_errorPeso2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorPeso2.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorPeso2.Image")));
            this.btn_errorPeso2.Location = new System.Drawing.Point(119, 35);
            this.btn_errorPeso2.Name = "btn_errorPeso2";
            this.btn_errorPeso2.Size = new System.Drawing.Size(25, 28);
            this.btn_errorPeso2.TabIndex = 57;
            this.btn_errorPeso2.UseVisualStyleBackColor = false;
            this.btn_errorPeso2.Visible = false;
            this.btn_errorPeso2.MouseHover += new System.EventHandler(this.btn_errorPeso0_MouseHover);
            // 
            // btn_errorAltura2
            // 
            this.btn_errorAltura2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorAltura2.BackColor = System.Drawing.Color.Black;
            this.btn_errorAltura2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorAltura2.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorAltura2.Image")));
            this.btn_errorAltura2.Location = new System.Drawing.Point(258, 35);
            this.btn_errorAltura2.Name = "btn_errorAltura2";
            this.btn_errorAltura2.Size = new System.Drawing.Size(25, 28);
            this.btn_errorAltura2.TabIndex = 55;
            this.btn_errorAltura2.UseVisualStyleBackColor = false;
            this.btn_errorAltura2.Visible = false;
            this.btn_errorAltura2.MouseHover += new System.EventHandler(this.btn_errorAltura0_MouseHover);
            // 
            // btn_errorColor2
            // 
            this.btn_errorColor2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorColor2.BackColor = System.Drawing.Color.Black;
            this.btn_errorColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorColor2.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorColor2.Image")));
            this.btn_errorColor2.Location = new System.Drawing.Point(156, 82);
            this.btn_errorColor2.Name = "btn_errorColor2";
            this.btn_errorColor2.Size = new System.Drawing.Size(25, 28);
            this.btn_errorColor2.TabIndex = 56;
            this.btn_errorColor2.UseVisualStyleBackColor = false;
            this.btn_errorColor2.Visible = false;
            this.btn_errorColor2.MouseHover += new System.EventHandler(this.btn_errorColor0_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(167, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Equipaje 2 Bodega";
            // 
            // txb_descripcion2
            // 
            this.txb_descripcion2.Location = new System.Drawing.Point(187, 86);
            this.txb_descripcion2.Name = "txb_descripcion2";
            this.txb_descripcion2.PlaceholderText = "Ingrese Descripcion";
            this.txb_descripcion2.Size = new System.Drawing.Size(219, 23);
            this.txb_descripcion2.TabIndex = 4;
            // 
            // txb_color2
            // 
            this.txb_color2.Location = new System.Drawing.Point(14, 86);
            this.txb_color2.Name = "txb_color2";
            this.txb_color2.PlaceholderText = "Ingrese Color";
            this.txb_color2.Size = new System.Drawing.Size(137, 23);
            this.txb_color2.TabIndex = 3;
            // 
            // txb_ancho2
            // 
            this.txb_ancho2.Location = new System.Drawing.Point(289, 39);
            this.txb_ancho2.Name = "txb_ancho2";
            this.txb_ancho2.PlaceholderText = "Ingrese Ancho";
            this.txb_ancho2.Size = new System.Drawing.Size(95, 23);
            this.txb_ancho2.TabIndex = 2;
            // 
            // txb_altura2
            // 
            this.txb_altura2.Location = new System.Drawing.Point(157, 39);
            this.txb_altura2.Name = "txb_altura2";
            this.txb_altura2.PlaceholderText = "Ingrese Altura";
            this.txb_altura2.Size = new System.Drawing.Size(95, 23);
            this.txb_altura2.TabIndex = 1;
            // 
            // txb_peso2
            // 
            this.txb_peso2.Location = new System.Drawing.Point(13, 39);
            this.txb_peso2.Name = "txb_peso2";
            this.txb_peso2.PlaceholderText = "Ingrese Peso";
            this.txb_peso2.Size = new System.Drawing.Size(100, 23);
            this.txb_peso2.TabIndex = 0;
            // 
            // btn_cargarEquipaje
            // 
            this.btn_cargarEquipaje.Location = new System.Drawing.Point(601, 385);
            this.btn_cargarEquipaje.Name = "btn_cargarEquipaje";
            this.btn_cargarEquipaje.Size = new System.Drawing.Size(202, 23);
            this.btn_cargarEquipaje.TabIndex = 56;
            this.btn_cargarEquipaje.Text = "Cargar Equipaje";
            this.btn_cargarEquipaje.UseVisualStyleBackColor = true;
            this.btn_cargarEquipaje.Visible = false;
            this.btn_cargarEquipaje.Click += new System.EventHandler(this.btn_cargarEquipaje_Click);
            // 
            // lbx_pasajesCargados
            // 
            this.lbx_pasajesCargados.FormattingEnabled = true;
            this.lbx_pasajesCargados.ItemHeight = 15;
            this.lbx_pasajesCargados.Location = new System.Drawing.Point(12, 396);
            this.lbx_pasajesCargados.Name = "lbx_pasajesCargados";
            this.lbx_pasajesCargados.Size = new System.Drawing.Size(542, 94);
            this.lbx_pasajesCargados.TabIndex = 57;
            // 
            // btn_Info
            // 
            this.btn_Info.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Info.BackColor = System.Drawing.Color.Transparent;
            this.btn_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Info.BackgroundImage")));
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Info.Location = new System.Drawing.Point(880, 396);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(35, 35);
            this.btn_Info.TabIndex = 58;
            this.btn_Info.UseVisualStyleBackColor = false;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // VenderPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(927, 552);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.lbx_pasajesCargados);
            this.Controls.Add(this.btn_cargarEquipaje);
            this.Controls.Add(this.gbx_equipajeBodega2);
            this.Controls.Add(this.gbx_equipajeBodega1);
            this.Controls.Add(this.gbx_equipajeMano);
            this.Controls.Add(this.gbx_cargaPasajeros);
            this.Controls.Add(this.btn_realizarPago);
            this.Controls.Add(this.btn_cancelar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "VenderPasaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuelo";
            this.Load += new System.EventHandler(this.VenderPasaje_Load);
            this.gbx_cargaPasajeros.ResumeLayout(false);
            this.gbx_cargaPasajeros.PerformLayout();
            this.gbx_equipajeMano.ResumeLayout(false);
            this.gbx_equipajeMano.PerformLayout();
            this.gbx_equipajeBodega1.ResumeLayout(false);
            this.gbx_equipajeBodega1.PerformLayout();
            this.gbx_equipajeBodega2.ResumeLayout(false);
            this.gbx_equipajeBodega2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_realizarPago;
        private System.Windows.Forms.CheckBox chx_clasePremium;
        private System.Windows.Forms.CheckBox chx_claseTurista;
        private System.Windows.Forms.ComboBox cmb_numeroAsiento;
        private System.Windows.Forms.Label lbl_numeroAsiento;
        private System.Windows.Forms.TextBox txb_dni;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtp_fechaNacimiento;
        private System.Windows.Forms.TextBox txb_apellido;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.GroupBox gbx_cargaPasajeros;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cargarPasajero;
        private System.Windows.Forms.Button btn_errorFechaNacimiento;
        private System.Windows.Forms.Button btn_errorApellido;
        private System.Windows.Forms.Button btn_errorNombre;
        private System.Windows.Forms.Button btn_errorDni;
        private System.Windows.Forms.Label lbl_numeroPasajero;
        private System.Windows.Forms.CheckBox chb_equipaje1Bodega;
        private System.Windows.Forms.CheckBox chb_equipajeDeMano;
        private System.Windows.Forms.GroupBox gbx_equipajeMano;
        private System.Windows.Forms.TextBox txb_ancho0;
        private System.Windows.Forms.Label lbl_EquipajeMano;
        private System.Windows.Forms.TextBox txb_color0;
        private System.Windows.Forms.TextBox txb_peso0;
        private System.Windows.Forms.TextBox txb_altura0;
        private System.Windows.Forms.TextBox txb_descripcion0;
        private System.Windows.Forms.Label bl_equipajeBodega;
        private System.Windows.Forms.TextBox txb_descripcion1;
        private System.Windows.Forms.TextBox txb_ancho1;
        private System.Windows.Forms.TextBox txb_altura1;
        private System.Windows.Forms.TextBox txb_peso1;
        private System.Windows.Forms.TextBox txb_color1;
        private System.Windows.Forms.GroupBox gbx_equipajeBodega1;
        private System.Windows.Forms.Button btn_errorPeso0;
        private System.Windows.Forms.Button btn_errorColor0;
        private System.Windows.Forms.Button btn_errorAncho0;
        private System.Windows.Forms.Button btn_errorDescripcion0;
        private System.Windows.Forms.Button btn_errorAltura0;
        private System.Windows.Forms.Button btn_errorAltura1;
        private System.Windows.Forms.Button btn_errorColor1;
        private System.Windows.Forms.Button btn_errorDescripcion1;
        private System.Windows.Forms.Button btn_errorAncho1;
        private System.Windows.Forms.Button btn_errorPeso1;
        private System.Windows.Forms.GroupBox gbx_equipajeBodega2;
        private System.Windows.Forms.CheckBox chb_equipaje2Bodega;
        private System.Windows.Forms.Button btn_errorAncho2;
        private System.Windows.Forms.Button btn_errorDescripcion2;
        private System.Windows.Forms.Button btn_errorPeso2;
        private System.Windows.Forms.Button btn_errorAltura2;
        private System.Windows.Forms.Button btn_errorColor2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_descripcion2;
        private System.Windows.Forms.TextBox txb_color2;
        private System.Windows.Forms.TextBox txb_ancho2;
        private System.Windows.Forms.TextBox txb_altura2;
        private System.Windows.Forms.TextBox txb_peso2;
        private System.Windows.Forms.Button btn_cargarEquipaje;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.ListBox lbx_pasajesCargados;
        private System.Windows.Forms.Button btn_buscarPasajero;
        private System.Windows.Forms.Button btn_Info;
    }
}