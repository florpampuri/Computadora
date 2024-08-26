using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MisClases;

namespace FormExamen
{
    public partial class FormAlta : Form
    {
        private Computadora miPC;
        public Computadora MiPC { get => miPC; }

        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            this.cb_procesador.DataSource = Computadora.ListadoDeProcesadores();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            int capacidadDisco;
            int memoriaRam;    
            string procesador = string.Empty;
            string sistemaOperativo = string.Empty;
            int numeroDeSerie = (int)this.num_nserie.Value;

            memoriaRam = (int)this.num_memoria.Value;
            capacidadDisco = (int)this.num_disco.Value;
            procesador = this.cb_procesador.Text;

            foreach (RadioButton rdb in this.gb_sistema.Controls)
            {
                if (rdb.Checked)
                {
                    sistemaOperativo = rdb.Text;
                    break;
                }
            }

            this.miPC = new Computadora(memoriaRam, capacidadDisco, procesador, sistemaOperativo, numeroDeSerie);

            foreach (CheckBox ck in this.gb_programas.Controls)
            {
                if (ck.Checked)
                {
                    this.miPC.SetPrograma(ck.Text);
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
