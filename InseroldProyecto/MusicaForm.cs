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
    public partial class MusicaForm : Form
    {
        private InseroldEntities1 db;
        bool Play = false;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

        public MusicaForm()
        {
            InitializeComponent();
            //LoadMusica(1);
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            if (CajaDeBusquedaDeArchivos.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
                rutasArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;
                foreach (var ArchivoMP3 in ArchivosMP3)
                {
                    LstCanciones.Items.Add(ArchivoMP3);
                }
                Reproductor.URL = rutasArchivosMP3[0];
                LstCanciones.SelectedIndex = 0;

            }
        }

        //private void LoadMusica(int indice)
        //{
        //    db = new InseroldEntities1();

        //    var query = from d in db.Musica
        //                where d.IDMusica == indice
        //                select d.TituloCancion;
        //    try
        //    {
        //        LstCanciones();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LstCanciones_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           Reproductor.URL = rutasArchivosMP3[LstCanciones.SelectedIndex];
        }
    }
}
