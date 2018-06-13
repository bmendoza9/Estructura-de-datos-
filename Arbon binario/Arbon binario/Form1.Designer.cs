namespace Arbon_binario
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_agregar = new System.Windows.Forms.Button();
            this.button_post = new System.Windows.Forms.Button();
            this.button_pre = new System.Windows.Forms.Button();
            this.button_resolver = new System.Windows.Forms.Button();
            this.textBox_res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(12, 46);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(372, 20);
            this.textBox_input.TabIndex = 0;
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(12, 153);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.Size = new System.Drawing.Size(372, 85);
            this.textBox_output.TabIndex = 1;
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(155, 12);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 23);
            this.button_agregar.TabIndex = 2;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // button_post
            // 
            this.button_post.Location = new System.Drawing.Point(93, 112);
            this.button_post.Name = "button_post";
            this.button_post.Size = new System.Drawing.Size(75, 23);
            this.button_post.TabIndex = 3;
            this.button_post.Text = "Postorder";
            this.button_post.UseVisualStyleBackColor = true;
            this.button_post.Click += new System.EventHandler(this.button_post_Click);
            // 
            // button_pre
            // 
            this.button_pre.Location = new System.Drawing.Point(12, 112);
            this.button_pre.Name = "button_pre";
            this.button_pre.Size = new System.Drawing.Size(75, 23);
            this.button_pre.TabIndex = 4;
            this.button_pre.Text = "Preorder";
            this.button_pre.UseVisualStyleBackColor = true;
            this.button_pre.Click += new System.EventHandler(this.button_pre_Click);
            // 
            // button_resolver
            // 
            this.button_resolver.Location = new System.Drawing.Point(12, 244);
            this.button_resolver.Name = "button_resolver";
            this.button_resolver.Size = new System.Drawing.Size(57, 27);
            this.button_resolver.TabIndex = 5;
            this.button_resolver.Text = "Resolver";
            this.button_resolver.UseVisualStyleBackColor = true;
            this.button_resolver.Click += new System.EventHandler(this.button_resolver_Click);
            // 
            // textBox_res
            // 
            this.textBox_res.Location = new System.Drawing.Point(12, 277);
            this.textBox_res.Name = "textBox_res";
            this.textBox_res.Size = new System.Drawing.Size(100, 20);
            this.textBox_res.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 324);
            this.Controls.Add(this.textBox_res);
            this.Controls.Add(this.button_resolver);
            this.Controls.Add(this.button_pre);
            this.Controls.Add(this.button_post);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.textBox_output);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Button button_post;
        private System.Windows.Forms.Button button_pre;
        private System.Windows.Forms.Button button_resolver;
        private System.Windows.Forms.TextBox textBox_res;
    }
}

