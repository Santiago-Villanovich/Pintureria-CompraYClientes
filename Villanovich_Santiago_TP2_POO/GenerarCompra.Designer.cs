
namespace Villanovich_Santiago_TP2_POO
{
    partial class GenerarCompra
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
            this.dgridUsuarios = new System.Windows.Forms.DataGridView();
            this.btnClienteNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgridProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.btnEliminarCarrito = new System.Windows.Forms.Button();
            this.rbDgridHerramientas = new System.Windows.Forms.RadioButton();
            this.rbDgridPinturas = new System.Windows.Forms.RadioButton();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.btnMinStock = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVerStock = new System.Windows.Forms.Button();
            this.lbPinturas = new System.Windows.Forms.Label();
            this.lbHerramientas = new System.Windows.Forms.Label();
            this.numupCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgridCarrito = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxEmpleados = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refreshDgrids = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCarrito)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgridUsuarios
            // 
            this.dgridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridUsuarios.Location = new System.Drawing.Point(24, 21);
            this.dgridUsuarios.Name = "dgridUsuarios";
            this.dgridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridUsuarios.Size = new System.Drawing.Size(220, 192);
            this.dgridUsuarios.TabIndex = 0;
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.Location = new System.Drawing.Point(50, 236);
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Size = new System.Drawing.Size(163, 25);
            this.btnClienteNuevo.TabIndex = 1;
            this.btnClienteNuevo.Text = "Registrar nuevo Cliente";
            this.btnClienteNuevo.UseVisualStyleBackColor = true;
            this.btnClienteNuevo.Click += new System.EventHandler(this.btnClienteNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente no registrado?";
            // 
            // dgridProductos
            // 
            this.dgridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridProductos.Location = new System.Drawing.Point(415, 51);
            this.dgridProductos.Name = "dgridProductos";
            this.dgridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridProductos.Size = new System.Drawing.Size(538, 156);
            this.dgridProductos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccionar producto";
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Location = new System.Drawing.Point(288, 38);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(82, 34);
            this.btnAgregarCarrito.TabIndex = 5;
            this.btnAgregarCarrito.Text = "Agregar al carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // btnEliminarCarrito
            // 
            this.btnEliminarCarrito.Location = new System.Drawing.Point(288, 132);
            this.btnEliminarCarrito.Name = "btnEliminarCarrito";
            this.btnEliminarCarrito.Size = new System.Drawing.Size(82, 35);
            this.btnEliminarCarrito.TabIndex = 6;
            this.btnEliminarCarrito.Text = "Eliminar del carrito";
            this.btnEliminarCarrito.UseVisualStyleBackColor = true;
            this.btnEliminarCarrito.Click += new System.EventHandler(this.btnEliminarCarrito_Click);
            // 
            // rbDgridHerramientas
            // 
            this.rbDgridHerramientas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDgridHerramientas.AutoSize = true;
            this.rbDgridHerramientas.Location = new System.Drawing.Point(476, 22);
            this.rbDgridHerramientas.Name = "rbDgridHerramientas";
            this.rbDgridHerramientas.Size = new System.Drawing.Size(79, 23);
            this.rbDgridHerramientas.TabIndex = 23;
            this.rbDgridHerramientas.TabStop = true;
            this.rbDgridHerramientas.Text = "Herramientas";
            this.rbDgridHerramientas.UseVisualStyleBackColor = true;
            this.rbDgridHerramientas.CheckedChanged += new System.EventHandler(this.rbDgridHerramientas_CheckedChanged);
            // 
            // rbDgridPinturas
            // 
            this.rbDgridPinturas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbDgridPinturas.AutoSize = true;
            this.rbDgridPinturas.Location = new System.Drawing.Point(415, 22);
            this.rbDgridPinturas.Name = "rbDgridPinturas";
            this.rbDgridPinturas.Size = new System.Drawing.Size(55, 23);
            this.rbDgridPinturas.TabIndex = 22;
            this.rbDgridPinturas.TabStop = true;
            this.rbDgridPinturas.Text = "Pinturas";
            this.rbDgridPinturas.UseVisualStyleBackColor = true;
            this.rbDgridPinturas.CheckedChanged += new System.EventHandler(this.rbDgridPinturas_CheckedChanged);
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(288, 173);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(82, 34);
            this.btnConfirmarCompra.TabIndex = 26;
            this.btnConfirmarCompra.Text = "Confirmar";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // btnMinStock
            // 
            this.btnMinStock.Location = new System.Drawing.Point(768, 296);
            this.btnMinStock.Name = "btnMinStock";
            this.btnMinStock.Size = new System.Drawing.Size(75, 23);
            this.btnMinStock.TabIndex = 27;
            this.btnMinStock.Text = "Min Stock";
            this.btnMinStock.UseVisualStyleBackColor = true;
            this.btnMinStock.Click += new System.EventHandler(this.btnMinStock_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(768, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Max Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVerStock
            // 
            this.btnVerStock.Location = new System.Drawing.Point(702, 262);
            this.btnVerStock.Name = "btnVerStock";
            this.btnVerStock.Size = new System.Drawing.Size(60, 57);
            this.btnVerStock.TabIndex = 29;
            this.btnVerStock.Text = "Ver";
            this.btnVerStock.UseVisualStyleBackColor = true;
            this.btnVerStock.Click += new System.EventHandler(this.btnVerStock_Click);
            // 
            // lbPinturas
            // 
            this.lbPinturas.AutoSize = true;
            this.lbPinturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPinturas.Location = new System.Drawing.Point(474, 262);
            this.lbPinturas.Name = "lbPinturas";
            this.lbPinturas.Size = new System.Drawing.Size(2, 15);
            this.lbPinturas.TabIndex = 30;
            // 
            // lbHerramientas
            // 
            this.lbHerramientas.AutoSize = true;
            this.lbHerramientas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHerramientas.Location = new System.Drawing.Point(474, 301);
            this.lbHerramientas.Name = "lbHerramientas";
            this.lbHerramientas.Size = new System.Drawing.Size(2, 15);
            this.lbHerramientas.TabIndex = 31;
            // 
            // numupCantidad
            // 
            this.numupCantidad.Location = new System.Drawing.Point(288, 78);
            this.numupCantidad.Name = "numupCantidad";
            this.numupCantidad.Size = new System.Drawing.Size(82, 20);
            this.numupCantidad.TabIndex = 32;
            this.numupCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgridCarrito
            // 
            this.dgridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridCarrito.Location = new System.Drawing.Point(25, 22);
            this.dgridCarrito.Name = "dgridCarrito";
            this.dgridCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridCarrito.Size = new System.Drawing.Size(220, 185);
            this.dgridCarrito.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.dgridCarrito);
            this.groupBox1.Controls.Add(this.numupCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregarCarrito);
            this.groupBox1.Controls.Add(this.btnEliminarCarrito);
            this.groupBox1.Controls.Add(this.btnConfirmarCompra);
            this.groupBox1.Controls.Add(this.rbDgridHerramientas);
            this.groupBox1.Controls.Add(this.rbDgridPinturas);
            this.groupBox1.Controls.Add(this.dgridProductos);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 221);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion Productos";
            // 
            // cboxEmpleados
            // 
            this.cboxEmpleados.FormattingEnabled = true;
            this.cboxEmpleados.Location = new System.Drawing.Point(250, 21);
            this.cboxEmpleados.Name = "cboxEmpleados";
            this.cboxEmpleados.Size = new System.Drawing.Size(158, 21);
            this.cboxEmpleados.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.refreshDgrids);
            this.groupBox2.Controls.Add(this.cboxEmpleados);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnClienteNuevo);
            this.groupBox2.Controls.Add(this.dgridUsuarios);
            this.groupBox2.Location = new System.Drawing.Point(7, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 283);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion Cliente - Vendedor";
            // 
            // refreshDgrids
            // 
            this.refreshDgrids.Location = new System.Drawing.Point(287, 190);
            this.refreshDgrids.Name = "refreshDgrids";
            this.refreshDgrids.Size = new System.Drawing.Size(82, 23);
            this.refreshDgrids.TabIndex = 37;
            this.refreshDgrids.Text = "Refresh dgrids";
            this.refreshDgrids.UseVisualStyleBackColor = true;
            this.refreshDgrids.Click += new System.EventHandler(this.refreshDgrids_Click);
            // 
            // GenerarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(991, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbHerramientas);
            this.Controls.Add(this.lbPinturas);
            this.Controls.Add(this.btnVerStock);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMinStock);
            this.Name = "GenerarCompra";
            this.Text = "GenerarCompra";
            this.Load += new System.EventHandler(this.GenerarCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCarrito)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridUsuarios;
        private System.Windows.Forms.Button btnClienteNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgridProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Button btnEliminarCarrito;
        private System.Windows.Forms.RadioButton rbDgridHerramientas;
        private System.Windows.Forms.RadioButton rbDgridPinturas;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Button btnMinStock;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnVerStock;
        private System.Windows.Forms.Label lbPinturas;
        private System.Windows.Forms.Label lbHerramientas;
        private System.Windows.Forms.NumericUpDown numupCantidad;
        private System.Windows.Forms.DataGridView dgridCarrito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxEmpleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button refreshDgrids;
    }
}