using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonceDeLeonGestion
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f = new frmMain();
            f.Show();
                
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarRegistro_Click(object sender, EventArgs e)
        {

            
            string[] vectorRegistarActividad = new string[10];

            string reunion, datoConcatenado; 

            if (optSiReunion.Checked = true)
            {
                reunion = "hay reunion";
            }
            else
            {
                reunion = "no hay reunion";
            }

            datoConcatenado =
                            dtpFechaDeRegistro.Value + ", " +
                            lblTipoDeActividad.Text + ", " +
                            txtDetalleActividad.Text + ", " +
                            reunion;

            if (dtpFechaDeRegistro.Value >= DateTime.Today) {
                if (cboTipoDeActividad.SelectedIndex != -1)
                {
                    if (txtDetalleActividad.Text != "")
                    {
                        //MessageBox.Show("Vamos a guardar :D", "Guardando...");
                        int i;
                        i = 0;

                        vectorRegistarActividad[i] = datoConcatenado;
               
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("Te falta detallar la actividad pichón", "Detelle de Actividad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDetalleActividad.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione ua actividad >:c", "Seleciòn Actividad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTipoDeActividad.Focus();
                }
            }
            else
            {                        // mensaje                       -nombre de la ventana   -boton de la vent   -icono de ventana
                MessageBox.Show("Seleciona una fecha de hoy en adelante","Carga de Tareas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDeRegistro.Value = DateTime.Today;
                dtpFechaDeRegistro.Focus();
            }

        }
    }
}
