
namespace Vista
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.mnt_MenuPricipal = new System.Windows.Forms.MenuStrip();
            this.bmt_vendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.bmt_vuelos = new System.Windows.Forms.ToolStripMenuItem();
            this.bmt_crearVuelo = new System.Windows.Forms.ToolStripMenuItem();
            this.bmt_aviones = new System.Windows.Forms.ToolStripMenuItem();
            this.bmt_estadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.bmt_listaDestinos = new System.Windows.Forms.ToolStripMenuItem();
            this.bmt_listaPasajerosFrecuentes = new System.Windows.Forms.ToolStripMenuItem();
            this.bmt_gananciasTotales = new System.Windows.Forms.ToolStripMenuItem();
            this.bmt_listaAereonaves = new System.Windows.Forms.ToolStripMenuItem();
            this.bmt_listaVendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dtg_infoGeneral = new System.Windows.Forms.DataGridView();
            this.btn_vendedorMasPasajesVendidos = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_pasajeroMasViajes = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.lbl_recaudacionTotal = new System.Windows.Forms.Label();
            this.chb_wifi = new System.Windows.Forms.CheckBox();
            this.lbl_filtrar = new System.Windows.Forms.Label();
            this.chb_comida = new System.Windows.Forms.CheckBox();
            this.lbl_recaudacionInternacional = new System.Windows.Forms.Label();
            this.lbl_recaudacionCabotaje = new System.Windows.Forms.Label();
            this.mnt_MenuPricipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_infoGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_fecha.Location = new System.Drawing.Point(330, 456);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(0, 15);
            this.lbl_fecha.TabIndex = 4;
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(576, 456);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(0, 15);
            this.lbl_nombreUsuario.TabIndex = 5;
            // 
            // mnt_MenuPricipal
            // 
            this.mnt_MenuPricipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmt_vendedores,
            this.bmt_vuelos,
            this.bmt_aviones,
            this.bmt_estadisticas});
            this.mnt_MenuPricipal.Location = new System.Drawing.Point(0, 0);
            this.mnt_MenuPricipal.Name = "mnt_MenuPricipal";
            this.mnt_MenuPricipal.Size = new System.Drawing.Size(817, 24);
            this.mnt_MenuPricipal.TabIndex = 7;
            this.mnt_MenuPricipal.Text = "menuStrip1";
            // 
            // bmt_vendedores
            // 
            this.bmt_vendedores.Name = "bmt_vendedores";
            this.bmt_vendedores.Size = new System.Drawing.Size(80, 20);
            this.bmt_vendedores.Text = "Vendedores";
            this.bmt_vendedores.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // bmt_vuelos
            // 
            this.bmt_vuelos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmt_crearVuelo});
            this.bmt_vuelos.Name = "bmt_vuelos";
            this.bmt_vuelos.Size = new System.Drawing.Size(54, 20);
            this.bmt_vuelos.Text = "Vuelos";
            this.bmt_vuelos.Click += new System.EventHandler(this.vuelosToolStripMenuItem_Click);
            // 
            // bmt_crearVuelo
            // 
            this.bmt_crearVuelo.Name = "bmt_crearVuelo";
            this.bmt_crearVuelo.Size = new System.Drawing.Size(135, 22);
            this.bmt_crearVuelo.Text = "Crear Vuelo";
            this.bmt_crearVuelo.Click += new System.EventHandler(this.crearVueloToolStripMenuItem_Click);
            // 
            // bmt_aviones
            // 
            this.bmt_aviones.Name = "bmt_aviones";
            this.bmt_aviones.Size = new System.Drawing.Size(61, 20);
            this.bmt_aviones.Text = "Aviones";
            this.bmt_aviones.Click += new System.EventHandler(this.avionesToolStripMenuItem_Click);
            // 
            // bmt_estadisticas
            // 
            this.bmt_estadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bmt_listaDestinos,
            this.bmt_listaPasajerosFrecuentes,
            this.bmt_gananciasTotales,
            this.bmt_listaAereonaves,
            this.bmt_listaVendedores});
            this.bmt_estadisticas.Name = "bmt_estadisticas";
            this.bmt_estadisticas.Size = new System.Drawing.Size(79, 20);
            this.bmt_estadisticas.Text = "Estadisticas";
            // 
            // bmt_listaDestinos
            // 
            this.bmt_listaDestinos.Name = "bmt_listaDestinos";
            this.bmt_listaDestinos.Size = new System.Drawing.Size(227, 22);
            this.bmt_listaDestinos.Text = "Lista De Destinos";
            this.bmt_listaDestinos.Click += new System.EventHandler(this.listaDeDestinosToolStripMenuItem_Click);
            // 
            // bmt_listaPasajerosFrecuentes
            // 
            this.bmt_listaPasajerosFrecuentes.Name = "bmt_listaPasajerosFrecuentes";
            this.bmt_listaPasajerosFrecuentes.Size = new System.Drawing.Size(227, 22);
            this.bmt_listaPasajerosFrecuentes.Text = "Lista De Pasajeros Frecuentes";
            this.bmt_listaPasajerosFrecuentes.Click += new System.EventHandler(this.listaDeToolStripMenuItem_Click);
            // 
            // bmt_gananciasTotales
            // 
            this.bmt_gananciasTotales.Name = "bmt_gananciasTotales";
            this.bmt_gananciasTotales.Size = new System.Drawing.Size(227, 22);
            this.bmt_gananciasTotales.Text = "Ganancias Totales";
            this.bmt_gananciasTotales.Click += new System.EventHandler(this.gananciasTotalesToolStripMenuItem_Click);
            // 
            // bmt_listaAereonaves
            // 
            this.bmt_listaAereonaves.Name = "bmt_listaAereonaves";
            this.bmt_listaAereonaves.Size = new System.Drawing.Size(227, 22);
            this.bmt_listaAereonaves.Text = "Aereonaves";
            this.bmt_listaAereonaves.Click += new System.EventHandler(this.aereonavesToolStripMenuItem_Click);
            // 
            // bmt_listaVendedores
            // 
            this.bmt_listaVendedores.Name = "bmt_listaVendedores";
            this.bmt_listaVendedores.Size = new System.Drawing.Size(227, 22);
            this.bmt_listaVendedores.Text = "Vendedores";
            this.bmt_listaVendedores.Click += new System.EventHandler(this.vendedoresToolStripMenuItem1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 456);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(115, 42);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dtg_infoGeneral
            // 
            this.dtg_infoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_infoGeneral.Location = new System.Drawing.Point(14, 123);
            this.dtg_infoGeneral.Name = "dtg_infoGeneral";
            this.dtg_infoGeneral.ReadOnly = true;
            this.dtg_infoGeneral.RowTemplate.Height = 25;
            this.dtg_infoGeneral.Size = new System.Drawing.Size(791, 279);
            this.dtg_infoGeneral.TabIndex = 9;
            this.dtg_infoGeneral.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_vendedorMasPasajesVendidos
            // 
            this.btn_vendedorMasPasajesVendidos.Location = new System.Drawing.Point(629, 36);
            this.btn_vendedorMasPasajesVendidos.Name = "btn_vendedorMasPasajesVendidos";
            this.btn_vendedorMasPasajesVendidos.Size = new System.Drawing.Size(176, 41);
            this.btn_vendedorMasPasajesVendidos.TabIndex = 10;
            this.btn_vendedorMasPasajesVendidos.Text = "Vendedor con mas pasajes vendidos";
            this.btn_vendedorMasPasajesVendidos.UseVisualStyleBackColor = true;
            this.btn_vendedorMasPasajesVendidos.Visible = false;
            this.btn_vendedorMasPasajesVendidos.Click += new System.EventHandler(this.btn_vendedorMayorEdad_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(307, 431);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 15);
            this.lbl_error.TabIndex = 11;
            // 
            // btn_pasajeroMasViajes
            // 
            this.btn_pasajeroMasViajes.Location = new System.Drawing.Point(629, 83);
            this.btn_pasajeroMasViajes.Name = "btn_pasajeroMasViajes";
            this.btn_pasajeroMasViajes.Size = new System.Drawing.Size(176, 34);
            this.btn_pasajeroMasViajes.TabIndex = 12;
            this.btn_pasajeroMasViajes.Text = "Pasajero con mas viajes";
            this.btn_pasajeroMasViajes.UseVisualStyleBackColor = true;
            this.btn_pasajeroMasViajes.Visible = false;
            this.btn_pasajeroMasViajes.Click += new System.EventHandler(this.btn_pasajeroMasViejes_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Info.BackColor = System.Drawing.Color.Transparent;
            this.btn_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Info.BackgroundImage")));
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Info.Location = new System.Drawing.Point(753, 475);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(35, 35);
            this.btn_Info.TabIndex = 24;
            this.btn_Info.UseVisualStyleBackColor = false;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // lbl_recaudacionTotal
            // 
            this.lbl_recaudacionTotal.AutoSize = true;
            this.lbl_recaudacionTotal.Font = new System.Drawing.Font("Sigmar One", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_recaudacionTotal.ForeColor = System.Drawing.Color.Lime;
            this.lbl_recaudacionTotal.Location = new System.Drawing.Point(26, 36);
            this.lbl_recaudacionTotal.Name = "lbl_recaudacionTotal";
            this.lbl_recaudacionTotal.Size = new System.Drawing.Size(0, 20);
            this.lbl_recaudacionTotal.TabIndex = 25;
            // 
            // chb_wifi
            // 
            this.chb_wifi.AutoSize = true;
            this.chb_wifi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_wifi.ForeColor = System.Drawing.SystemColors.Control;
            this.chb_wifi.Location = new System.Drawing.Point(91, 98);
            this.chb_wifi.Name = "chb_wifi";
            this.chb_wifi.Size = new System.Drawing.Size(47, 19);
            this.chb_wifi.TabIndex = 26;
            this.chb_wifi.Text = "Wifi";
            this.chb_wifi.UseVisualStyleBackColor = true;
            this.chb_wifi.CheckedChanged += new System.EventHandler(this.chb_wifi_CheckedChanged);
            // 
            // lbl_filtrar
            // 
            this.lbl_filtrar.AutoSize = true;
            this.lbl_filtrar.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_filtrar.Location = new System.Drawing.Point(14, 99);
            this.lbl_filtrar.Name = "lbl_filtrar";
            this.lbl_filtrar.Size = new System.Drawing.Size(61, 15);
            this.lbl_filtrar.TabIndex = 27;
            this.lbl_filtrar.Text = "Filtrar por:";
            // 
            // chb_comida
            // 
            this.chb_comida.AutoSize = true;
            this.chb_comida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_comida.ForeColor = System.Drawing.SystemColors.Control;
            this.chb_comida.Location = new System.Drawing.Point(162, 98);
            this.chb_comida.Name = "chb_comida";
            this.chb_comida.Size = new System.Drawing.Size(68, 19);
            this.chb_comida.TabIndex = 28;
            this.chb_comida.Text = "Comida";
            this.chb_comida.UseVisualStyleBackColor = true;
            this.chb_comida.CheckedChanged += new System.EventHandler(this.chb_comida_CheckedChanged);
            // 
            // lbl_recaudacionInternacional
            // 
            this.lbl_recaudacionInternacional.AutoSize = true;
            this.lbl_recaudacionInternacional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_recaudacionInternacional.Location = new System.Drawing.Point(279, 36);
            this.lbl_recaudacionInternacional.Name = "lbl_recaudacionInternacional";
            this.lbl_recaudacionInternacional.Size = new System.Drawing.Size(0, 15);
            this.lbl_recaudacionInternacional.TabIndex = 29;
            // 
            // lbl_recaudacionCabotaje
            // 
            this.lbl_recaudacionCabotaje.AutoSize = true;
            this.lbl_recaudacionCabotaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_recaudacionCabotaje.Location = new System.Drawing.Point(279, 64);
            this.lbl_recaudacionCabotaje.Name = "lbl_recaudacionCabotaje";
            this.lbl_recaudacionCabotaje.Size = new System.Drawing.Size(0, 15);
            this.lbl_recaudacionCabotaje.TabIndex = 30;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(817, 522);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_recaudacionCabotaje);
            this.Controls.Add(this.lbl_recaudacionInternacional);
            this.Controls.Add(this.chb_comida);
            this.Controls.Add(this.lbl_filtrar);
            this.Controls.Add(this.chb_wifi);
            this.Controls.Add(this.lbl_recaudacionTotal);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_pasajeroMasViajes);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_vendedorMasPasajesVendidos);
            this.Controls.Add(this.dtg_infoGeneral);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.mnt_MenuPricipal);
            this.MainMenuStrip = this.mnt_MenuPricipal;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.mnt_MenuPricipal.ResumeLayout(false);
            this.mnt_MenuPricipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_infoGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.MenuStrip mnt_MenuPricipal;
        private System.Windows.Forms.ToolStripMenuItem bmt_vendedores;
        private System.Windows.Forms.ToolStripMenuItem bmt_vuelos;
        private System.Windows.Forms.ToolStripMenuItem bmt_aviones;
        private System.Windows.Forms.ToolStripMenuItem bmt_crearVuelo;
        private System.Windows.Forms.ToolStripMenuItem bmt_estadisticas;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dtg_infoGeneral;
        private System.Windows.Forms.ToolStripMenuItem bmt_listaDestinos;
        private System.Windows.Forms.ToolStripMenuItem bmt_listaPasajerosFrecuentes;
        private System.Windows.Forms.ToolStripMenuItem bmt_gananciasTotales;
        private System.Windows.Forms.ToolStripMenuItem bmt_listaAereonaves;
        private System.Windows.Forms.Button btn_vendedorMasPasajesVendidos;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.ToolStripMenuItem bmt_listaVendedores;
        private System.Windows.Forms.Button btn_pasajeroMasViajes;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Label lbl_recaudacionTotal;
        private System.Windows.Forms.CheckBox chb_wifi;
        private System.Windows.Forms.Label lbl_filtrar;
        private System.Windows.Forms.CheckBox chb_comida;
        private System.Windows.Forms.Label lbl_recaudacionInternacional;
        private System.Windows.Forms.Label lbl_recaudacionCabotaje;
    }
}