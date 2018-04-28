namespace Graficosdetortuga
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
            this.button_avanzar = new System.Windows.Forms.Button();
            this.button_derecha = new System.Windows.Forms.Button();
            this.button_izquierda = new System.Windows.Forms.Button();
            this.button_mostrar = new System.Windows.Forms.Button();
            this.button_subir = new System.Windows.Forms.Button();
            this.button_bajar = new System.Windows.Forms.Button();
            this.button_fin = new System.Windows.Forms.Button();
            this.textBox_tab = new System.Windows.Forms.TextBox();
            this.textBox_pos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_avanzar
            // 
            this.button_avanzar.Location = new System.Drawing.Point(12, 12);
            this.button_avanzar.Name = "button_avanzar";
            this.button_avanzar.Size = new System.Drawing.Size(75, 23);
            this.button_avanzar.TabIndex = 0;
            this.button_avanzar.Text = "Avanzar";
            this.button_avanzar.UseVisualStyleBackColor = true;
            this.button_avanzar.Click += new System.EventHandler(this.button_avanzar_Click);
            // 
            // button_derecha
            // 
            this.button_derecha.Location = new System.Drawing.Point(12, 41);
            this.button_derecha.Name = "button_derecha";
            this.button_derecha.Size = new System.Drawing.Size(75, 23);
            this.button_derecha.TabIndex = 1;
            this.button_derecha.Text = "Derecha";
            this.button_derecha.UseVisualStyleBackColor = true;
            this.button_derecha.Click += new System.EventHandler(this.button_derecha_Click);
            // 
            // button_izquierda
            // 
            this.button_izquierda.Location = new System.Drawing.Point(12, 70);
            this.button_izquierda.Name = "button_izquierda";
            this.button_izquierda.Size = new System.Drawing.Size(75, 23);
            this.button_izquierda.TabIndex = 2;
            this.button_izquierda.Text = "Izquierda";
            this.button_izquierda.UseVisualStyleBackColor = true;
            this.button_izquierda.Click += new System.EventHandler(this.button_izquierda_Click);
            // 
            // button_mostrar
            // 
            this.button_mostrar.Location = new System.Drawing.Point(106, 70);
            this.button_mostrar.Name = "button_mostrar";
            this.button_mostrar.Size = new System.Drawing.Size(75, 23);
            this.button_mostrar.TabIndex = 3;
            this.button_mostrar.Text = "Mostrar";
            this.button_mostrar.UseVisualStyleBackColor = true;
            this.button_mostrar.Click += new System.EventHandler(this.button_mostrar_Click);
            // 
            // button_subir
            // 
            this.button_subir.Location = new System.Drawing.Point(197, 12);
            this.button_subir.Name = "button_subir";
            this.button_subir.Size = new System.Drawing.Size(75, 23);
            this.button_subir.TabIndex = 4;
            this.button_subir.Text = "Subir pluma";
            this.button_subir.UseVisualStyleBackColor = true;
            this.button_subir.Click += new System.EventHandler(this.button_subir_Click);
            // 
            // button_bajar
            // 
            this.button_bajar.Location = new System.Drawing.Point(197, 41);
            this.button_bajar.Name = "button_bajar";
            this.button_bajar.Size = new System.Drawing.Size(75, 23);
            this.button_bajar.TabIndex = 5;
            this.button_bajar.Text = "Bajar pluma";
            this.button_bajar.UseVisualStyleBackColor = true;
            this.button_bajar.Click += new System.EventHandler(this.button_bajar_Click);
            // 
            // button_fin
            // 
            this.button_fin.Location = new System.Drawing.Point(197, 70);
            this.button_fin.Name = "button_fin";
            this.button_fin.Size = new System.Drawing.Size(75, 23);
            this.button_fin.TabIndex = 6;
            this.button_fin.Text = "Fin";
            this.button_fin.UseVisualStyleBackColor = true;
            this.button_fin.Click += new System.EventHandler(this.button_fin_Click);
            // 
            // textBox_tab
            // 
            this.textBox_tab.Location = new System.Drawing.Point(37, 99);
            this.textBox_tab.Multiline = true;
            this.textBox_tab.Name = "textBox_tab";
            this.textBox_tab.Size = new System.Drawing.Size(208, 169);
            this.textBox_tab.TabIndex = 7;
            // 
            // textBox_pos
            // 
            this.textBox_pos.Location = new System.Drawing.Point(106, 41);
            this.textBox_pos.Name = "textBox_pos";
            this.textBox_pos.Size = new System.Drawing.Size(68, 20);
            this.textBox_pos.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 309);
            this.Controls.Add(this.textBox_pos);
            this.Controls.Add(this.textBox_tab);
            this.Controls.Add(this.button_fin);
            this.Controls.Add(this.button_bajar);
            this.Controls.Add(this.button_subir);
            this.Controls.Add(this.button_mostrar);
            this.Controls.Add(this.button_izquierda);
            this.Controls.Add(this.button_derecha);
            this.Controls.Add(this.button_avanzar);
            this.Name = "Form1";
            this.Text = "Tortuga";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_avanzar;
        private System.Windows.Forms.Button button_derecha;
        private System.Windows.Forms.Button button_izquierda;
        private System.Windows.Forms.Button button_mostrar;
        private System.Windows.Forms.Button button_subir;
        private System.Windows.Forms.Button button_bajar;
        private System.Windows.Forms.Button button_fin;
        private System.Windows.Forms.TextBox textBox_tab;
        private System.Windows.Forms.TextBox textBox_pos;
    }
}

