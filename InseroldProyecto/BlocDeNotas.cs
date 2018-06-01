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
    public partial class BlocDeNotas : Form
    {
        private InseroldEntities1 db;

        public BlocDeNotas()
        {
            InitializeComponent();
            LoadNota();
        }

        private void LoadNota()
        {
            db = new InseroldEntities1();

            var query = from d in db.BLOCNOTAS
                        orderby d.IDNOTA
                        select d;
            try
            {
                this.dataGridView1.DataSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotaNueva_Click(object sender, EventArgs e)
        {
            Form frm = new NuevaNota();
            frm.Show();
        }
    }
}
