
namespace Vista
{
    partial class CrearVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearVuelo));
            this.chx_internacional = new System.Windows.Forms.CheckBox();
            this.cmb_avionAsignado = new System.Windows.Forms.ComboBox();
            this.lbl_avionAsignado = new System.Windows.Forms.Label();
            this.cmb_origen = new System.Windows.Forms.ComboBox();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.cmb_destino = new System.Windows.Forms.ComboBox();
            this.dtp_horaDeSalida = new System.Windows.Forms.DateTimePicker();
            this.lbl_horaSalida = new System.Windows.Forms.Label();
            this.lbl_horaLlegada = new System.Windows.Forms.Label();
            this.dtp_horaDeLlegada = new System.Windows.Forms.DateTimePicker();
            this.btn_generarDuracion = new System.Windows.Forms.Button();
            this.txt_duracionVuelo = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.chb_wifi = new System.Windows.Forms.CheckBox();
            this.chb_comida = new System.Windows.Forms.CheckBox();
            this.btn_errorItemOrigen = new System.Windows.Forms.Button();
            this.btn_errorItemAvion = new System.Windows.Forms.Button();
            this.btn_errorItemDestino = new System.Windows.Forms.Button();
            this.btn_errorDuracion = new System.Windows.Forms.Button();
            this.btn_errorFechaSalida = new System.Windows.Forms.Button();
            this.btn_errorFechaLlegada = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chx_internacional
            // 
            this.chx_internacional.AutoSize = true;
            this.chx_internacional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chx_internacional.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chx_internacional.Location = new System.Drawing.Point(9, 66);
            this.chx_internacional.Name = "chx_internacional";
            this.chx_internacional.Size = new System.Drawing.Size(141, 19);
            this.chx_internacional.TabIndex = 0;
            this.chx_internacional.Text = "Destino Internacional:";
            this.chx_internacional.UseVisualStyleBackColor = true;
            this.chx_internacional.CheckedChanged += new System.EventHandler(this.chx_internacional_CheckedChanged);
            // 
            // cmb_avionAsignado
            // 
            this.cmb_avionAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_avionAsignado.FormattingEnabled = true;
            this.cmb_avionAsignado.Location = new System.Drawing.Point(135, 22);
            this.cmb_avionAsignado.Name = "cmb_avionAsignado";
            this.cmb_avionAsignado.Size = new System.Drawing.Size(291, 23);
            this.cmb_avionAsignado.TabIndex = 1;
            // 
            // lbl_avionAsignado
            // 
            this.lbl_avionAsignado.AutoSize = true;
            this.lbl_avionAsignado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_avionAsignado.Location = new System.Drawing.Point(24, 25);
            this.lbl_avionAsignado.Name = "lbl_avionAsignado";
            this.lbl_avionAsignado.Size = new System.Drawing.Size(91, 15);
            this.lbl_avionAsignado.TabIndex = 2;
            this.lbl_avionAsignado.Text = "Avion Asignado";
            // 
            // cmb_origen
            // 
            this.cmb_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_origen.FormattingEnabled = true;
            this.cmb_origen.Location = new System.Drawing.Point(135, 106);
            this.cmb_origen.Name = "cmb_origen";
            this.cmb_origen.Size = new System.Drawing.Size(291, 23);
            this.cmb_origen.TabIndex = 3;
            this.cmb_origen.SelectedIndexChanged += new System.EventHandler(this.cmb_origen_SelectedIndexChanged);
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_origen.Location = new System.Drawing.Point(64, 106);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(46, 15);
            this.lbl_origen.TabIndex = 4;
            this.lbl_origen.Text = "Origen:";
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_destino.Location = new System.Drawing.Point(64, 168);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(50, 15);
            this.lbl_destino.TabIndex = 5;
            this.lbl_destino.Text = "Destino:";
            // 
            // cmb_destino
            // 
            this.cmb_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_destino.FormattingEnabled = true;
            this.cmb_destino.Location = new System.Drawing.Point(135, 160);
            this.cmb_destino.Name = "cmb_destino";
            this.cmb_destino.Size = new System.Drawing.Size(291, 23);
            this.cmb_destino.TabIndex = 6;
            this.cmb_destino.SelectedIndexChanged += new System.EventHandler(this.cmb_destino_SelectedIndexChanged);
            // 
            // dtp_horaDeSalida
            // 
            this.dtp_horaDeSalida.Location = new System.Drawing.Point(135, 211);
            this.dtp_horaDeSalida.Name = "dtp_horaDeSalida";
            this.dtp_horaDeSalida.Size = new System.Drawing.Size(291, 23);
            this.dtp_horaDeSalida.TabIndex = 7;
            // 
            // lbl_horaSalida
            // 
            this.lbl_horaSalida.AutoSize = true;
            this.lbl_horaSalida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_horaSalida.Location = new System.Drawing.Point(15, 217);
            this.lbl_horaSalida.Name = "lbl_horaSalida";
            this.lbl_horaSalida.Size = new System.Drawing.Size(100, 15);
            this.lbl_horaSalida.TabIndex = 8;
            this.lbl_horaSalida.Text = "Horario de Salida:";
            // 
            // lbl_horaLlegada
            // 
            this.lbl_horaLlegada.AutoSize = true;
            this.lbl_horaLlegada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_horaLlegada.Location = new System.Drawing.Point(19, 312);
            this.lbl_horaLlegada.Name = "lbl_horaLlegada";
            this.lbl_horaLlegada.Size = new System.Drawing.Size(110, 15);
            this.lbl_horaLlegada.TabIndex = 9;
            this.lbl_horaLlegada.Text = "Horario de Llegada:";
            // 
            // dtp_horaDeLlegada
            // 
            this.dtp_horaDeLlegada.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_horaDeLlegada.Enabled = false;
            this.dtp_horaDeLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaDeLlegada.Location = new System.Drawing.Point(135, 306);
            this.dtp_horaDeLlegada.Name = "dtp_horaDeLlegada";
            this.dtp_horaDeLlegada.Size = new System.Drawing.Size(291, 23);
            this.dtp_horaDeLlegada.TabIndex = 10;
            this.dtp_horaDeLlegada.Value = new System.DateTime(1997, 9, 25, 0, 0, 0, 0);
            // 
            // btn_generarDuracion
            // 
            this.btn_generarDuracion.Location = new System.Drawing.Point(15, 264);
            this.btn_generarDuracion.Name = "btn_generarDuracion";
            this.btn_generarDuracion.Size = new System.Drawing.Size(110, 23);
            this.btn_generarDuracion.TabIndex = 11;
            this.btn_generarDuracion.Text = "Calcular duracion";
            this.btn_generarDuracion.UseVisualStyleBackColor = true;
            this.btn_generarDuracion.Click += new System.EventHandler(this.btn_generarDuracion_Click);
            // 
            // txt_duracionVuelo
            // 
            this.txt_duracionVuelo.Enabled = false;
            this.txt_duracionVuelo.Location = new System.Drawing.Point(135, 264);
            this.txt_duracionVuelo.Name = "txt_duracionVuelo";
            this.txt_duracionVuelo.Size = new System.Drawing.Size(291, 23);
            this.txt_duracionVuelo.TabIndex = 12;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(378, 365);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(92, 31);
            this.btn_aceptar.TabIndex = 13;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(77, 365);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(91, 31);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // chb_wifi
            // 
            this.chb_wifi.AutoSize = true;
            this.chb_wifi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_wifi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chb_wifi.Location = new System.Drawing.Point(195, 66);
            this.chb_wifi.Name = "chb_wifi";
            this.chb_wifi.Size = new System.Drawing.Size(47, 19);
            this.chb_wifi.TabIndex = 15;
            this.chb_wifi.Text = "Wifi";
            this.chb_wifi.UseVisualStyleBackColor = true;
            this.chb_wifi.CheckedChanged += new System.EventHandler(this.chb_wifi_CheckedChanged);
            // 
            // chb_comida
            // 
            this.chb_comida.AutoSize = true;
            this.chb_comida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_comida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chb_comida.Location = new System.Drawing.Point(296, 66);
            this.chb_comida.Name = "chb_comida";
            this.chb_comida.Size = new System.Drawing.Size(68, 19);
            this.chb_comida.TabIndex = 16;
            this.chb_comida.Text = "Comida";
            this.chb_comida.UseVisualStyleBackColor = true;
            this.chb_comida.CheckedChanged += new System.EventHandler(this.chb_comida_CheckedChanged);
            // 
            // btn_errorItemOrigen
            // 
            this.btn_errorItemOrigen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorItemOrigen.BackColor = System.Drawing.Color.Black;
            this.btn_errorItemOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorItemOrigen.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorItemOrigen.Image")));
            this.btn_errorItemOrigen.Location = new System.Drawing.Point(430, 100);
            this.btn_errorItemOrigen.Name = "btn_errorItemOrigen";
            this.btn_errorItemOrigen.Size = new System.Drawing.Size(38, 35);
            this.btn_errorItemOrigen.TabIndex = 17;
            this.btn_errorItemOrigen.UseVisualStyleBackColor = false;
            this.btn_errorItemOrigen.Visible = false;
            this.btn_errorItemOrigen.MouseHover += new System.EventHandler(this.btn_errorItemDestino_MouseHover);
            // 
            // btn_errorItemAvion
            // 
            this.btn_errorItemAvion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorItemAvion.BackColor = System.Drawing.Color.Black;
            this.btn_errorItemAvion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorItemAvion.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorItemAvion.Image")));
            this.btn_errorItemAvion.Location = new System.Drawing.Point(432, 15);
            this.btn_errorItemAvion.Name = "btn_errorItemAvion";
            this.btn_errorItemAvion.Size = new System.Drawing.Size(38, 35);
            this.btn_errorItemAvion.TabIndex = 18;
            this.btn_errorItemAvion.UseVisualStyleBackColor = false;
            this.btn_errorItemAvion.Visible = false;
            this.btn_errorItemAvion.MouseHover += new System.EventHandler(this.btn_errorItemAvion_MouseHover_1);
            // 
            // btn_errorItemDestino
            // 
            this.btn_errorItemDestino.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorItemDestino.BackColor = System.Drawing.Color.Black;
            this.btn_errorItemDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorItemDestino.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorItemDestino.Image")));
            this.btn_errorItemDestino.Location = new System.Drawing.Point(432, 153);
            this.btn_errorItemDestino.Name = "btn_errorItemDestino";
            this.btn_errorItemDestino.Size = new System.Drawing.Size(38, 35);
            this.btn_errorItemDestino.TabIndex = 19;
            this.btn_errorItemDestino.UseVisualStyleBackColor = false;
            this.btn_errorItemDestino.Visible = false;
            this.btn_errorItemDestino.MouseHover += new System.EventHandler(this.btn_errorItemDestino_MouseHover);
            // 
            // btn_errorDuracion
            // 
            this.btn_errorDuracion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorDuracion.BackColor = System.Drawing.Color.Black;
            this.btn_errorDuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorDuracion.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorDuracion.Image")));
            this.btn_errorDuracion.Location = new System.Drawing.Point(432, 258);
            this.btn_errorDuracion.Name = "btn_errorDuracion";
            this.btn_errorDuracion.Size = new System.Drawing.Size(38, 35);
            this.btn_errorDuracion.TabIndex = 20;
            this.btn_errorDuracion.UseVisualStyleBackColor = false;
            this.btn_errorDuracion.Visible = false;
            this.btn_errorDuracion.MouseHover += new System.EventHandler(this.btn_errorDuracion_MouseHover);
            // 
            // btn_errorFechaSalida
            // 
            this.btn_errorFechaSalida.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorFechaSalida.BackColor = System.Drawing.Color.Black;
            this.btn_errorFechaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorFechaSalida.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorFechaSalida.Image")));
            this.btn_errorFechaSalida.Location = new System.Drawing.Point(430, 207);
            this.btn_errorFechaSalida.Name = "btn_errorFechaSalida";
            this.btn_errorFechaSalida.Size = new System.Drawing.Size(38, 35);
            this.btn_errorFechaSalida.TabIndex = 21;
            this.btn_errorFechaSalida.UseVisualStyleBackColor = false;
            this.btn_errorFechaSalida.Visible = false;
            this.btn_errorFechaSalida.MouseHover += new System.EventHandler(this.btn_errorFechaSalida_MouseHover);
            // 
            // btn_errorFechaLlegada
            // 
            this.btn_errorFechaLlegada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_errorFechaLlegada.BackColor = System.Drawing.Color.Black;
            this.btn_errorFechaLlegada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorFechaLlegada.Image = ((System.Drawing.Image)(resources.GetObject("btn_errorFechaLlegada.Image")));
            this.btn_errorFechaLlegada.Location = new System.Drawing.Point(432, 302);
            this.btn_errorFechaLlegada.Name = "btn_errorFechaLlegada";
            this.btn_errorFechaLlegada.Size = new System.Drawing.Size(38, 35);
            this.btn_errorFechaLlegada.TabIndex = 22;
            this.btn_errorFechaLlegada.UseVisualStyleBackColor = false;
            this.btn_errorFechaLlegada.Visible = false;
            this.btn_errorFechaLlegada.MouseHover += new System.EventHandler(this.btn_errorDuracion_MouseHover);
            // 
            // btn_Info
            // 
            this.btn_Info.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Info.BackColor = System.Drawing.Color.Transparent;
            this.btn_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Info.BackgroundImage")));
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Info.Location = new System.Drawing.Point(476, 22);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(35, 35);
            this.btn_Info.TabIndex = 23;
            this.btn_Info.UseVisualStyleBackColor = false;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // CrearVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(534, 429);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_errorFechaLlegada);
            this.Controls.Add(this.btn_errorFechaSalida);
            this.Controls.Add(this.btn_errorDuracion);
            this.Controls.Add(this.btn_errorItemDestino);
            this.Controls.Add(this.btn_errorItemAvion);
            this.Controls.Add(this.btn_errorItemOrigen);
            this.Controls.Add(this.chb_comida);
            this.Controls.Add(this.chb_wifi);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_duracionVuelo);
            this.Controls.Add(this.btn_generarDuracion);
            this.Controls.Add(this.dtp_horaDeLlegada);
            this.Controls.Add(this.lbl_horaLlegada);
            this.Controls.Add(this.lbl_horaSalida);
            this.Controls.Add(this.dtp_horaDeSalida);
            this.Controls.Add(this.cmb_destino);
            this.Controls.Add(this.lbl_destino);
            this.Controls.Add(this.lbl_origen);
            this.Controls.Add(this.cmb_origen);
            this.Controls.Add(this.lbl_avionAsignado);
            this.Controls.Add(this.cmb_avionAsignado);
            this.Controls.Add(this.chx_internacional);
            this.Name = "CrearVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Vuelo";
            this.Load += new System.EventHandler(this.AgregarVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chx_internacional;
        private System.Windows.Forms.ComboBox cmb_avionAsignado;
        private System.Windows.Forms.Label lbl_avionAsignado;
        private System.Windows.Forms.ComboBox cmb_origen;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.ComboBox cmb_destino;
        private System.Windows.Forms.DateTimePicker dtp_horaDeSalida;
        private System.Windows.Forms.Label lbl_horaSalida;
        private System.Windows.Forms.Label lbl_horaLlegada;
        private System.Windows.Forms.DateTimePicker dtp_horaDeLlegada;
        private System.Windows.Forms.Button btn_generarDuracion;
        private System.Windows.Forms.TextBox txt_duracionVuelo;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckBox chb_wifi;
        private System.Windows.Forms.CheckBox chb_comida;
        private System.Windows.Forms.Button btn_errorItemOrigen;
        private System.Windows.Forms.Button btn_errorItemAvion;
        private System.Windows.Forms.Button btn_errorItemDestino;
        private System.Windows.Forms.Button btn_errorDuracion;
        private System.Windows.Forms.Button btn_errorFechaSalida;
        private System.Windows.Forms.Button btn_errorFechaLlegada;
        private System.Windows.Forms.Button btn_Info;
    }
}