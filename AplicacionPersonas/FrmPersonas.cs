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
    public partial class FrmPersonas : Form
    {
        public FrmPersonas()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //lo que esta habilita se deshabilita
            BtnNuevo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnSalir.Enabled = false;
            //lo que esta deshabilitado se habilita
            BtnGuardar.Enabled = true;
            BtnDeshacer.Enabled = true;
            TxtID.Enabled = true;
            TxtNombre.Enabled = true;
            TxtTelefono.Enabled = true;
            //limpiar los texbox
            TxtID.Text = string.Empty;
            TxtNombre.Text = "";
            TxtTelefono.Clear();
            //envio foco del cursor
            TxtID.Focus();
        }

        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            //lo que esta deshabilitado se habilita
            BtnNuevo.Enabled = true;
            BtnEditar.Enabled = true;
            BtnEliminar.Enabled = true;
            BtnSalir.Enabled = true;
            //lo que esta habilitado se deshabilita
            BtnGuardar.Enabled = false;
            BtnDeshacer.Enabled = false;
            TxtID.Enabled = false;
            TxtNombre.Enabled = false;
            TxtTelefono.Enabled = false;
            //envio foco del cursor
            BtnNuevo.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //cerrar un formulario
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //las cajas de texto almacenan en la propiedad TEXT
            //valido si digitaron datos
            if (TxtID.Text == "" || TxtNombre.Text == "" || TxtTelefono.Text == "")
            {
                MessageBox.Show("Algunos Datos Estan Vacios Verifique y Vuelva a Guardar", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //llamo la funcion insertar
                if (ClaseFunciones.Func_Insertar(Convert.ToInt64(TxtID.Text),TxtNombre.Text,TxtTelefono.Text))
                {
                    MessageBox.Show("Datos Guardados", "Felicitaciones!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnDeshacer_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Hubo un Error, Excepcion: "+ClaseFunciones.excepcion, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            DgvPersonas.DataSource = ClaseFunciones.Func_TraerTodo();
        }
    }
}
