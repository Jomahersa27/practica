using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InseroldProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlocNotas_Click(object sender, EventArgs e)
        {
            Form frm = new BlocDeNotas();
            frm.Show();
        }

        private void Galeria_Click(object sender, EventArgs e)
        {
            Form frm = new GaleriaImagenes();
            frm.Show();
        }

        private void Musica_Click(object sender, EventArgs e)
        {
            Form frm = new MusicaForm();
            frm.Show();
        }
    }
}
