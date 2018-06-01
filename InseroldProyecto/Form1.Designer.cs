namespace InseroldProyecto
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
            this.BlocNotas = new System.Windows.Forms.Button();
            this.Galeria = new System.Windows.Forms.Button();
            this.Musica = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlocNotas
            // 
            this.BlocNotas.Location = new System.Drawing.Point(228, 42);
            this.BlocNotas.Name = "BlocNotas";
            this.BlocNotas.Size = new System.Drawing.Size(343, 81);
            this.BlocNotas.TabIndex = 0;
            this.BlocNotas.Text = "BlocNotas";
            this.BlocNotas.UseVisualStyleBackColor = true;
            this.BlocNotas.Click += new System.EventHandler(this.BlocNotas_Click);
            // 
            // Galeria
            // 
            this.Galeria.Location = new System.Drawing.Point(228, 149);
            this.Galeria.Name = "Galeria";
            this.Galeria.Size = new System.Drawing.Size(343, 80);
            this.Galeria.TabIndex = 1;
            this.Galeria.Text = "Galeria";
            this.Galeria.UseVisualStyleBackColor = true;
            this.Galeria.Click += new System.EventHandler(this.Galeria_Click);
            // 
            // Musica
            // 
            this.Musica.Location = new System.Drawing.Point(228, 251);
            this.Musica.Name = "Musica";
            this.Musica.Size = new System.Drawing.Size(343, 84);
            this.Musica.TabIndex = 2;
            this.Musica.Text = "Musica";
            this.Musica.UseVisualStyleBackColor = true;
            this.Musica.Click += new System.EventHandler(this.Musica_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(622, 331);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(98, 72);
            this.Salir.TabIndex = 3;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Musica);
            this.Controls.Add(this.Galeria);
            this.Controls.Add(this.BlocNotas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BlocNotas;
        private System.Windows.Forms.Button Galeria;
        private System.Windows.Forms.Button Musica;
        private System.Windows.Forms.Button Salir;
    }
}

