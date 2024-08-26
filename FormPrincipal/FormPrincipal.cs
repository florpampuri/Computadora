using FormExamen;
using MisClases;

namespace FormPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private List<Computadora> listaComputadoras;

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.listaComputadoras = new List<Computadora>();
            this.listaComputadoras = new List<Computadora>()
            {
                new Computadora(16,240,"procesador1","Linux", 1),
                new Computadora(32,240,"procesador2","MacOS", 2),
                new Computadora(16,240,"procesador3","Windows", 3),
                new Computadora(32,240,"procesador4","Linux", 4),
                new Computadora(16,240,"procesador5","Windows", 5),

            };

            dgv_principal.DataSource = null;
            dgv_principal.DataSource = listaComputadoras;
        }

        //Boton agregar
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormAlta formAlta = new FormAlta();
            formAlta.ShowDialog();

            if (formAlta.DialogResult == DialogResult.OK)
            {
                listaComputadoras.Add(formAlta.MiPC);
            }

            dgv_principal.DataSource = null;
            dgv_principal.DataSource = listaComputadoras;
        }


        //Boton modificar
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Computadora pcEditar = dgv_principal.CurrentRow.DataBoundItem as Computadora;

            FormModificar modificar = new FormModificar(pcEditar);

            modificar.ShowDialog();

            if (modificar.DialogResult == DialogResult.OK)
            {

                int index = -1;
                foreach (Computadora item in listaComputadoras)
                {
                    if (item.NumeroDeSerie == modificar.MiPc.NumeroDeSerie)
                    {
                        index = listaComputadoras.IndexOf(item);
                    }
                }

                if (index != -1)
                {
                    this.listaComputadoras[index] = modificar.MiPc;
                }

               
                dgv_principal.DataSource = null;
                dgv_principal.DataSource = listaComputadoras;
            }




            //int index = this.listaComputadoras.FindIndex(pcBuscar => pcBuscar.NumeroDeSerie == modificar.MiPC.NumeroDeSerie);
            //this.listaComputadoras[index] = btn_modificar.MiPC;


            //DataGridViewRow rows = dgv_principal.SelectedRows[0];

            ////Tengo que convertir todo a los valores necesarios
            //Computadora pc = new Computadora(
            //    Convert.ToInt32(rows.Cells["CapacidadDisco"].Value),
            //    Convert.ToInt32(rows.Cells["MemoriaRam"].Value),
            //    rows.Cells["Procesador"].Value.ToString(),
            //    rows.Cells["SistemaOperativo"].Value.ToString(),
            //    Convert.ToInt32(rows.Cells["NumeroDeSerie"].Value)
            //);


        }

        //Boton eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Computadora pcEliminar = dgv_principal.CurrentRow.DataBoundItem as Computadora;

            DialogResult respuesta = MessageBox.Show($"¿Está seguro de que desea eliminar la pc con número de serie {pcEliminar.NumeroDeSerie}?",
                "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //int index = -1;
            
            if (respuesta == DialogResult.OK)
            {
                //foreach (Computadora item in this.listaComputadoras)
                //{
                //    index = listaComputadoras.IndexOf(item);
                //}
                
                listaComputadoras.Remove(pcEliminar);
            }
            dgv_principal.DataSource = null;
            dgv_principal.DataSource = listaComputadoras;
        }
    }
}
