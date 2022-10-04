
namespace Vista
{
    partial class InformacionVuelo
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
            this.chb_comida = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chb_wifi = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_destino = new System.Windows.Forms.TextBox();
            this.txb_origen = new System.Windows.Forms.TextBox();
            this.txb_idVuelo = new System.Windows.Forms.TextBox();
            this.btn_cargarPasajeros = new System.Windows.Forms.Button();
            this.nud_cantidadDePasajeros = new System.Windows.Forms.NumericUpDown();
            this.btn_infoPasajeros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_infoGeneral = new System.Windows.Forms.DataGridView();
            this.btn_equipaje = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_errorCantidadPasajeros = new System.Windows.Forms.Label();
            this.btn_finalizarVuelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidadDePasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_infoGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // chb_comida
            // 
            this.chb_comida.AutoSize = true;
            this.chb_comida.BackColor = System.Drawing.Color.Transparent;
            this.chb_comida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chb_comida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_comida.Enabled = false;
            this.chb_comida.ForeColor = System.Drawing.Color.White;
            this.chb_comida.Location = new System.Drawing.Point(122, 39);
            this.chb_comida.Name = "chb_comida";
            this.chb_comida.Size = new System.Drawing.Size(68, 19);
            this.chb_comida.TabIndex = 19;
            this.chb_comida.Text = "Comida";
            this.chb_comida.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Incluye :";
            // 
            // chb_wifi
            // 
            this.chb_wifi.AutoSize = true;
            this.chb_wifi.BackColor = System.Drawing.Color.Transparent;
            this.chb_wifi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chb_wifi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_wifi.Enabled = false;
            this.chb_wifi.ForeColor = System.Drawing.Color.White;
            this.chb_wifi.Location = new System.Drawing.Point(63, 39);
            this.chb_wifi.Name = "chb_wifi";
            this.chb_wifi.Size = new System.Drawing.Size(47, 19);
            this.chb_wifi.TabIndex = 17;
            this.chb_wifi.Text = "Wifi";
            this.chb_wifi.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(456, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Destino :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Origen";
            // 
            // txb_destino
            // 
            this.txb_destino.Enabled = false;
            this.txb_destino.Location = new System.Drawing.Point(515, 6);
            this.txb_destino.Name = "txb_destino";
            this.txb_destino.Size = new System.Drawing.Size(279, 23);
            this.txb_destino.TabIndex = 14;
            // 
            // txb_origen
            // 
            this.txb_origen.Enabled = false;
            this.txb_origen.Location = new System.Drawing.Point(202, 6);
            this.txb_origen.Name = "txb_origen";
            this.txb_origen.Size = new System.Drawing.Size(248, 23);
            this.txb_origen.TabIndex = 13;
            // 
            // txb_idVuelo
            // 
            this.txb_idVuelo.Enabled = false;
            this.txb_idVuelo.Location = new System.Drawing.Point(2, 6);
            this.txb_idVuelo.Name = "txb_idVuelo";
            this.txb_idVuelo.Size = new System.Drawing.Size(145, 23);
            this.txb_idVuelo.TabIndex = 12;
            // 
            // btn_cargarPasajeros
            // 
            this.btn_cargarPasajeros.Location = new System.Drawing.Point(305, 63);
            this.btn_cargarPasajeros.Name = "btn_cargarPasajeros";
            this.btn_cargarPasajeros.Size = new System.Drawing.Size(145, 35);
            this.btn_cargarPasajeros.TabIndex = 23;
            this.btn_cargarPasajeros.Text = "Cargar Pasajeros";
            this.btn_cargarPasajeros.UseVisualStyleBackColor = true;
            this.btn_cargarPasajeros.Click += new System.EventHandler(this.btn_cargarPasajeros_Click);
            // 
            // nud_cantidadDePasajeros
            // 
            this.nud_cantidadDePasajeros.Location = new System.Drawing.Point(153, 75);
            this.nud_cantidadDePasajeros.Name = "nud_cantidadDePasajeros";
            this.nud_cantidadDePasajeros.Size = new System.Drawing.Size(120, 23);
            this.nud_cantidadDePasajeros.TabIndex = 22;
            // 
            // btn_infoPasajeros
            // 
            this.btn_infoPasajeros.Location = new System.Drawing.Point(478, 63);
            this.btn_infoPasajeros.Name = "btn_infoPasajeros";
            this.btn_infoPasajeros.Size = new System.Drawing.Size(138, 35);
            this.btn_infoPasajeros.TabIndex = 21;
            this.btn_infoPasajeros.Text = "Pasajeros";
            this.btn_infoPasajeros.UseVisualStyleBackColor = true;
            this.btn_infoPasajeros.Click += new System.EventHandler(this.btn_infoPasajeros_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cantidad De Pasajeros";
            // 
            // dtg_infoGeneral
            // 
            this.dtg_infoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_infoGeneral.Location = new System.Drawing.Point(18, 121);
            this.dtg_infoGeneral.Name = "dtg_infoGeneral";
            this.dtg_infoGeneral.RowTemplate.Height = 25;
            this.dtg_infoGeneral.Size = new System.Drawing.Size(802, 317);
            this.dtg_infoGeneral.TabIndex = 14;
            // 
            // btn_equipaje
            // 
            this.btn_equipaje.Location = new System.Drawing.Point(654, 63);
            this.btn_equipaje.Name = "btn_equipaje";
            this.btn_equipaje.Size = new System.Drawing.Size(138, 35);
            this.btn_equipaje.TabIndex = 24;
            this.btn_equipaje.Text = "Equipaje";
            this.btn_equipaje.UseVisualStyleBackColor = true;
            this.btn_equipaje.Click += new System.EventHandler(this.btn_equipaje_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(18, 454);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(172, 28);
            this.btn_salir.TabIndex = 25;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_errorCantidadPasajeros
            // 
            this.lbl_errorCantidadPasajeros.AutoSize = true;
            this.lbl_errorCantidadPasajeros.Font = new System.Drawing.Font("Bodoni MT Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_errorCantidadPasajeros.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorCantidadPasajeros.Location = new System.Drawing.Point(173, 104);
            this.lbl_errorCantidadPasajeros.Name = "lbl_errorCantidadPasajeros";
            this.lbl_errorCantidadPasajeros.Size = new System.Drawing.Size(0, 14);
            this.lbl_errorCantidadPasajeros.TabIndex = 36;
            this.lbl_errorCantidadPasajeros.Visible = false;
            // 
            // btn_finalizarVuelo
            // 
            this.btn_finalizarVuelo.Location = new System.Drawing.Point(633, 454);
            this.btn_finalizarVuelo.Name = "btn_finalizarVuelo";
            this.btn_finalizarVuelo.Size = new System.Drawing.Size(170, 28);
            this.btn_finalizarVuelo.TabIndex = 37;
            this.btn_finalizarVuelo.Text = "Finalizar Vuelo";
            this.btn_finalizarVuelo.UseVisualStyleBackColor = true;
            this.btn_finalizarVuelo.Click += new System.EventHandler(this.btn_finalizarVuelo_Click);
            // 
            // InformacionVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(847, 494);
            this.ControlBox = false;
            this.Controls.Add(this.btn_finalizarVuelo);
            this.Controls.Add(this.lbl_errorCantidadPasajeros);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_equipaje);
            this.Controls.Add(this.btn_cargarPasajeros);
            this.Controls.Add(this.nud_cantidadDePasajeros);
            this.Controls.Add(this.btn_infoPasajeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chb_comida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chb_wifi);
            this.Controls.Add(this.dtg_infoGeneral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_destino);
            this.Controls.Add(this.txb_origen);
            this.Controls.Add(this.txb_idVuelo);
            this.Name = "InformacionVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vuelo";
            this.Load += new System.EventHandler(this.InformacionVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidadDePasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_infoGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_comida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chb_wifi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_destino;
        private System.Windows.Forms.TextBox txb_origen;
        private System.Windows.Forms.TextBox txb_idVuelo;
        private System.Windows.Forms.Button btn_cargarPasajeros;
        private System.Windows.Forms.NumericUpDown nud_cantidadDePasajeros;
        private System.Windows.Forms.Button btn_infoPasajeros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_infoGeneral;
        private System.Windows.Forms.Button btn_equipaje;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_errorCantidadPasajeros;
        private System.Windows.Forms.Button btn_finalizarVuelo;
    }
}