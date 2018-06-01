namespace InseroldProyecto
{
    partial class MusicaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicaForm));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.button2 = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.LstCanciones = new System.Windows.Forms.ListBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.Artista = new System.Windows.Forms.Label();
            this.Disco = new System.Windows.Forms.Label();
            this.Fecha_Produccion = new System.Windows.Forms.Label();
            this.Genero = new System.Windows.Forms.Label();
            this.TituloBox = new System.Windows.Forms.TextBox();
            this.artistaBox = new System.Windows.Forms.TextBox();
            this.discoBox = new System.Windows.Forms.TextBox();
            this.FechaBox = new System.Windows.Forms.TextBox();
            this.GeneroBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(12, 12);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(420, 134);
            this.Reproductor.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 225);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(1044, 409);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(146, 44);
            this.salir.TabIndex = 4;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // LstCanciones
            // 
            this.LstCanciones.FormattingEnabled = true;
            this.LstCanciones.Location = new System.Drawing.Point(23, 193);
            this.LstCanciones.Name = "LstCanciones";
            this.LstCanciones.Size = new System.Drawing.Size(211, 225);
            this.LstCanciones.TabIndex = 5;
            this.LstCanciones.SelectedIndexChanged += new System.EventHandler(this.LstCanciones_SelectedIndexChanged_1);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(654, 66);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(33, 13);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "Titulo";
            // 
            // Artista
            // 
            this.Artista.AutoSize = true;
            this.Artista.Location = new System.Drawing.Point(654, 133);
            this.Artista.Name = "Artista";
            this.Artista.Size = new System.Drawing.Size(36, 13);
            this.Artista.TabIndex = 7;
            this.Artista.Text = "Artista";
            // 
            // Disco
            // 
            this.Disco.AutoSize = true;
            this.Disco.Location = new System.Drawing.Point(654, 209);
            this.Disco.Name = "Disco";
            this.Disco.Size = new System.Drawing.Size(34, 13);
            this.Disco.TabIndex = 8;
            this.Disco.Text = "Disco";
            // 
            // Fecha_Produccion
            // 
            this.Fecha_Produccion.AutoSize = true;
            this.Fecha_Produccion.Location = new System.Drawing.Point(654, 287);
            this.Fecha_Produccion.Name = "Fecha_Produccion";
            this.Fecha_Produccion.Size = new System.Drawing.Size(94, 13);
            this.Fecha_Produccion.TabIndex = 9;
            this.Fecha_Produccion.Text = "Fecha Produccion";
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Location = new System.Drawing.Point(654, 356);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(42, 13);
            this.Genero.TabIndex = 10;
            this.Genero.Text = "Genero";
            // 
            // TituloBox
            // 
            this.TituloBox.Location = new System.Drawing.Point(841, 63);
            this.TituloBox.Name = "TituloBox";
            this.TituloBox.Size = new System.Drawing.Size(156, 20);
            this.TituloBox.TabIndex = 11;
            // 
            // artistaBox
            // 
            this.artistaBox.Location = new System.Drawing.Point(841, 133);
            this.artistaBox.Name = "artistaBox";
            this.artistaBox.Size = new System.Drawing.Size(156, 20);
            this.artistaBox.TabIndex = 12;
            // 
            // discoBox
            // 
            this.discoBox.Location = new System.Drawing.Point(841, 209);
            this.discoBox.Name = "discoBox";
            this.discoBox.Size = new System.Drawing.Size(156, 20);
            this.discoBox.TabIndex = 13;
            // 
            // FechaBox
            // 
            this.FechaBox.Location = new System.Drawing.Point(841, 287);
            this.FechaBox.Name = "FechaBox";
            this.FechaBox.Size = new System.Drawing.Size(156, 20);
            this.FechaBox.TabIndex = 14;
            // 
            // GeneroBox5
            // 
            this.GeneroBox5.Location = new System.Drawing.Point(841, 356);
            this.GeneroBox5.Name = "GeneroBox5";
            this.GeneroBox5.Size = new System.Drawing.Size(156, 20);
            this.GeneroBox5.TabIndex = 15;
            // 
            // MusicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 465);
            this.Controls.Add(this.GeneroBox5);
            this.Controls.Add(this.FechaBox);
            this.Controls.Add(this.discoBox);
            this.Controls.Add(this.artistaBox);
            this.Controls.Add(this.TituloBox);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Fecha_Produccion);
            this.Controls.Add(this.Disco);
            this.Controls.Add(this.Artista);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.LstCanciones);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Reproductor);
            this.Name = "MusicaForm";
            this.Text = "MusicaForm";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox LstCanciones;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Artista;
        private System.Windows.Forms.Label Disco;
        private System.Windows.Forms.Label Fecha_Produccion;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.TextBox TituloBox;
        private System.Windows.Forms.TextBox artistaBox;
        private System.Windows.Forms.TextBox discoBox;
        private System.Windows.Forms.TextBox FechaBox;
        private System.Windows.Forms.TextBox GeneroBox5;
    }
}