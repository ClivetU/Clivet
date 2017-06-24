namespace CLIVET
{
    partial class Captura_Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Captura_Proveedores));
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvCapCompra = new System.Windows.Forms.DataGridView();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.lbsucursal = new System.Windows.Forms.Label();
            this.lbusuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btninicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbsimbolo = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbcantidad = new System.Windows.Forms.Label();
            this.btnCapVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Proveedor";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(48, 237);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Producto:";
            // 
            // dgvCapCompra
            // 
            this.dgvCapCompra.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCapCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCapCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCapCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapCompra.Location = new System.Drawing.Point(280, 171);
            this.dgvCapCompra.Name = "dgvCapCompra";
            this.dgvCapCompra.Size = new System.Drawing.Size(372, 191);
            this.dgvCapCompra.TabIndex = 18;
            // 
            // txtproveedor
            // 
            this.txtproveedor.Location = new System.Drawing.Point(112, 144);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(147, 20);
            this.txtproveedor.TabIndex = 17;
            // 
            // btncerrar
            // 
            this.btncerrar.Enabled = false;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(682, 1);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(26, 17);
            this.btncerrar.TabIndex = 60;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Visible = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Enabled = false;
            this.btnminimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimizar.Location = new System.Drawing.Point(634, 1);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 17);
            this.btnminimizar.TabIndex = 65;
            this.btnminimizar.Text = "_";
            this.btnminimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnminimizar.UseVisualStyleBackColor = true;
            this.btnminimizar.Visible = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // lbsucursal
            // 
            this.lbsucursal.AutoSize = true;
            this.lbsucursal.BackColor = System.Drawing.Color.Transparent;
            this.lbsucursal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbsucursal.Location = new System.Drawing.Point(69, 440);
            this.lbsucursal.Name = "lbsucursal";
            this.lbsucursal.Size = new System.Drawing.Size(27, 13);
            this.lbsucursal.TabIndex = 35;
            this.lbsucursal.Text = "yyyy";
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.BackColor = System.Drawing.Color.Transparent;
            this.lbusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbusuario.Location = new System.Drawing.Point(69, 417);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(27, 13);
            this.lbusuario.TabIndex = 34;
            this.lbusuario.Text = "xxxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Sucursal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Usuario:";
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(621, 417);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(75, 36);
            this.btninicio.TabIndex = 56;
            this.btninicio.Text = "Regresar a Inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(112, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 57);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(112, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 57);
            this.panel2.TabIndex = 39;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(112, 237);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(147, 20);
            this.txtproducto.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(275, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Fecha";
            // 
            // dtpCompra
            // 
            this.dtpCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCompra.Location = new System.Drawing.Point(353, 139);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.Size = new System.Drawing.Size(106, 20);
            this.dtpCompra.TabIndex = 37;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(112, 340);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(52, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Unidades";
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(112, 366);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 36);
            this.btninsertar.TabIndex = 44;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(374, 370);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 36);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(280, 370);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 36);
            this.btnmodificar.TabIndex = 46;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(219, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 25);
            this.label7.TabIndex = 47;
            this.label7.Text = "Captura de Compras";
            // 
            // lbsimbolo
            // 
            this.lbsimbolo.AutoSize = true;
            this.lbsimbolo.BackColor = System.Drawing.Color.Transparent;
            this.lbsimbolo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbsimbolo.Location = new System.Drawing.Point(602, 365);
            this.lbsimbolo.Name = "lbsimbolo";
            this.lbsimbolo.Size = new System.Drawing.Size(13, 13);
            this.lbsimbolo.TabIndex = 49;
            this.lbsimbolo.Text = "$";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb.Location = new System.Drawing.Point(565, 365);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(31, 13);
            this.lb.TabIndex = 48;
            this.lb.Text = "Total";
            // 
            // lbcantidad
            // 
            this.lbcantidad.AutoSize = true;
            this.lbcantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbcantidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbcantidad.Location = new System.Drawing.Point(621, 365);
            this.lbcantidad.Name = "lbcantidad";
            this.lbcantidad.Size = new System.Drawing.Size(31, 13);
            this.lbcantidad.TabIndex = 50;
            this.lbcantidad.Text = "1234";
            // 
            // btnCapVentas
            // 
            this.btnCapVentas.Location = new System.Drawing.Point(540, 417);
            this.btnCapVentas.Name = "btnCapVentas";
            this.btnCapVentas.Size = new System.Drawing.Size(75, 36);
            this.btnCapVentas.TabIndex = 51;
            this.btnCapVentas.Text = "Captura de Ventas";
            this.btnCapVentas.UseVisualStyleBackColor = true;
            this.btnCapVentas.Click += new System.EventHandler(this.btnCapVentas_Click);
            // 
            // Captura_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 464);
            this.Controls.Add(this.btnCapVentas);
            this.Controls.Add(this.lbcantidad);
            this.Controls.Add(this.lbsimbolo);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dtpCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.lbsucursal);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dgvCapCompra);
            this.Controls.Add(this.txtproveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Captura_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura_Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView dgvCapCompra;
        internal System.Windows.Forms.TextBox txtproveedor;
        internal System.Windows.Forms.Button btncerrar;
        internal System.Windows.Forms.Button btnminimizar;
        internal System.Windows.Forms.Label lbsucursal;
        internal System.Windows.Forms.Label lbusuario;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.TextBox txtproducto;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCompra;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btninsertar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnmodificar;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lbsimbolo;
        internal System.Windows.Forms.Label lb;
        internal System.Windows.Forms.Label lbcantidad;
        internal System.Windows.Forms.Button btnCapVentas;
    }
}