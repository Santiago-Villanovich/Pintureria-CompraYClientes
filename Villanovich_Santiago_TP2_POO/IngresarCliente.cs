using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Villanovich_Santiago_TP2_POO
{
    public partial class IngresarCliente : Form
    {
        public IngresarCliente()
        {
            InitializeComponent();
        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            string nombre, apellido, domicilio;
            int dni;
            double telefono;

            try
            {
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                dni =Convert.ToInt32(txtDni.Text);
                telefono = Convert.ToDouble(txtTelefono.Text);
                domicilio = txtDomicilio.Text;

                clsCliente oCliente = new clsCliente(nombre, apellido, dni, telefono, domicilio);

                GenerarCompra.ListClientes.Add(oCliente);

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
    }
    }
}
