﻿namespace CLIVET
{
    partial class RegistroClientesYProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroClientesYProveedores));
            this.tbcCliente = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txtClienteDireccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtClienteRFC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCiudad1 = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.tabProveedor = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProveedorDireccion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProveedorRFC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCiudad2 = new System.Windows.Forms.ComboBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.tabProducto = new System.Windows.Forms.TabPage();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lbusuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.tbcCliente.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabProveedor.SuspendLayout();
            this.tabProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCliente
            // 
            this.tbcCliente.Controls.Add(this.tabCliente);
            this.tbcCliente.Controls.Add(this.tabProveedor);
            this.tbcCliente.Controls.Add(this.tabProducto);
            this.tbcCliente.Location = new System.Drawing.Point(51, 125);
            this.tbcCliente.Name = "tbcCliente";
            this.tbcCliente.SelectedIndex = 0;
            this.tbcCliente.Size = new System.Drawing.Size(720, 112);
            this.tbcCliente.TabIndex = 1;
            this.tbcCliente.Click += new System.EventHandler(this.tbcCliente_Click);
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.label13);
            this.tabCliente.Controls.Add(this.txtClienteDireccion);
            this.tabCliente.Controls.Add(this.label12);
            this.tabCliente.Controls.Add(this.txtClienteRFC);
            this.tabCliente.Controls.Add(this.label4);
            this.tabCliente.Controls.Add(this.label1);
            this.tabCliente.Controls.Add(this.cmbCiudad1);
            this.tabCliente.Controls.Add(this.txtCliente);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(712, 86);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Cliente";
            this.tabCliente.UseVisualStyleBackColor = true;
            this.tabCliente.Click += new System.EventHandler(this.tabCliente_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(373, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Direccion:";
            // 
            // txtClienteDireccion
            // 
            this.txtClienteDireccion.Location = new System.Drawing.Point(434, 38);
            this.txtClienteDireccion.Name = "txtClienteDireccion";
            this.txtClienteDireccion.Size = new System.Drawing.Size(254, 20);
            this.txtClienteDireccion.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "RFC:";
            // 
            // txtClienteRFC
            // 
            this.txtClienteRFC.Location = new System.Drawing.Point(434, 12);
            this.txtClienteRFC.MaxLength = 13;
            this.txtClienteRFC.Name = "txtClienteRFC";
            this.txtClienteRFC.Size = new System.Drawing.Size(254, 20);
            this.txtClienteRFC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // cmbCiudad1
            // 
            this.cmbCiudad1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad1.FormattingEnabled = true;
            this.cmbCiudad1.Location = new System.Drawing.Point(75, 41);
            this.cmbCiudad1.Name = "cmbCiudad1";
            this.cmbCiudad1.Size = new System.Drawing.Size(130, 21);
            this.cmbCiudad1.TabIndex = 1;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(75, 15);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(254, 20);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // tabProveedor
            // 
            this.tabProveedor.Controls.Add(this.label14);
            this.tabProveedor.Controls.Add(this.txtProveedorDireccion);
            this.tabProveedor.Controls.Add(this.label15);
            this.tabProveedor.Controls.Add(this.txtProveedorRFC);
            this.tabProveedor.Controls.Add(this.label5);
            this.tabProveedor.Controls.Add(this.label6);
            this.tabProveedor.Controls.Add(this.cmbCiudad2);
            this.tabProveedor.Controls.Add(this.txtProveedor);
            this.tabProveedor.Location = new System.Drawing.Point(4, 22);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabProveedor.Size = new System.Drawing.Size(712, 86);
            this.tabProveedor.TabIndex = 1;
            this.tabProveedor.Text = "Proveedor";
            this.tabProveedor.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(365, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Direccion:";
            // 
            // txtProveedorDireccion
            // 
            this.txtProveedorDireccion.Location = new System.Drawing.Point(433, 41);
            this.txtProveedorDireccion.Name = "txtProveedorDireccion";
            this.txtProveedorDireccion.Size = new System.Drawing.Size(254, 20);
            this.txtProveedorDireccion.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(381, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "RFC:";
            // 
            // txtProveedorRFC
            // 
            this.txtProveedorRFC.Location = new System.Drawing.Point(433, 15);
            this.txtProveedorRFC.MaxLength = 13;
            this.txtProveedorRFC.Name = "txtProveedorRFC";
            this.txtProveedorRFC.Size = new System.Drawing.Size(254, 20);
            this.txtProveedorRFC.TabIndex = 8;
            this.txtProveedorRFC.TextChanged += new System.EventHandler(this.txtProveedorRFC_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ciudad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre:";
            // 
            // cmbCiudad2
            // 
            this.cmbCiudad2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad2.FormattingEnabled = true;
            this.cmbCiudad2.Location = new System.Drawing.Point(79, 45);
            this.cmbCiudad2.Name = "cmbCiudad2";
            this.cmbCiudad2.Size = new System.Drawing.Size(130, 21);
            this.cmbCiudad2.TabIndex = 5;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(79, 19);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(254, 20);
            this.txtProveedor.TabIndex = 4;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            this.txtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedor_KeyPress);
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.cmbUnidad);
            this.tabProducto.Controls.Add(this.cmbProveedor);
            this.tabProducto.Controls.Add(this.label2);
            this.tabProducto.Controls.Add(this.label16);
            this.tabProducto.Controls.Add(this.txtPrecio);
            this.tabProducto.Controls.Add(this.txtExistencia);
            this.tabProducto.Controls.Add(this.label9);
            this.tabProducto.Controls.Add(this.label7);
            this.tabProducto.Controls.Add(this.label8);
            this.tabProducto.Controls.Add(this.txtProducto);
            this.tabProducto.Location = new System.Drawing.Point(4, 22);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducto.Size = new System.Drawing.Size(712, 86);
            this.tabProducto.TabIndex = 2;
            this.tabProducto.Text = "Producto";
            this.tabProducto.UseVisualStyleBackColor = true;
            this.tabProducto.Click += new System.EventHandler(this.tabProducto_Click);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(522, 10);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(184, 21);
            this.cmbProveedor.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Proveedor:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(283, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Unidad:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(67, 39);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(44, 20);
            this.txtPrecio.TabIndex = 14;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(343, 13);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(44, 20);
            this.txtExistencia.TabIndex = 13;
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencia_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Existencia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nombre:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(67, 12);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(196, 20);
            this.txtProducto.TabIndex = 8;
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.BackColor = System.Drawing.Color.Transparent;
            this.lbusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbusuario.Location = new System.Drawing.Point(69, 398);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(27, 13);
            this.lbusuario.TabIndex = 63;
            this.lbusuario.Text = "xxxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Usuario:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(327, 243);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 74;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(408, 243);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 75;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(243, 243);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 72;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(696, 386);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(75, 36);
            this.btninicio.TabIndex = 76;
            this.btninicio.Text = "Regresar a Inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(325, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 76;
            this.label10.Text = "Registro ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(220, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(344, 25);
            this.label11.TabIndex = 77;
            this.label11.Text = "Clientes, Productos y Proveedores";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btncerrar
            // 
            this.btncerrar.Enabled = false;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(763, 11);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(26, 17);
            this.btncerrar.TabIndex = 79;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Visible = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Enabled = false;
            this.btnminimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimizar.Location = new System.Drawing.Point(713, 11);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 17);
            this.btnminimizar.TabIndex = 80;
            this.btnminimizar.Text = "_";
            this.btnminimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnminimizar.UseVisualStyleBackColor = true;
            this.btnminimizar.Visible = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(420, 110);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(489, 243);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 82;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Items.AddRange(new object[] {
            "pza.",
            "bolsa.",
            "galon."});
            this.cmbUnidad.Location = new System.Drawing.Point(333, 43);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(115, 21);
            this.cmbUnidad.TabIndex = 19;
            // 
            // RegistroClientesYProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 434);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbcCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroClientesYProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroClientesYProveedores";
            this.Load += new System.EventHandler(this.RegistroClientesYProveedores_Load);
            this.tbcCliente.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.tabProveedor.ResumeLayout(false);
            this.tabProveedor.PerformLayout();
            this.tabProducto.ResumeLayout(false);
            this.tabProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCliente;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCiudad1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TabPage tabProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCiudad2;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TabPage tabProducto;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProducto;
        internal System.Windows.Forms.Label lbusuario;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnmodificar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btninsertar;
        internal System.Windows.Forms.Button btninicio;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Button btncerrar;
        internal System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtClienteDireccion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtClienteRFC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProveedorDireccion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtProveedorRFC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUnidad;
    }
}