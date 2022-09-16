
namespace Villanovich_Santiago_TP2_POO
{
    partial class Listado_de_Stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgridProductos = new System.Windows.Forms.DataGridView();
            this.gboxProduct = new System.Windows.Forms.GroupBox();
            this.numupPrecioProduct = new System.Windows.Forms.NumericUpDown();
            this.btnIngresarProduct = new System.Windows.Forms.Button();
            this.gboxPintura = new System.Windows.Forms.GroupBox();
            this.cboxTipoProduct = new System.Windows.Forms.ComboBox();
            this.cboxVolumenProduct = new System.Windows.Forms.ComboBox();
            this.txtColorProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbHerramientas = new System.Windows.Forms.RadioButton();
            this.rbPinturas = new System.Windows.Forms.RadioButton();
            this.txtMarcaProduct = new System.Windows.Forms.TextBox();
            this.txtDescripProduct = new System.Windows.Forms.TextBox();
            this.txtCodigoProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numupStockProduct = new System.Windows.Forms.NumericUpDown();
            this.rbDgridHerramientas = new System.Windows.Forms.RadioButton();
            this.rbDgridPinturas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAñadirProduct = new System.Windows.Forms.Button();
            this.btnVerStock = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMinStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridProductos)).BeginInit();
            this.gboxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupPrecioProduct)).BeginInit();
            this.gboxPintura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupStockProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgridProductos
            // 
            this.dgridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridProductos.Location = new System.Drawing.Point(363, 41);
            this.dgridProductos.MultiSelect = false;
            this.dgridProductos.Name = "dgridProductos";
            this.dgridProductos.ReadOnly = true;
            this.dgridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridProductos.Size = new System.Drawing.Size(512, 222);
            this.dgridProductos.TabIndex = 0;
            // 
            // gboxProduct
            // 
            this.gboxProduct.BackColor = System.Drawing.Color.Lavender;
            this.gboxProduct.Controls.Add(this.numupPrecioProduct);
            this.gboxProduct.Controls.Add(this.btnIngresarProduct);
            this.gboxProduct.Controls.Add(this.gboxPintura);
            this.gboxProduct.Controls.Add(this.rbHerramientas);
            this.gboxProduct.Controls.Add(this.rbPinturas);
            this.gboxProduct.Controls.Add(this.txtMarcaProduct);
            this.gboxProduct.Controls.Add(this.txtDescripProduct);
            this.gboxProduct.Controls.Add(this.txtCodigoProduct);
            this.gboxProduct.Controls.Add(this.label5);
            this.gboxProduct.Controls.Add(this.label4);
            this.gboxProduct.Controls.Add(this.label3);
            this.gboxProduct.Controls.Add(this.label2);
            this.gboxProduct.Controls.Add(this.label1);
            this.gboxProduct.Location = new System.Drawing.Point(16, 12);
            this.gboxProduct.Name = "gboxProduct";
            this.gboxProduct.Size = new System.Drawing.Size(327, 462);
            this.gboxProduct.TabIndex = 2;
            this.gboxProduct.TabStop = false;
            // 
            // numupPrecioProduct
            // 
            this.numupPrecioProduct.DecimalPlaces = 2;
            this.numupPrecioProduct.Location = new System.Drawing.Point(110, 173);
            this.numupPrecioProduct.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numupPrecioProduct.Name = "numupPrecioProduct";
            this.numupPrecioProduct.Size = new System.Drawing.Size(145, 20);
            this.numupPrecioProduct.TabIndex = 5;
            this.numupPrecioProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIngresarProduct
            // 
            this.btnIngresarProduct.Location = new System.Drawing.Point(97, 396);
            this.btnIngresarProduct.Name = "btnIngresarProduct";
            this.btnIngresarProduct.Size = new System.Drawing.Size(112, 39);
            this.btnIngresarProduct.TabIndex = 18;
            this.btnIngresarProduct.Text = "Ingresar";
            this.btnIngresarProduct.UseVisualStyleBackColor = true;
            this.btnIngresarProduct.Click += new System.EventHandler(this.btnIngresarProduct_Click);
            // 
            // gboxPintura
            // 
            this.gboxPintura.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gboxPintura.Controls.Add(this.cboxTipoProduct);
            this.gboxPintura.Controls.Add(this.cboxVolumenProduct);
            this.gboxPintura.Controls.Add(this.txtColorProduct);
            this.gboxPintura.Controls.Add(this.label8);
            this.gboxPintura.Controls.Add(this.label7);
            this.gboxPintura.Controls.Add(this.label6);
            this.gboxPintura.Location = new System.Drawing.Point(6, 244);
            this.gboxPintura.Name = "gboxPintura";
            this.gboxPintura.Size = new System.Drawing.Size(310, 135);
            this.gboxPintura.TabIndex = 17;
            this.gboxPintura.TabStop = false;
            // 
            // cboxTipoProduct
            // 
            this.cboxTipoProduct.FormattingEnabled = true;
            this.cboxTipoProduct.Location = new System.Drawing.Point(59, 102);
            this.cboxTipoProduct.Name = "cboxTipoProduct";
            this.cboxTipoProduct.Size = new System.Drawing.Size(190, 21);
            this.cboxTipoProduct.TabIndex = 16;
            // 
            // cboxVolumenProduct
            // 
            this.cboxVolumenProduct.FormattingEnabled = true;
            this.cboxVolumenProduct.Location = new System.Drawing.Point(74, 62);
            this.cboxVolumenProduct.Name = "cboxVolumenProduct";
            this.cboxVolumenProduct.Size = new System.Drawing.Size(175, 21);
            this.cboxVolumenProduct.TabIndex = 15;
            // 
            // txtColorProduct
            // 
            this.txtColorProduct.Location = new System.Drawing.Point(59, 25);
            this.txtColorProduct.Name = "txtColorProduct";
            this.txtColorProduct.Size = new System.Drawing.Size(190, 20);
            this.txtColorProduct.TabIndex = 14;
            this.txtColorProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Volumen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Color";
            // 
            // rbHerramientas
            // 
            this.rbHerramientas.AutoSize = true;
            this.rbHerramientas.Location = new System.Drawing.Point(149, 221);
            this.rbHerramientas.Name = "rbHerramientas";
            this.rbHerramientas.Size = new System.Drawing.Size(87, 17);
            this.rbHerramientas.TabIndex = 10;
            this.rbHerramientas.TabStop = true;
            this.rbHerramientas.Text = "Herramientas";
            this.rbHerramientas.UseVisualStyleBackColor = true;
            // 
            // rbPinturas
            // 
            this.rbPinturas.AutoSize = true;
            this.rbPinturas.Location = new System.Drawing.Point(80, 221);
            this.rbPinturas.Name = "rbPinturas";
            this.rbPinturas.Size = new System.Drawing.Size(63, 17);
            this.rbPinturas.TabIndex = 9;
            this.rbPinturas.TabStop = true;
            this.rbPinturas.Text = "Pinturas";
            this.rbPinturas.UseVisualStyleBackColor = true;
            this.rbPinturas.CheckedChanged += new System.EventHandler(this.rbPinturas_CheckedChanged);
            // 
            // txtMarcaProduct
            // 
            this.txtMarcaProduct.Location = new System.Drawing.Point(71, 138);
            this.txtMarcaProduct.Name = "txtMarcaProduct";
            this.txtMarcaProduct.Size = new System.Drawing.Size(184, 20);
            this.txtMarcaProduct.TabIndex = 7;
            this.txtMarcaProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescripProduct
            // 
            this.txtDescripProduct.Location = new System.Drawing.Point(97, 102);
            this.txtDescripProduct.Name = "txtDescripProduct";
            this.txtDescripProduct.Size = new System.Drawing.Size(158, 20);
            this.txtDescripProduct.TabIndex = 6;
            this.txtDescripProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodigoProduct
            // 
            this.txtCodigoProduct.Location = new System.Drawing.Point(77, 65);
            this.txtCodigoProduct.Name = "txtCodigoProduct";
            this.txtCodigoProduct.Size = new System.Drawing.Size(178, 20);
            this.txtCodigoProduct.TabIndex = 5;
            this.txtCodigoProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Introduzca el numero de unidades para añadir al stock de producto";
            // 
            // numupStockProduct
            // 
            this.numupStockProduct.Location = new System.Drawing.Point(335, 15);
            this.numupStockProduct.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numupStockProduct.Name = "numupStockProduct";
            this.numupStockProduct.Size = new System.Drawing.Size(171, 20);
            this.numupStockProduct.TabIndex = 4;
            this.numupStockProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbDgridHerramientas
            // 
            this.rbDgridHerramientas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDgridHerramientas.AutoSize = true;
            this.rbDgridHerramientas.Location = new System.Drawing.Point(424, 12);
            this.rbDgridHerramientas.Name = "rbDgridHerramientas";
            this.rbDgridHerramientas.Size = new System.Drawing.Size(79, 23);
            this.rbDgridHerramientas.TabIndex = 21;
            this.rbDgridHerramientas.TabStop = true;
            this.rbDgridHerramientas.Text = "Herramientas";
            this.rbDgridHerramientas.UseVisualStyleBackColor = true;
            this.rbDgridHerramientas.CheckedChanged += new System.EventHandler(this.rbDgridHerramientas_CheckedChanged);
            // 
            // rbDgridPinturas
            // 
            this.rbDgridPinturas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDgridPinturas.AutoSize = true;
            this.rbDgridPinturas.Location = new System.Drawing.Point(363, 12);
            this.rbDgridPinturas.Name = "rbDgridPinturas";
            this.rbDgridPinturas.Size = new System.Drawing.Size(55, 23);
            this.rbDgridPinturas.TabIndex = 20;
            this.rbDgridPinturas.TabStop = true;
            this.rbDgridPinturas.Text = "Pinturas";
            this.rbDgridPinturas.UseVisualStyleBackColor = true;
            this.rbDgridPinturas.CheckedChanged += new System.EventHandler(this.rbDgridPinturas_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btnAñadirProduct);
            this.groupBox1.Controls.Add(this.numupStockProduct);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(363, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 85);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // btnAñadirProduct
            // 
            this.btnAñadirProduct.Location = new System.Drawing.Point(193, 46);
            this.btnAñadirProduct.Name = "btnAñadirProduct";
            this.btnAñadirProduct.Size = new System.Drawing.Size(136, 21);
            this.btnAñadirProduct.TabIndex = 5;
            this.btnAñadirProduct.Text = "Añadir";
            this.btnAñadirProduct.UseVisualStyleBackColor = true;
            this.btnAñadirProduct.Click += new System.EventHandler(this.btnAñadirProduct_Click);
            // 
            // btnVerStock
            // 
            this.btnVerStock.Location = new System.Drawing.Point(0, 0);
            this.btnVerStock.Name = "btnVerStock";
            this.btnVerStock.Size = new System.Drawing.Size(75, 23);
            this.btnVerStock.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // btnMinStock
            // 
            this.btnMinStock.Location = new System.Drawing.Point(0, 0);
            this.btnMinStock.Name = "btnMinStock";
            this.btnMinStock.Size = new System.Drawing.Size(75, 23);
            this.btnMinStock.TabIndex = 0;
            // 
            // Listado_de_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(887, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbDgridHerramientas);
            this.Controls.Add(this.rbDgridPinturas);
            this.Controls.Add(this.gboxProduct);
            this.Controls.Add(this.dgridProductos);
            this.Name = "Listado_de_Stock";
            this.Text = "Listado_de_Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgridProductos)).EndInit();
            this.gboxProduct.ResumeLayout(false);
            this.gboxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupPrecioProduct)).EndInit();
            this.gboxPintura.ResumeLayout(false);
            this.gboxPintura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupStockProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridProductos;
        private System.Windows.Forms.GroupBox gboxProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxTipoProduct;
        private System.Windows.Forms.ComboBox cboxVolumenProduct;
        private System.Windows.Forms.TextBox txtColorProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbHerramientas;
        private System.Windows.Forms.RadioButton rbPinturas;
        private System.Windows.Forms.TextBox txtMarcaProduct;
        private System.Windows.Forms.TextBox txtDescripProduct;
        private System.Windows.Forms.TextBox txtCodigoProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboxPintura;
        private System.Windows.Forms.Button btnIngresarProduct;
        private System.Windows.Forms.NumericUpDown numupPrecioProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numupStockProduct;
        private System.Windows.Forms.RadioButton rbDgridHerramientas;
        private System.Windows.Forms.RadioButton rbDgridPinturas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAñadirProduct;
        private System.Windows.Forms.Button btnVerStock;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMinStock;
    }
}