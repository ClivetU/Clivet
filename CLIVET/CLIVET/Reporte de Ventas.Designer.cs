namespace CLIVET
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btninicio = new System.Windows.Forms.Button();
            this.combofiltro = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnbusqueda = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbusuario = new System.Windows.Forms.Label();
            this.lbsucursal = new System.Windows.Forms.Label();
            this.btnCapCompras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(644, 418);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(75, 36);
            this.btninicio.TabIndex = 16;
            this.btninicio.Text = "Regresar a Inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // combofiltro
            // 
            this.combofiltro.FormattingEnabled = true;
            this.combofiltro.Location = new System.Drawing.Point(354, 168);
            this.combofiltro.Name = "combofiltro";
            this.combofiltro.Size = new System.Drawing.Size(165, 21);
            this.combofiltro.TabIndex = 12;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(298, 171);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Filtrar por:";
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(48, 211);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(622, 191);
            this.DataGridView1.TabIndex = 10;
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.Location = new System.Drawing.Point(537, 168);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(84, 25);
            this.btnbusqueda.TabIndex = 14;
            this.btnbusqueda.Text = "Busqueda";
            this.btnbusqueda.UseVisualStyleBackColor = true;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(145, 169);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(147, 20);
            this.txtbusqueda.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(-149, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Buscar:";
            // 
            // btncerrar
            // 
            this.btncerrar.Enabled = false;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(688, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(26, 17);
            this.btncerrar.TabIndex = 18;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Visible = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Enabled = false;
            this.btnminimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimizar.Location = new System.Drawing.Point(640, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(30, 17);
            this.btnminimizar.TabIndex = 19;
            this.btnminimizar.Text = "_";
            this.btnminimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnminimizar.UseVisualStyleBackColor = true;
            this.btnminimizar.Visible = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(81, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Busqueda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(258, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Reporte de Ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Usuario:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sucursal:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.BackColor = System.Drawing.Color.Transparent;
            this.lbusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbusuario.Location = new System.Drawing.Point(69, 418);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(27, 13);
            this.lbusuario.TabIndex = 20;
            this.lbusuario.Text = "xxxx";
            this.lbusuario.Click += new System.EventHandler(this.lbusuario_Click);
            // 
            // lbsucursal
            // 
            this.lbsucursal.AutoSize = true;
            this.lbsucursal.BackColor = System.Drawing.Color.Transparent;
            this.lbsucursal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbsucursal.Location = new System.Drawing.Point(69, 441);
            this.lbsucursal.Name = "lbsucursal";
            this.lbsucursal.Size = new System.Drawing.Size(27, 13);
            this.lbsucursal.TabIndex = 21;
            this.lbsucursal.Text = "yyyy";
            this.lbsucursal.Click += new System.EventHandler(this.lbsucursal_Click);
            // 
            // btnCapCompras
            // 
            this.btnCapCompras.Location = new System.Drawing.Point(563, 418);
            this.btnCapCompras.Name = "btnCapCompras";
            this.btnCapCompras.Size = new System.Drawing.Size(75, 36);
            this.btnCapCompras.TabIndex = 15;
            this.btnCapCompras.Text = "Reporte de Compras";
            this.btnCapCompras.UseVisualStyleBackColor = true;
            this.btnCapCompras.Click += new System.EventHandler(this.btnCapCompras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 469);
            this.Controls.Add(this.btnCapCompras);
            this.Controls.Add(this.lbsucursal);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnminimizar);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.combofiltro);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnbusqueda);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report de Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btninicio;
        internal System.Windows.Forms.ComboBox combofiltro;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button btnbusqueda;
        internal System.Windows.Forms.TextBox txtbusqueda;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btncerrar;
        internal System.Windows.Forms.Button btnminimizar;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lbusuario;
        internal System.Windows.Forms.Label lbsucursal;
        internal System.Windows.Forms.Button btnCapCompras;
    }
}

