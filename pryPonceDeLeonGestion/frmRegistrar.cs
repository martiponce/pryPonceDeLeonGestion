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
    }
}
