﻿using System;
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
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void btnVolverMostrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.Show();
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {

        }

        private void cboActividadMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboActividadMostrar.Items.Add(datoConcatenado);
        }
    }
}
