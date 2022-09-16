using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Villanovich_Santiago_TP2_POO.MisErrors;

namespace Villanovich_Santiago_TP2_POO
{
    public partial class Listado_de_Stock : Form
    {
        #region(Funciones)
        public void LimpiarCampos()
        {
            txtCodigoProduct.Clear();
            txtDescripProduct.Clear();
            txtMarcaProduct.Clear();
            txtColorProduct.Clear();
            numupPrecioProduct.Value = 0;
            numupStockProduct.Value = 0;
            cboxTipoProduct.SelectedItem = null;
            cboxVolumenProduct.SelectedItem = null;

            rbHerramientas.Checked = false;
            rbPinturas.Checked = false;
        }
       public void CargarDataGrid()
        {
            if (rbDgridPinturas.Checked == true)
            {
                dgridProductos.DataSource = null;
                dgridProductos.DataSource = listPinturas;
            }
            else if (rbDgridHerramientas.Checked == true)
            {
                dgridProductos.DataSource = null;
                dgridProductos.DataSource = listHerramientas;
            }

        }

        #endregion

        public Listado_de_Stock()
        {
            InitializeComponent();

            gboxPintura.Visible = false;
            txtCodigoProduct.MaxLength = 5;

            cboxVolumenProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxVolumenProduct.DataSource = Enum.GetValues(typeof(Volumenes));
            cboxTipoProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTipoProduct.DataSource = Enum.GetValues(typeof(TiposPintura));
            dgridProductos.MultiSelect = false;

            listPinturas = new List<clsPinturas>();
            listHerramientas = new List<clsVarios>();
            ListProducTotal = new List<clsProductos>();
        }

        int cod;
        string descrip, marca, color, volumen, tipo;
        double precio;

        public static List<clsPinturas> listPinturas;
        public static List<clsVarios> listHerramientas;
        public static List<clsProductos> ListProducTotal;

        clsPinturas oPintura;
        clsVarios oHerramienta;

        private void btnAñadirProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbDgridPinturas.Checked == true)
                {
                    oPintura = (clsPinturas)dgridProductos.CurrentRow.DataBoundItem;
                    oPintura.Stock += Convert.ToInt32(numupStockProduct.Value);
                }
                else if (rbDgridHerramientas.Checked == true)
                {
                    oHerramienta = (clsVarios)dgridProductos.CurrentRow.DataBoundItem;
                    oHerramienta.Stock += Convert.ToInt32(numupStockProduct.Value);
                }

                LimpiarCampos();
                CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
           
        }

        private void btnIngresarProduct_Click(object sender, EventArgs e)
        {
            try
            {
                cod = Convert.ToInt32(txtCodigoProduct.Text);
                descrip = txtDescripProduct.Text;
                marca = txtMarcaProduct.Text;
                if (numupPrecioProduct.Value > 0)
                {
                    precio = Convert.ToDouble(numupPrecioProduct.Value);
                }
                else
                {
                    throw new PersonalizedException();
                }

                if (rbPinturas.Checked == true)
                {
                    color = txtColorProduct.Text;
                    volumen = cboxVolumenProduct.SelectedItem.ToString();
                    tipo = cboxTipoProduct.SelectedItem.ToString();

                    
                    oPintura = new clsPinturas(cod, descrip, marca, precio, color, volumen, tipo);

                    ListProducTotal.Add(oPintura);
                    listPinturas.Add(oPintura);
                    LimpiarCampos();
                    CargarDataGrid();

                }
                else if (rbHerramientas.Checked == true)
                {
                    oHerramienta = new clsVarios(cod, descrip, marca, precio);

                    ListProducTotal.Add(oHerramienta);
                    listHerramientas.Add(oHerramienta);
                    LimpiarCampos();
                    CargarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region(RadioButtons)
        private void rbDgridPinturas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDgridPinturas.Checked == true)
            {
                CargarDataGrid();
            }
            
        }
        private void rbDgridHerramientas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDgridHerramientas.Checked == true)
            {
                CargarDataGrid();
            }
        }
        private void rbPinturas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPinturas.Checked == true)
            {
                gboxPintura.Visible = true;
            }
            else
            {
                gboxPintura.Visible = false;
            }
        }
        #endregion


       
    }
}
