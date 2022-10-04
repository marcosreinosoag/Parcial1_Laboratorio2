
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeDestinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gananciasTotalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aereonavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dtg_infoGeneral = new System.Windows.Forms.DataGridView();
            this.btn_vendedorMayorEdad = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_pasajeroMasViejes = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendedoresToolStripMenuItem,
            this.vuelosToolStripMenuItem,
            this.avionesToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // vuelosToolStripMenuItem
            // 
            this.vuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearVueloToolStripMenuItem});
            this.vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            this.vuelosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.vuelosToolStripMenuItem.Text = "Vuelos";
            this.vuelosToolStripMenuItem.Click += new System.EventHandler(this.vuelosToolStripMenuItem_Click);
            // 
            // crearVueloToolStripMenuItem
            // 
            this.crearVueloToolStripMenuItem.Name = "crearVueloToolStripMenuItem";
            this.crearVueloToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.crearVueloToolStripMenuItem.Text = "Crear Vuelo";
            this.crearVueloToolStripMenuItem.Click += new System.EventHandler(this.crearVueloToolStripMenuItem_Click);
            // 
            // avionesToolStripMenuItem
            // 
            this.avionesToolStripMenuItem.Name = "avionesToolStripMenuItem";
            this.avionesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.avionesToolStripMenuItem.Text = "Aviones";
            this.avionesToolStripMenuItem.Click += new System.EventHandler(this.avionesToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeDestinosToolStripMenuItem,
            this.listaDeToolStripMenuItem,
            this.gananciasTotalesToolStripMenuItem,
            this.aereonavesToolStripMenuItem,
            this.vendedoresToolStripMenuItem1});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // listaDeDestinosToolStripMenuItem
            // 
            this.listaDeDestinosToolStripMenuItem.Name = "listaDeDestinosToolStripMenuItem";
            this.listaDeDestinosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.listaDeDestinosToolStripMenuItem.Text = "Lista De Destinos";
            this.listaDeDestinosToolStripMenuItem.Click += new System.EventHandler(this.listaDeDestinosToolStripMenuItem_Click);
            // 
            // listaDeToolStripMenuItem
            // 
            this.listaDeToolStripMenuItem.Name = "listaDeToolStripMenuItem";
            this.listaDeToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.listaDeToolStripMenuItem.Text = "Lista De Pasajeros Frecuentes";
            this.listaDeToolStripMenuItem.Click += new System.EventHandler(this.listaDeToolStripMenuItem_Click);
            // 
            // gananciasTotalesToolStripMenuItem
            // 
            this.gananciasTotalesToolStripMenuItem.Name = "gananciasTotalesToolStripMenuItem";
            this.gananciasTotalesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.gananciasTotalesToolStripMenuItem.Text = "Ganancias Totales";
            // 
            // aereonavesToolStripMenuItem
            // 
            this.aereonavesToolStripMenuItem.Name = "aereonavesToolStripMenuItem";
            this.aereonavesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.aereonavesToolStripMenuItem.Text = "Aereonaves";
            this.aereonavesToolStripMenuItem.Click += new System.EventHandler(this.aereonavesToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem1
            // 
            this.vendedoresToolStripMenuItem1.Name = "vendedoresToolStripMenuItem1";
            this.vendedoresToolStripMenuItem1.Size = new System.Drawing.Size(227, 22);
            this.vendedoresToolStripMenuItem1.Text = "Vendedores";
            this.vendedoresToolStripMenuItem1.Click += new System.EventHandler(this.vendedoresToolStripMenuItem1_Click);
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
            this.dtg_infoGeneral.Location = new System.Drawing.Point(14, 106);
            this.dtg_infoGeneral.Name = "dtg_infoGeneral";
            this.dtg_infoGeneral.RowTemplate.Height = 25;
            this.dtg_infoGeneral.Size = new System.Drawing.Size(749, 296);
            this.dtg_infoGeneral.TabIndex = 9;
            this.dtg_infoGeneral.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_vendedorMayorEdad
            // 
            this.btn_vendedorMayorEdad.Location = new System.Drawing.Point(637, 36);
            this.btn_vendedorMayorEdad.Name = "btn_vendedorMayorEdad";
            this.btn_vendedorMayorEdad.Size = new System.Drawing.Size(126, 49);
            this.btn_vendedorMayorEdad.TabIndex = 10;
            this.btn_vendedorMayorEdad.Text = "Vendedor Con mayor edad";
            this.btn_vendedorMayorEdad.UseVisualStyleBackColor = true;
            this.btn_vendedorMayorEdad.Visible = false;
            this.btn_vendedorMayorEdad.Click += new System.EventHandler(this.btn_vendedorMayorEdad_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(306, 416);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 15);
            this.lbl_error.TabIndex = 11;
            // 
            // btn_pasajeroMasViejes
            // 
            this.btn_pasajeroMasViejes.Location = new System.Drawing.Point(442, 36);
            this.btn_pasajeroMasViejes.Name = "btn_pasajeroMasViejes";
            this.btn_pasajeroMasViejes.Size = new System.Drawing.Size(133, 48);
            this.btn_pasajeroMasViejes.TabIndex = 12;
            this.btn_pasajeroMasViejes.Text = "Pasajero con mas viajes";
            this.btn_pasajeroMasViejes.UseVisualStyleBackColor = true;
            this.btn_pasajeroMasViejes.Click += new System.EventHandler(this.btn_pasajeroMasViejes_Click);
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
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_pasajeroMasViejes);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_vendedorMayorEdad);
            this.Controls.Add(this.dtg_infoGeneral);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_infoGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dtg_infoGeneral;
        private System.Windows.Forms.ToolStripMenuItem listaDeDestinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gananciasTotalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aereonavesToolStripMenuItem;
        private System.Windows.Forms.Button btn_vendedorMayorEdad;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem1;
        private System.Windows.Forms.Button btn_pasajeroMasViejes;
        private System.Windows.Forms.Button btn_Info;
    }
}