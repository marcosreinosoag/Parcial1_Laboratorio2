
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
            this.chx_internacional = new System.Windows.Forms.CheckBox();
            this.cmb_avionAsignado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_origen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_destino = new System.Windows.Forms.ComboBox();
            this.dtp_horaDeSalida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_horaDeLlegada = new System.Windows.Forms.DateTimePicker();
            this.btn_generarDuracion = new System.Windows.Forms.Button();
            this.txt_duracionVuelo = new System.Windows.Forms.TextBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chx_internacional
            // 
            this.chx_internacional.AutoSize = true;
            this.chx_internacional.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cmb_avionAsignado.FormattingEnabled = true;
            this.cmb_avionAsignado.Location = new System.Drawing.Point(135, 22);
            this.cmb_avionAsignado.Name = "cmb_avionAsignado";
            this.cmb_avionAsignado.Size = new System.Drawing.Size(291, 23);
            this.cmb_avionAsignado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Avion Asignado";
            // 
            // cmb_origen
            // 
            this.cmb_origen.FormattingEnabled = true;
            this.cmb_origen.Location = new System.Drawing.Point(135, 106);
            this.cmb_origen.Name = "cmb_origen";
            this.cmb_origen.Size = new System.Drawing.Size(291, 23);
            this.cmb_origen.TabIndex = 3;
            this.cmb_origen.SelectedIndexChanged += new System.EventHandler(this.cmb_origen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destino:";
            // 
            // cmb_destino
            // 
            this.cmb_destino.FormattingEnabled = true;
            this.cmb_destino.Location = new System.Drawing.Point(135, 160);
            this.cmb_destino.Name = "cmb_destino";
            this.cmb_destino.Size = new System.Drawing.Size(291, 23);
            this.cmb_destino.TabIndex = 6;
            this.cmb_destino.SelectedIndexChanged += new System.EventHandler(this.cmb_destino_SelectedIndexChanged);
            // 
            // dtp_horaDeSalida
            // 
            this.dtp_horaDeSalida.Location = new System.Drawing.Point(135, 218);
            this.dtp_horaDeSalida.Name = "dtp_horaDeSalida";
            this.dtp_horaDeSalida.Size = new System.Drawing.Size(291, 23);
            this.dtp_horaDeSalida.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horario de Salida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Horario de Llegada:";
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
            this.dtp_horaDeLlegada.Value = new System.DateTime(2022, 9, 25, 0, 0, 0, 0);
            // 
            // btn_generarDuracion
            // 
            this.btn_generarDuracion.Location = new System.Drawing.Point(19, 269);
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
            this.txt_duracionVuelo.Location = new System.Drawing.Point(135, 269);
            this.txt_duracionVuelo.Name = "txt_duracionVuelo";
            this.txt_duracionVuelo.Size = new System.Drawing.Size(291, 23);
            this.txt_duracionVuelo.TabIndex = 12;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(362, 383);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(92, 31);
            this.btn_aceptar.TabIndex = 13;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(61, 383);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(91, 31);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(103, 349);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 19);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Wifi";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(204, 349);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 19);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Comida";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // CrearVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 456);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_duracionVuelo);
            this.Controls.Add(this.btn_generarDuracion);
            this.Controls.Add(this.dtp_horaDeLlegada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_horaDeSalida);
            this.Controls.Add(this.cmb_destino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_origen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_avionAsignado);
            this.Controls.Add(this.chx_internacional);
            this.Name = "CrearVuelo";
            this.Text = "AgregarVuelo";
            this.Load += new System.EventHandler(this.AgregarVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chx_internacional;
        private System.Windows.Forms.ComboBox cmb_avionAsignado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_origen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_destino;
        private System.Windows.Forms.DateTimePicker dtp_horaDeSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_horaDeLlegada;
        private System.Windows.Forms.Button btn_generarDuracion;
        private System.Windows.Forms.TextBox txt_duracionVuelo;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}