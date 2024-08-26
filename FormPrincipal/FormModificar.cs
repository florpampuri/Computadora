using MisClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExamen
{
    public partial class FormModificar : Form
    {

        private Computadora miPc;

        //property
        public Computadora MiPc
        {
            set { miPc = value; }
            get { return miPc; }
        }


        //constructor parametrizado
        public FormModificar()
        {
            InitializeComponent();
        }

        //2do constructor que llama al constructor vacio con el :this()
        public FormModificar(Computadora pc) : this()
        {
            this.miPc = pc;
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            cb_procesador.DataSource = Computadora.ListadoDeProcesadores();

            cb_procesador.Text = this.miPc.Procesador;
            num_memoria.Value = this.miPc.MemoriaRam;
            num_disco.Value = this.miPc.CapacidadDisco;
            num_nserie.Value = this.miPc.NumeroDeSerie;


            foreach (RadioButton rdb in gb_sistema.Controls)
            {
                if (rdb.Text.ToLower() == miPc.SistemaOperativo.ToLower())
                {
                    rdb.Checked = true;
                    break;
                }
            }

            foreach (CheckBox chk in gb_programas.Controls)
            {
                foreach (string item in miPc.GetProgramas())
                {
                    if (chk.Text.ToLower() == item.ToLower())
                    {
                        chk.Checked = true;
                        break;
                    }
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int capacidadDisco;
            int memoriaRam;
            string procesador = string.Empty;
            string sistemaOperativo = string.Empty;
            int numeroDeSerie = (int)num_nserie.Value;

            capacidadDisco = (int)this.num_disco.Value;
            memoriaRam = (int)this.num_memoria.Value;
            procesador = this.cb_procesador.Text;

            foreach (RadioButton componente in this.gb_sistema.Controls)
            {
                if (componente.Checked)
                {
                    sistemaOperativo = componente.Text;
                    break;
                }
            }

            this.miPc = new Computadora(memoriaRam, capacidadDisco, procesador, sistemaOperativo, numeroDeSerie);

            foreach (CheckBox item in this.gb_programas.Controls)
            {
                if (item.Checked)
                {
                    this.miPc.SetPrograma(item.Text);
                }
            }

            if (memoriaRam != 0
                && capacidadDisco != 0
                && !string.IsNullOrEmpty(procesador)
                && !string.IsNullOrEmpty(sistemaOperativo))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe seleccionar por lo menos un valor de cada item", "Faltan datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
