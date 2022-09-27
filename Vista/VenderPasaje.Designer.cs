
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
            this.txb_idVuelo = new System.Windows.Forms.TextBox();
            this.txb_origen = new System.Windows.Forms.TextBox();
            this.txb_destino = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chb_wifi = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chb_comida = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txb_idVuelo
            // 
            this.txb_idVuelo.Enabled = false;
            this.txb_idVuelo.Location = new System.Drawing.Point(12, 12);
            this.txb_idVuelo.Name = "txb_idVuelo";
            this.txb_idVuelo.Size = new System.Drawing.Size(145, 23);
            this.txb_idVuelo.TabIndex = 0;
            // 
            // txb_origen
            // 
            this.txb_origen.Enabled = false;
            this.txb_origen.Location = new System.Drawing.Point(237, 12);
            this.txb_origen.Name = "txb_origen";
            this.txb_origen.Size = new System.Drawing.Size(248, 23);
            this.txb_origen.TabIndex = 1;
            // 
            // txb_destino
            // 
            this.txb_destino.Enabled = false;
            this.txb_destino.Location = new System.Drawing.Point(581, 12);
            this.txb_destino.Name = "txb_destino";
            this.txb_destino.Size = new System.Drawing.Size(321, 23);
            this.txb_destino.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(330, 62);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 23);
            this.domainUpDown1.TabIndex = 4;
            this.domainUpDown1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad De Pasajeros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clase Turista";
            // 
            // chb_wifi
            // 
            this.chb_wifi.AutoSize = true;
            this.chb_wifi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_wifi.Enabled = false;
            this.chb_wifi.Location = new System.Drawing.Point(88, 45);
            this.chb_wifi.Name = "chb_wifi";
            this.chb_wifi.Size = new System.Drawing.Size(47, 19);
            this.chb_wifi.TabIndex = 9;
            this.chb_wifi.Text = "Wifi";
            this.chb_wifi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Incluye :";
            // 
            // chb_comida
            // 
            this.chb_comida.AutoSize = true;
            this.chb_comida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_comida.Enabled = false;
            this.chb_comida.Location = new System.Drawing.Point(147, 45);
            this.chb_comida.Name = "chb_comida";
            this.chb_comida.Size = new System.Drawing.Size(68, 19);
            this.chb_comida.TabIndex = 11;
            this.chb_comida.Text = "Comida";
            this.chb_comida.UseVisualStyleBackColor = true;
            // 
            // VenderPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 660);
            this.Controls.Add(this.chb_comida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chb_wifi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb_destino);
            this.Controls.Add(this.txb_origen);
            this.Controls.Add(this.txb_idVuelo);
            this.Name = "VenderPasaje";
            this.Text = "Vender Pasaje";
            this.Load += new System.EventHandler(this.VenderPasaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_idVuelo;
        private System.Windows.Forms.TextBox txb_origen;
        private System.Windows.Forms.TextBox txb_destino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chb_wifi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chb_comida;
    }
}