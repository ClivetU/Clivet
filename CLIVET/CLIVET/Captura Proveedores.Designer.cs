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
            this.lbusuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btninicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProv3 = new System.Windows.Forms.Button();
            this.btnProv2 = new System.Windows.Forms.Button();
            this.btnProv1 = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbsimbolo = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbcantidad = new System.Windows.Forms.Label();
            this.btnCapVentas = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProd3 = new System.Windows.Forms.Button();
            this.btnProd2 = new System.Windows.Forms.Button();
            this.btnProd1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.cmbMetPago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapCompra)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(125, 118);
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
            this.Label2.Location = new System.Drawing.Point(473, 122);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Producto:";
            // 
            // dgvCapCompra
            // 
            this.dgvCapCompra.AllowUserToAddRows = false;
            this.dgvCapCompra.AllowUserToDeleteRows = false;
            this.dgvCapCompra.AllowUserToOrderColumns = true;
            this.dgvCapCompra.AllowUserToResizeColumns = false;
            this.dgvCapCompra.AllowUserToResizeRows = false;
            this.dgvCapCompra.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgvCapCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCapCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCapCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapCompra.Location = new System.Drawing.Point(66, 220);
            this.dgvCapCompra.Name = "dgvCapCompra";
            this.dgvCapCompra.RowHeadersVisible = false;
            this.dgvCapCompra.Size = new System.Drawing.Size(708, 135);
            this.dgvCapCompra.TabIndex = 18;
            // 
            // txtproveedor
            // 
            this.txtproveedor.Location = new System.Drawing.Point(197, 115);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(147, 20);
            this.txtproveedor.TabIndex = 17;
            this.txtproveedor.TextChanged += new System.EventHandler(this.txtproveedor_TextChanged);
            // 
            // btncerrar
            // 
            this.btncerrar.Enabled = false;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(803, 3);
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
            this.btnminimizar.Location = new System.Drawing.Point(755, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 17);
            this.btnminimizar.TabIndex = 65;
            this.btnminimizar.Text = "_";
            this.btnminimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnminimizar.UseVisualStyleBackColor = true;
            this.btnminimizar.Visible = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.BackColor = System.Drawing.Color.Transparent;
            this.lbusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbusuario.Location = new System.Drawing.Point(63, 418);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(27, 13);
            this.lbusuario.TabIndex = 34;
            this.lbusuario.Text = "xxxx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Usuario:";
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(740, 406);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(75, 36);
            this.btninicio.TabIndex = 56;
            this.btninicio.Text = "Regresar a Inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProv3);
            this.panel1.Controls.Add(this.btnProv2);
            this.panel1.Controls.Add(this.btnProv1);
            this.panel1.Location = new System.Drawing.Point(197, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 73);
            this.panel1.TabIndex = 37;
            // 
            // btnProv3
            // 
            this.btnProv3.Location = new System.Drawing.Point(0, 47);
            this.btnProv3.Name = "btnProv3";
            this.btnProv3.Size = new System.Drawing.Size(147, 23);
            this.btnProv3.TabIndex = 41;
            this.btnProv3.Text = "button3";
            this.btnProv3.UseVisualStyleBackColor = true;
            this.btnProv3.Click += new System.EventHandler(this.btnProv3_Click);
            // 
            // btnProv2
            // 
            this.btnProv2.Location = new System.Drawing.Point(0, 24);
            this.btnProv2.Name = "btnProv2";
            this.btnProv2.Size = new System.Drawing.Size(147, 23);
            this.btnProv2.TabIndex = 40;
            this.btnProv2.Text = "button2";
            this.btnProv2.UseVisualStyleBackColor = true;
            this.btnProv2.Click += new System.EventHandler(this.btnProv2_Click);
            // 
            // btnProv1
            // 
            this.btnProv1.Location = new System.Drawing.Point(0, 0);
            this.btnProv1.Name = "btnProv1";
            this.btnProv1.Size = new System.Drawing.Size(147, 23);
            this.btnProv1.TabIndex = 39;
            this.btnProv1.Text = "btnProv1";
            this.btnProv1.UseVisualStyleBackColor = true;
            this.btnProv1.Click += new System.EventHandler(this.btnProv1_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(537, 119);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(147, 20);
            this.txtproducto.TabIndex = 38;
            this.txtproducto.TextChanged += new System.EventHandler(this.txtproducto_TextChanged);
            // 
            // dtpCompra
            // 
            this.dtpCompra.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtpCompra.Enabled = false;
            this.dtpCompra.Location = new System.Drawing.Point(331, 78);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.Size = new System.Drawing.Size(240, 20);
            this.dtpCompra.TabIndex = 37;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(541, 174);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown1.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(473, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Cantidad";
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(197, 361);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 36);
            this.btninsertar.TabIndex = 44;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(537, 361);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 36);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(309, 31);
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
            this.lbsimbolo.Location = new System.Drawing.Point(752, 358);
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
            this.lb.Location = new System.Drawing.Point(715, 358);
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
            this.lbcantidad.Location = new System.Drawing.Point(771, 358);
            this.lbcantidad.Name = "lbcantidad";
            this.lbcantidad.Size = new System.Drawing.Size(31, 13);
            this.lbcantidad.TabIndex = 50;
            this.lbcantidad.Text = "1234";
            // 
            // btnCapVentas
            // 
            this.btnCapVentas.Location = new System.Drawing.Point(659, 406);
            this.btnCapVentas.Name = "btnCapVentas";
            this.btnCapVentas.Size = new System.Drawing.Size(75, 36);
            this.btnCapVentas.TabIndex = 51;
            this.btnCapVentas.Text = "Captura de Ventas";
            this.btnCapVentas.UseVisualStyleBackColor = true;
            this.btnCapVentas.Click += new System.EventHandler(this.btnCapVentas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(115, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Metodo Pago:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnProd3);
            this.panel2.Controls.Add(this.btnProd2);
            this.panel2.Controls.Add(this.btnProd1);
            this.panel2.Location = new System.Drawing.Point(537, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 73);
            this.panel2.TabIndex = 67;
            // 
            // btnProd3
            // 
            this.btnProd3.Location = new System.Drawing.Point(0, 47);
            this.btnProd3.Name = "btnProd3";
            this.btnProd3.Size = new System.Drawing.Size(147, 23);
            this.btnProd3.TabIndex = 41;
            this.btnProd3.Text = "button4";
            this.btnProd3.UseVisualStyleBackColor = true;
            this.btnProd3.Click += new System.EventHandler(this.btnProd3_Click);
            // 
            // btnProd2
            // 
            this.btnProd2.Location = new System.Drawing.Point(0, 24);
            this.btnProd2.Name = "btnProd2";
            this.btnProd2.Size = new System.Drawing.Size(147, 23);
            this.btnProd2.TabIndex = 40;
            this.btnProd2.Text = "button5";
            this.btnProd2.UseVisualStyleBackColor = true;
            this.btnProd2.Click += new System.EventHandler(this.btnProd2_Click);
            // 
            // btnProd1
            // 
            this.btnProd1.Location = new System.Drawing.Point(0, 0);
            this.btnProd1.Name = "btnProd1";
            this.btnProd1.Size = new System.Drawing.Size(147, 23);
            this.btnProd1.TabIndex = 39;
            this.btnProd1.Text = "button6";
            this.btnProd1.UseVisualStyleBackColor = true;
            this.btnProd1.Click += new System.EventHandler(this.btnProd1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(288, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Fecha";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(364, 403);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 36);
            this.btnmodificar.TabIndex = 46;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // cmbMetPago
            // 
            this.cmbMetPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetPago.FormattingEnabled = true;
            this.cmbMetPago.Location = new System.Drawing.Point(195, 160);
            this.cmbMetPago.Name = "cmbMetPago";
            this.cmbMetPago.Size = new System.Drawing.Size(147, 21);
            this.cmbMetPago.TabIndex = 95;
            // 
            // Captura_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 452);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCapVentas);
            this.Controls.Add(this.lbcantidad);
            this.Controls.Add(this.lbsimbolo);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpCompra);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dgvCapCompra);
            this.Controls.Add(this.txtproveedor);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.cmbMetPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Captura_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura_Proveedores";
            this.Load += new System.EventHandler(this.Captura_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapCompra)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        internal System.Windows.Forms.Label lbusuario;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.DateTimePicker dtpCompra;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btninsertar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lbsimbolo;
        internal System.Windows.Forms.Label lb;
        internal System.Windows.Forms.Label lbcantidad;
        internal System.Windows.Forms.Button btnCapVentas;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnProv3;
        private System.Windows.Forms.Button btnProv2;
        private System.Windows.Forms.Button btnProv1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProd3;
        private System.Windows.Forms.Button btnProd2;
        private System.Windows.Forms.Button btnProd1;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.ComboBox cmbMetPago;
    }
}