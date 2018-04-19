namespace Matricesclase
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_llenar = new System.Windows.Forms.Button();
            this.button_llenarcol = new System.Windows.Forms.Button();
            this.button_llenarinv = new System.Windows.Forms.Button();
            this.button_mostrar = new System.Windows.Forms.Button();
            this.button_mostrarDP = new System.Windows.Forms.Button();
            this.button_mostrarDS = new System.Windows.Forms.Button();
            this.button_abajoDP = new System.Windows.Forms.Button();
            this.button_abajoDS = new System.Windows.Forms.Button();
            this.button_intercambiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 174);
            this.textBox1.TabIndex = 0;
            // 
            // button_llenar
            // 
            this.button_llenar.Location = new System.Drawing.Point(12, 12);
            this.button_llenar.Name = "button_llenar";
            this.button_llenar.Size = new System.Drawing.Size(75, 23);
            this.button_llenar.TabIndex = 1;
            this.button_llenar.Text = "Llenar";
            this.button_llenar.UseVisualStyleBackColor = true;
            this.button_llenar.Click += new System.EventHandler(this.button_llenar_Click);
            // 
            // button_llenarcol
            // 
            this.button_llenarcol.Location = new System.Drawing.Point(117, 12);
            this.button_llenarcol.Name = "button_llenarcol";
            this.button_llenarcol.Size = new System.Drawing.Size(75, 43);
            this.button_llenarcol.TabIndex = 2;
            this.button_llenarcol.Text = "Llenar por columnas";
            this.button_llenarcol.UseVisualStyleBackColor = true;
            this.button_llenarcol.Click += new System.EventHandler(this.button_llenarcol_Click);
            // 
            // button_llenarinv
            // 
            this.button_llenarinv.Location = new System.Drawing.Point(198, 12);
            this.button_llenarinv.Name = "button_llenarinv";
            this.button_llenarinv.Size = new System.Drawing.Size(75, 43);
            this.button_llenarinv.TabIndex = 3;
            this.button_llenarinv.Text = "Llenar inverso";
            this.button_llenarinv.UseVisualStyleBackColor = true;
            this.button_llenarinv.Click += new System.EventHandler(this.button_llenarinv_Click);
            // 
            // button_mostrar
            // 
            this.button_mostrar.Location = new System.Drawing.Point(12, 61);
            this.button_mostrar.Name = "button_mostrar";
            this.button_mostrar.Size = new System.Drawing.Size(75, 23);
            this.button_mostrar.TabIndex = 4;
            this.button_mostrar.Text = "Mostrar";
            this.button_mostrar.UseVisualStyleBackColor = true;
            this.button_mostrar.Click += new System.EventHandler(this.button_mostrar_Click);
            // 
            // button_mostrarDP
            // 
            this.button_mostrarDP.Location = new System.Drawing.Point(117, 61);
            this.button_mostrarDP.Name = "button_mostrarDP";
            this.button_mostrarDP.Size = new System.Drawing.Size(75, 23);
            this.button_mostrarDP.TabIndex = 5;
            this.button_mostrarDP.Text = "Mostrar DP";
            this.button_mostrarDP.UseVisualStyleBackColor = true;
            this.button_mostrarDP.Click += new System.EventHandler(this.button_mostrarDP_Click);
            // 
            // button_mostrarDS
            // 
            this.button_mostrarDS.Location = new System.Drawing.Point(223, 61);
            this.button_mostrarDS.Name = "button_mostrarDS";
            this.button_mostrarDS.Size = new System.Drawing.Size(75, 23);
            this.button_mostrarDS.TabIndex = 6;
            this.button_mostrarDS.Text = "Mostrar DS";
            this.button_mostrarDS.UseVisualStyleBackColor = true;
            this.button_mostrarDS.Click += new System.EventHandler(this.button_mostrarDS_Click);
            // 
            // button_abajoDP
            // 
            this.button_abajoDP.Location = new System.Drawing.Point(315, 61);
            this.button_abajoDP.Name = "button_abajoDP";
            this.button_abajoDP.Size = new System.Drawing.Size(75, 23);
            this.button_abajoDP.TabIndex = 7;
            this.button_abajoDP.Text = "Abajo DP";
            this.button_abajoDP.UseVisualStyleBackColor = true;
            this.button_abajoDP.Click += new System.EventHandler(this.button_abajoDP_Click);
            // 
            // button_abajoDS
            // 
            this.button_abajoDS.Location = new System.Drawing.Point(410, 61);
            this.button_abajoDS.Name = "button_abajoDS";
            this.button_abajoDS.Size = new System.Drawing.Size(75, 23);
            this.button_abajoDS.TabIndex = 8;
            this.button_abajoDS.Text = "Abajo DS";
            this.button_abajoDS.UseVisualStyleBackColor = true;
            this.button_abajoDS.Click += new System.EventHandler(this.button_abajoDS_Click);
            // 
            // button_intercambiar
            // 
            this.button_intercambiar.Location = new System.Drawing.Point(285, 12);
            this.button_intercambiar.Name = "button_intercambiar";
            this.button_intercambiar.Size = new System.Drawing.Size(105, 23);
            this.button_intercambiar.TabIndex = 9;
            this.button_intercambiar.Text = "Intercambiar DP";
            this.button_intercambiar.UseVisualStyleBackColor = true;
            this.button_intercambiar.Click += new System.EventHandler(this.button_intercambiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Intercambiar DS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_intercambiar);
            this.Controls.Add(this.button_abajoDS);
            this.Controls.Add(this.button_abajoDP);
            this.Controls.Add(this.button_mostrarDS);
            this.Controls.Add(this.button_mostrarDP);
            this.Controls.Add(this.button_mostrar);
            this.Controls.Add(this.button_llenarinv);
            this.Controls.Add(this.button_llenarcol);
            this.Controls.Add(this.button_llenar);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Matriz 6x6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_llenar;
        private System.Windows.Forms.Button button_llenarcol;
        private System.Windows.Forms.Button button_llenarinv;
        private System.Windows.Forms.Button button_mostrar;
        private System.Windows.Forms.Button button_mostrarDP;
        private System.Windows.Forms.Button button_mostrarDS;
        private System.Windows.Forms.Button button_abajoDP;
        private System.Windows.Forms.Button button_abajoDS;
        private System.Windows.Forms.Button button_intercambiar;
        private System.Windows.Forms.Button button1;
    }
}

