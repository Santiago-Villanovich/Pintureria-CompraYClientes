using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Villanovich_Santiago_TP2_POO.CompraProductos;


namespace Villanovich_Santiago_TP2_POO
{
    public partial class GenerarCompra : Form
    {
        #region(Funciones)
        public void cargarCampos()
        {
            dgridUsuarios.DataSource = null;
            dgridUsuarios.DataSource = ListClientes;
            dgridUsuarios.Columns["Domicilio"].Visible = false;

            dgridCarrito.DataSource = null;
            dgridCarrito.DataSource = CarritoCompra.listaProductos;
            dgridCarrito.Columns["Marca"].Visible = false;
            //dgridProductos.Columns["Marca"].Visible = false;
        }
        public void cargarComboEmpleados()
        {
            cboxEmpleados.DataSource = ListEmpleados;

            cboxEmpleados.ValueMember = "DNI";
            cboxEmpleados.DisplayMember = "Apellio";
        }
        public void StockMax1(List<clsProductos> lista)
        {
            int cont1 = 0;
            List<clsProductos> lPin = lista.FindAll(item => item.GetType() == typeof(clsPinturas));
            lPin.OrderBy(clsPinturas => clsPinturas.Stock);
            if (lPin.Count != 0 )
            {
                cont1 = lPin.First().Stock;
                lbPinturas.Text = "Pintura de Max Stock: " + cont1.ToString();
            }
            else
            {
                lbPinturas.Text = "No hay pinturas en stock";
            }
            
        }
        public void StockMax2(List<clsProductos> lista)
        {
            int cont1 = 0;
            List<clsProductos> lHer = lista.FindAll(item => item.GetType() == typeof(clsVarios));
            lHer.OrderBy(clsVarios => clsVarios.Stock);

            if (lHer.Count != 0)
            {
                cont1 = lHer.First().Stock;
                lbPinturas.Text = "Herramienta de Max Stock: " + cont1.ToString();
            }
            else
            {
                lbPinturas.Text = "No hay herramientas en stock";
            }
        }
        public void StockMin1(List<clsProductos> lista)
        {
            int cont1 = 0;
            List<clsProductos> lPin = lista.FindAll(item => item.GetType() == typeof(clsPinturas));
            lPin.OrderBy(clsPinturas => clsPinturas.Stock);
            

            if (lPin.Count != 0)
            {
                cont1 = lPin.Last().Stock;
                lbPinturas.Text = "Pintura de Min Stock: " + cont1.ToString();
            }
            else
            {
                lbPinturas.Text = "No hay pinturas en stock";
            }
        }
        public void StockMin2(List<clsProductos> lista)
        {
            int cont1 = 0;
            List<clsProductos> lHer = lista.FindAll(item => item.GetType() == typeof(clsVarios));
            lHer.OrderBy(clsVarios => clsVarios.Stock);
            
            if (lHer.Count != 0)
            {
                cont1 = lHer.Last().Stock;
                lbPinturas.Text = "Herramienta de Min Stock: " + cont1.ToString();
            }
            else
            {
                lbPinturas.Text = "No hay herramientas en stock";
            }
        }

        public void ManejadorEvent(object sender, DelValidacionArgs e)
        {
            throw new Exception(message: e.Mensaje);
        }
        #endregion

        public GenerarCompra()
        {
            InitializeComponent();

            ListClientes = new List<clsCliente>();
            ListEmpleados = new List<clsEmpleado>();
            ListEmpleados.Add(new clsEmpleado("juan", "Rodriguez", 18498822, 1143245474, new DateTime(1967, 5, 10)));
            ListEmpleados.Add(new clsEmpleado("jhonny", "Romero", 17342233, 1187345676, new DateTime(1979, 3, 18)));
            ListEmpleados.Add(new clsEmpleado("joana", "Roca", 19544573, 1112343276, new DateTime(1965, 4, 13)));
            ListEmpleados.Add(new clsEmpleado("julian", "Reyes", 12345678, 1198876789, new DateTime(1963, 5, 19)));

            oPintura = new clsPinturas();
            oHerramienta = new clsVarios();
            CarritoCompra = new clsCarritoCompra();

            cargarCampos();
            cargarComboEmpleados();
            rbDgridPinturas.Checked = true;
        }


        public static List<clsCliente> ListClientes;
        public List<clsEmpleado> ListEmpleados;

        clsVarios oHerramienta;
        clsPinturas oPintura;
        clsCarritoCompra CarritoCompra;

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            IngresarCliente formu = new IngresarCliente();
            formu.ShowDialog();
            cargarCampos();
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbDgridPinturas.Checked == true)
                {
                    oPintura = (clsPinturas)dgridProductos.CurrentRow.DataBoundItem;
                    oPintura.Stock -= Convert.ToInt32(numupCantidad.Value);
                    oPintura.EventValidacion += ManejadorEvent; 
                    oPintura.ValidarProducto();

                    clsPinturas oPin = (clsPinturas)oPintura.Clone();
                    oPin.Stock = Convert.ToInt32(numupCantidad.Value);

                    CarritoCompra.listaProductos.Add(oPin);

                    cargarCampos();

            }
                else if (rbDgridHerramientas.Checked == true)
                {
                    oHerramienta = (clsVarios)dgridProductos.CurrentRow.DataBoundItem;
                    oHerramienta.Stock -= Convert.ToInt32(numupCantidad.Value);
                    oHerramienta.EventValidacion += ManejadorEvent;
                    oHerramienta.ValidarProducto();

                    clsVarios oHer = (clsVarios)oHerramienta.Clone();
                    oHer.Stock = Convert.ToInt32(numupCantidad.Value);

                    CarritoCompra.listaProductos.Add(oHer);

                    cargarCampos();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminarCarrito_Click(object sender, EventArgs e)
        {
            //var DatosGrid = dgridCarrito.CurrentRow.DataBoundItem;
            try
            {
                clsProductos oProd = (clsProductos)dgridCarrito.CurrentRow.DataBoundItem;
                //clsProductos oProd = (clsProductos)DatosGrid;

                foreach (clsProductos item in CarritoCompra.listaProductos)
                {
                    if (item.Codigo == oProd.Codigo)
                    {
                        CarritoCompra.listaProductos.Remove(item);

                        if (item is clsPinturas)
                        {
                            foreach (clsPinturas pin in Listado_de_Stock.listPinturas)
                            {
                                if (pin.Codigo == oProd.Codigo)
                                {
                                    pin.Stock += oProd.Stock;
                                }
                            }
                        }
                        else
                        {
                            foreach (clsVarios her in Listado_de_Stock.listHerramientas)
                            {
                                if (her.Codigo == oProd.Codigo)
                                {
                                    her.Stock += oProd.Stock;
                                }
                            }
                        }
                    }
                }

                cargarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            var datosGrid = dgridUsuarios.CurrentRow.DataBoundItem;
            try
            {
                //clsCliente oClient = (clsCliente)dgridUsuarios.CurrentRow.DataBoundItem;

                clsCliente oClient = (clsCliente)datosGrid;
                CarritoCompra.CalcularTotalCompra();
                oClient.carritoCompra = CarritoCompra;
                oClient.AsignarBonificacion();
                CarritoCompra = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cargarCampos();
            }
            
        }

        #region(btns Ver max & min stock)
        private void button3_Click(object sender, EventArgs e)
        {
            oPintura.actualStock = StockMax1;
            oHerramienta.actualStock = StockMax2;
        }

        private void btnMinStock_Click(object sender, EventArgs e)
        {
            oPintura.actualStock = StockMin1;
            oHerramienta.actualStock = StockMin2;
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            oPintura.actualStock(Listado_de_Stock.ListProducTotal);
            oHerramienta.actualStock(Listado_de_Stock.ListProducTotal);
        }
        #endregion

        #region(radioButtons y load)
        private void GenerarCompra_Load(object sender, EventArgs e)
        {
            ListEmpleados.Add(new clsEmpleado("juan", "Rodriguez", 18498822, 1143245474, new DateTime(1967, 5, 10)));
            ListEmpleados.Add(new clsEmpleado("jhonny", "Romero", 17342233, 1187345676, new DateTime(1979, 3, 18)));
            ListEmpleados.Add(new clsEmpleado("joana", "Roca", 19544573, 1112343276, new DateTime(1965, 4, 13)));
            ListEmpleados.Add(new clsEmpleado("julian", "Reyes", 12345678, 1198876789, new DateTime(1963, 5, 19)));
            cargarCampos();
        }
        private void rbDgridPinturas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDgridPinturas.Checked == true)
            {
                dgridProductos.DataSource = null;
                dgridProductos.DataSource = Listado_de_Stock.listPinturas;
            }
        }

        private void rbDgridHerramientas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDgridHerramientas.Checked == true)
            {
                dgridProductos.DataSource = null;
                dgridProductos.DataSource = Listado_de_Stock.listHerramientas;
            }
        }

        #endregion

        private void refreshDgrids_Click(object sender, EventArgs e)
        {
            dgridCarrito.DataSource = null;
            dgridCarrito.DataSource = CarritoCompra.listaProductos;

            dgridUsuarios.DataSource = null;
            dgridUsuarios.DataSource = ListClientes;
        }
    }
}
