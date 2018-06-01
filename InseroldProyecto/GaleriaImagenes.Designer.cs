namespace InseroldProyecto
{
    partial class GaleriaImagenes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mostrar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Salir = new System.Windows.Forms.Button();
            this.Anterior = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.textid = new System.Windows.Forms.TextBox();
            this.Papelera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1484, 559);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(542, 609);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(177, 76);
            this.Mostrar.TabIndex = 1;
            this.Mostrar.Text = "Siguiente";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(1389, 665);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(121, 49);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(311, 609);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(179, 76);
            this.Anterior.TabIndex = 3;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(854, 609);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(176, 76);
            this.Eliminar.TabIndex = 4;
            this.Eliminar.Text = "Eliminar Imagen";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(88, 628);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 5;
            // 
            // Papelera
            // 
            this.Papelera.Location = new System.Drawing.Point(1087, 609);
            this.Papelera.Name = "Papelera";
            this.Papelera.Size = new System.Drawing.Size(167, 76);
            this.Papelera.TabIndex = 6;
            this.Papelera.Text = "Papelera";
            this.Papelera.UseVisualStyleBackColor = true;
            this.Papelera.Click += new System.EventHandler(this.Papelera_Click);
            // 
            // GaleriaImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 726);
            this.Controls.Add(this.Papelera);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Anterior);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GaleriaImagenes";
            this.Text = "GaleriaImagenes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Button Papelera;
    }
}