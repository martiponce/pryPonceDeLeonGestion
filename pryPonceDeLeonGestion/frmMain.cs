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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrar f = new frmRegistrar();
            f.ShowDialog();

        
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMostrar f = new frmMostrar();
            f.ShowDialog();
        }
    }
}
