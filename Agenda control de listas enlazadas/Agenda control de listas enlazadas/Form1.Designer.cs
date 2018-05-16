namespace Agenda_control_de_listas_enlazadas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_buscar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_agregar = new System.Windows.Forms.Button();
            this.button_listar = new System.Windows.Forms.Button();
            this.button_insertar = new System.Windows.Forms.Button();
            this.button_eliminarprimero = new System.Windows.Forms.Button();
            this.button_eliminarultimo = new System.Windows.Forms.Button();
            this.button_invertirlista = new System.Windows.Forms.Button();
            this.button_mostrarinverso = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.txt_pos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(0, 29);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 0;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(0, 55);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_eliminar.TabIndex = 1;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(0, 1);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 23);
            this.button_agregar.TabIndex = 2;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // button_listar
            // 
            this.button_listar.Location = new System.Drawing.Point(0, 116);
            this.button_listar.Name = "button_listar";
            this.button_listar.Size = new System.Drawing.Size(75, 23);
            this.button_listar.TabIndex = 3;
            this.button_listar.Text = "Listar";
            this.button_listar.UseVisualStyleBackColor = true;
            this.button_listar.Click += new System.EventHandler(this.button_listar_Click);
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(0, 87);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(75, 23);
            this.button_insertar.TabIndex = 5;
            this.button_insertar.Text = "Insertar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // button_eliminarprimero
            // 
            this.button_eliminarprimero.Location = new System.Drawing.Point(0, 174);
            this.button_eliminarprimero.Name = "button_eliminarprimero";
            this.button_eliminarprimero.Size = new System.Drawing.Size(101, 23);
            this.button_eliminarprimero.TabIndex = 6;
            this.button_eliminarprimero.Text = "Eliminar primero";
            this.button_eliminarprimero.UseVisualStyleBackColor = true;
            this.button_eliminarprimero.Click += new System.EventHandler(this.button_eliminarprimero_Click);
            // 
            // button_eliminarultimo
            // 
            this.button_eliminarultimo.Location = new System.Drawing.Point(0, 203);
            this.button_eliminarultimo.Name = "button_eliminarultimo";
            this.button_eliminarultimo.Size = new System.Drawing.Size(101, 23);
            this.button_eliminarultimo.TabIndex = 7;
            this.button_eliminarultimo.Text = "Eliminar último";
            this.button_eliminarultimo.UseVisualStyleBackColor = true;
            this.button_eliminarultimo.Click += new System.EventHandler(this.button_eliminarultimo_Click);
            // 
            // button_invertirlista
            // 
            this.button_invertirlista.Location = new System.Drawing.Point(0, 232);
            this.button_invertirlista.Name = "button_invertirlista";
            this.button_invertirlista.Size = new System.Drawing.Size(75, 23);
            this.button_invertirlista.TabIndex = 8;
            this.button_invertirlista.Text = "Invertir lista";
            this.button_invertirlista.UseVisualStyleBackColor = true;
            this.button_invertirlista.Click += new System.EventHandler(this.button_invertirlista_Click);
            // 
            // button_mostrarinverso
            // 
            this.button_mostrarinverso.Location = new System.Drawing.Point(0, 261);
            this.button_mostrarinverso.Name = "button_mostrarinverso";
            this.button_mostrarinverso.Size = new System.Drawing.Size(101, 23);
            this.button_mostrarinverso.TabIndex = 9;
            this.button_mostrarinverso.Text = "Mostrar Inverso";
            this.button_mostrarinverso.UseVisualStyleBackColor = true;
            this.button_mostrarinverso.Click += new System.EventHandler(this.button_mostrarinverso_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Location = new System.Drawing.Point(150, 31);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApPaterno.TabIndex = 11;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Location = new System.Drawing.Point(150, 57);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApMaterno.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(150, 83);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(150, 109);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 14;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(150, 135);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Edad";
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(107, 161);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(332, 175);
            this.txtMostrar.TabIndex = 22;
            // 
            // txt_pos
            // 
            this.txt_pos.Location = new System.Drawing.Point(367, 119);
            this.txt_pos.Name = "txt_pos";
            this.txt_pos.Size = new System.Drawing.Size(46, 20);
            this.txt_pos.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Posición";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 353);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_pos);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApMaterno);
            this.Controls.Add(this.txtApPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button_mostrarinverso);
            this.Controls.Add(this.button_invertirlista);
            this.Controls.Add(this.button_eliminarultimo);
            this.Controls.Add(this.button_eliminarprimero);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.button_listar);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_buscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Button button_listar;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.Button button_eliminarprimero;
        private System.Windows.Forms.Button button_eliminarultimo;
        private System.Windows.Forms.Button button_invertirlista;
        private System.Windows.Forms.Button button_mostrarinverso;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.TextBox txt_pos;
        private System.Windows.Forms.Label label7;
    }
}

