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
        public string[] vectorRegistarActividad = new string[10];
        int i = 0;
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
        void limpiar()
        {
            dtpFechaDeRegistro.Value = DateTime.Today;
            txtDetalleActividad.Text = " ";
            cboTipoDeActividad.Text = "";

            if (optSiReunion.Checked == true)
            {
                optSiReunion.Checked = false;
            }
            else
            {
                optNoReunion.Checked = false;
            }     

            if (chkRepositorio.Checked == true)
            {

                chkRepositorio.Checked = false;
            }

            if (chkInvestigacion.Checked == true)
            {

                chkInvestigacion.Checked = false;
            }

            if (chkNotasReunion.Checked == true)
            {

                chkNotasReunion.Checked = false;
            }
            if (chkDebate.Checked == true)
            {

                chkDebate.Checked = false;
            }


        }

        private void btnRegistrarRegistro_Click(object sender, EventArgs e)
        {

            string reunion, datoConcatenado,tareaConcatenada = ""; 

            if (optSiReunion.Checked == true)
            {
                reunion = "Hay reunión";
            }
            else
            {
                reunion = "No hay reunión";
            }

            if (chkRepositorio.Checked == true)
            {
              
                tareaConcatenada+= "Repositorio, ";
            }

            if (chkInvestigacion.Checked == true)
            {
                
                tareaConcatenada += "Investigación, ";
            }

            if (chkNotasReunion.Checked == true)
            {
                
                tareaConcatenada += "Notas reunión, ";
            }
            if (chkDebate.Checked == true)
            {

                tareaConcatenada += "Debate, ";
            }


            datoConcatenado =
                            dtpFechaDeRegistro.Value + ", " +
                            lblTipoDeActividad.Text + ", " +
                            txtDetalleActividad.Text + ", " +
                            reunion + tareaConcatenada;

            if (dtpFechaDeRegistro.Value >= DateTime.Today) {
                if (cboTipoDeActividad.SelectedIndex != -1)
                {
                    if (txtDetalleActividad.Text != "")
                    {
                        
                        

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
                    MessageBox.Show("Seleccione una actividad >:c", "Seleciòn Actividad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboTipoDeActividad.Focus();
                }
            }
            else
            {                        // mensaje                       -nombre de la ventana   -boton de la vent   -icono de ventana
                MessageBox.Show("Seleciona una fecha de hoy en adelante","Carga de Tareas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDeRegistro.Value = DateTime.Today;
                dtpFechaDeRegistro.Focus();
            }

            limpiar();



    }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            //creo al ventana y en la ventana muestro el vector hecho
            frmMostrar fMostra = new frmMostrar();

            for (int i = 0; i < vectorRegistarActividad.Length; i++)
            {
                fMostra.vectorRegistarActividad[i] = vectorRegistarActividad[i];

            }

            fMostra.ShowDialog();
        }

        private void cboTipoDeActividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
