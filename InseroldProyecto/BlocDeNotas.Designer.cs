namespace InseroldProyecto
{
    partial class BlocDeNotas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cerrar = new System.Windows.Forms.Button();
            this.NotaNueva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1243, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(1153, 420);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(151, 63);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // NotaNueva
            // 
            this.NotaNueva.Location = new System.Drawing.Point(884, 424);
            this.NotaNueva.Name = "NotaNueva";
            this.NotaNueva.Size = new System.Drawing.Size(212, 59);
            this.NotaNueva.TabIndex = 2;
            this.NotaNueva.Text = "NotaNueva";
            this.NotaNueva.UseVisualStyleBackColor = true;
            this.NotaNueva.Click += new System.EventHandler(this.NotaNueva_Click);
            // 
            // BlocDeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 495);
            this.Controls.Add(this.NotaNueva);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BlocDeNotas";
            this.Text = "BlocDeNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button NotaNueva;
    }
}