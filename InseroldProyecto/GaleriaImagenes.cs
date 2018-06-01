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
    public partial class GaleriaImagenes : Form
    {
        private InseroldEntities1 db;

        public GaleriaImagenes()
        {
            InitializeComponent();
            //LoadImagen(1);
            LoadImagen(1);
            
        }

        

        //private void LoadImagen(int indice)
        //{
        //    db = new InseroldEntities1();

        //    var query = from d in db.Galeria
        //                select d;
        //    try
        //    {
        //        pictureBox1.Load(query.ToArray().ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}


        private void LoadImagen(int indice)
        {
            db = new InseroldEntities1();

            var query = from d in db.Galeria
                        where d.IDImagen == indice
                        select d.Imagen;
            try
            {
                pictureBox1.Load(query.ToArray()[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int i = 1;
        private void Mostrar_Click(object sender, EventArgs e)
        {
            
            i++;
           LoadImagen(i);
          
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Anterior_Click(object sender, EventArgs e)
        {

            i--;
            LoadImagen(i);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            db = new InseroldEntities1();
            db.EliminarFoto(Convert.ToInt32(textid));
            EliminarFoto();

        }

        private void EliminarFoto()
        {

          

        }

        private void Papelera_Click(object sender, EventArgs e)
        {
            Form frm = new PapeleraReciclaje();
            frm.Show();
        }

        
    }
}
