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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            string user = TxtUsuario.Text;
            string pass = TxtPassword.Text;
            if (user == "Admin" && pass == "12345")
            {
                //creo una instancia del formulario menu
                FrmMenuPrincipal f = new FrmMenuPrincipal();
                //oculto este formulario
                this.Hide();
                //muestro el formulario instanciado
                f.ShowDialog();
            }
            else
            {
                //mensaje,titulo,botones,icono
                MessageBox.Show("Usuario NO Valido", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
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
    }
}
