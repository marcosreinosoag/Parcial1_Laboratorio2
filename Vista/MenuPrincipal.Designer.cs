
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
            this.btn_vendedores = new System.Windows.Forms.Button();
            this.btn_crearVuelo = new System.Windows.Forms.Button();
            this.btn_vuelos = new System.Windows.Forms.Button();
            this.dtg_informacion = new System.Windows.Forms.DataGridView();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_informacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_vendedores
            // 
            this.btn_vendedores.Location = new System.Drawing.Point(4, 12);
            this.btn_vendedores.Name = "btn_vendedores";
            this.btn_vendedores.Size = new System.Drawing.Size(132, 29);
            this.btn_vendedores.TabIndex = 0;
            this.btn_vendedores.Text = "Vendedores";
            this.btn_vendedores.UseVisualStyleBackColor = true;
            this.btn_vendedores.Click += new System.EventHandler(this.btn_vendedores_Click);
            // 
            // btn_crearVuelo
            // 
            this.btn_crearVuelo.Location = new System.Drawing.Point(12, 104);
            this.btn_crearVuelo.Name = "btn_crearVuelo";
            this.btn_crearVuelo.Size = new System.Drawing.Size(132, 39);
            this.btn_crearVuelo.TabIndex = 1;
            this.btn_crearVuelo.Text = "Crear Vuelo";
            this.btn_crearVuelo.UseVisualStyleBackColor = true;
            this.btn_crearVuelo.Click += new System.EventHandler(this.btn_crearVuelo_Click);
            // 
            // btn_vuelos
            // 
            this.btn_vuelos.Location = new System.Drawing.Point(159, 12);
            this.btn_vuelos.Name = "btn_vuelos";
            this.btn_vuelos.Size = new System.Drawing.Size(136, 29);
            this.btn_vuelos.TabIndex = 2;
            this.btn_vuelos.Text = "Vuelos";
            this.btn_vuelos.UseVisualStyleBackColor = true;
            this.btn_vuelos.Click += new System.EventHandler(this.btn_vuelos_Click);
            // 
            // dtg_informacion
            // 
            this.dtg_informacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_informacion.Location = new System.Drawing.Point(167, 104);
            this.dtg_informacion.Name = "dtg_informacion";
            this.dtg_informacion.RowTemplate.Height = 25;
            this.dtg_informacion.Size = new System.Drawing.Size(626, 293);
            this.dtg_informacion.TabIndex = 3;
            this.dtg_informacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_informacion_CellDoubleClick);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(240, 400);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(0, 15);
            this.lbl_fecha.TabIndex = 4;
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(486, 400);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(0, 15);
            this.lbl_nombreUsuario.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aviones";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.dtg_informacion);
            this.Controls.Add(this.btn_vuelos);
            this.Controls.Add(this.btn_crearVuelo);
            this.Controls.Add(this.btn_vendedores);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_informacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_vendedores;
        private System.Windows.Forms.Button btn_crearVuelo;
        private System.Windows.Forms.Button btn_vuelos;
        private System.Windows.Forms.DataGridView dtg_informacion;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Button button1;
    }
}