namespace InseroldProyecto
{
    partial class PapeleraReciclaje
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
            this.RecuperarImagen = new System.Windows.Forms.Button();
            this.EliminarImagen = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecuperarImagen
            // 
            this.RecuperarImagen.Location = new System.Drawing.Point(180, 410);
            this.RecuperarImagen.Name = "RecuperarImagen";
            this.RecuperarImagen.Size = new System.Drawing.Size(146, 68);
            this.RecuperarImagen.TabIndex = 0;
            this.RecuperarImagen.Text = "Recuperar Imagen";
            this.RecuperarImagen.UseVisualStyleBackColor = true;
            // 
            // EliminarImagen
            // 
            this.EliminarImagen.Location = new System.Drawing.Point(479, 410);
            this.EliminarImagen.Name = "EliminarImagen";
            this.EliminarImagen.Size = new System.Drawing.Size(142, 68);
            this.EliminarImagen.TabIndex = 1;
            this.EliminarImagen.Text = "Eliminar Imagen";
            this.EliminarImagen.UseVisualStyleBackColor = true;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(759, 410);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(153, 68);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // PapeleraReciclaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 515);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.EliminarImagen);
            this.Controls.Add(this.RecuperarImagen);
            this.Name = "PapeleraReciclaje";
            this.Text = "PapeleraReciclaje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RecuperarImagen;
        private System.Windows.Forms.Button EliminarImagen;
        private System.Windows.Forms.Button Cerrar;
    }
}