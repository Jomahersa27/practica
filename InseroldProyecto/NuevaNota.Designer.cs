namespace InseroldProyecto
{
    partial class NuevaNota
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
            this.label2 = new System.Windows.Forms.Label();
            this.NotaGrande = new System.Windows.Forms.RichTextBox();
            this.AñadirNota = new System.Windows.Forms.Button();
            this.FECHA = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEXTO";
            // 
            // NotaGrande
            // 
            this.NotaGrande.Location = new System.Drawing.Point(200, 34);
            this.NotaGrande.Name = "NotaGrande";
            this.NotaGrande.Size = new System.Drawing.Size(518, 155);
            this.NotaGrande.TabIndex = 2;
            this.NotaGrande.Text = "";
            // 
            // AñadirNota
            // 
            this.AñadirNota.Location = new System.Drawing.Point(200, 285);
            this.AñadirNota.Name = "AñadirNota";
            this.AñadirNota.Size = new System.Drawing.Size(218, 68);
            this.AñadirNota.TabIndex = 4;
            this.AñadirNota.Text = "AñadirNota";
            this.AñadirNota.UseVisualStyleBackColor = true;
            this.AñadirNota.Click += new System.EventHandler(this.AñadirNota_Click);
            // 
            // FECHA
            // 
            this.FECHA.AutoSize = true;
            this.FECHA.Location = new System.Drawing.Point(108, 234);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(42, 13);
            this.FECHA.TabIndex = 5;
            this.FECHA.Text = "FECHA";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(200, 234);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(218, 20);
            this.DTPFecha.TabIndex = 6;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(493, 285);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(225, 68);
            this.Cerrar.TabIndex = 7;
            this.Cerrar.Text = "salir";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // NuevaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.FECHA);
            this.Controls.Add(this.AñadirNota);
            this.Controls.Add(this.NotaGrande);
            this.Controls.Add(this.label2);
            this.Name = "NuevaNota";
            this.Text = "NuevaNota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox NotaGrande;
        private System.Windows.Forms.Button AñadirNota;
        private System.Windows.Forms.Label FECHA;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Button Cerrar;
    }
}