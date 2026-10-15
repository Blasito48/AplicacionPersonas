using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionPersonas
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rpta = new DialogResult();
            //Desea Salir?
            rpta = MessageBox.Show("Desea Salir de la Aplicacion?", "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rpta == DialogResult.OK)
            {
                //salir de la aplicacion
                Application.Exit();
            }
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonas f = new FrmPersonas();
            f.ShowDialog();
        }
    }
}
