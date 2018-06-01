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
    public partial class NuevaNota : Form
    {
        private InseroldEntities1 db;

        public NuevaNota()
        {
            InitializeComponent();
            
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AñadirNota_Click(object sender, EventArgs e)
        {
            db = new InseroldEntities1();
            db.IntroducirNota(NotaGrande.Text, DTPFecha.Value);
                
        } 
    }
}
