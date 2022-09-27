
namespace Vista
{
    partial class Loguin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.txb_clave = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_autocompletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(155, 65);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.Size = new System.Drawing.Size(431, 23);
            this.txb_usuario.TabIndex = 0;
            // 
            // txb_clave
            // 
            this.txb_clave.Location = new System.Drawing.Point(159, 170);
            this.txb_clave.Name = "txb_clave";
            this.txb_clave.Size = new System.Drawing.Size(427, 23);
            this.txb_clave.TabIndex = 1;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(586, 305);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(148, 42);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(93, 305);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(124, 41);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_autocompletar
            // 
            this.btn_autocompletar.Location = new System.Drawing.Point(322, 272);
            this.btn_autocompletar.Name = "btn_autocompletar";
            this.btn_autocompletar.Size = new System.Drawing.Size(135, 23);
            this.btn_autocompletar.TabIndex = 4;
            this.btn_autocompletar.Text = "Autocompletar";
            this.btn_autocompletar.UseVisualStyleBackColor = true;
            this.btn_autocompletar.Click += new System.EventHandler(this.btn_autocompletar_Click);
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_autocompletar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txb_clave);
            this.Controls.Add(this.txb_usuario);
            this.Name = "Loguin";
            this.Text = "Loguin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.TextBox txb_clave;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_autocompletar;
    }
}

