namespace CLIVET
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.btnRepProveedores = new System.Windows.Forms.Button();
            this.btnRepClientes = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCli = new System.Windows.Forms.ComboBox();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.btn_Cliente_rep = new System.Windows.Forms.Button();
            this.btn_Prov_rep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRepProveedores
            // 
            this.btnRepProveedores.Location = new System.Drawing.Point(99, 73);
            this.btnRepProveedores.Name = "btnRepProveedores";
            this.btnRepProveedores.Size = new System.Drawing.Size(185, 44);
            this.btnRepProveedores.TabIndex = 0;
            this.btnRepProveedores.Text = "Reporte de Proveedores";
            this.btnRepProveedores.UseVisualStyleBackColor = true;
            this.btnRepProveedores.Click += new System.EventHandler(this.btnRepProveedores_Click);
            // 
            // btnRepClientes
            // 
            this.btnRepClientes.Location = new System.Drawing.Point(99, 132);
            this.btnRepClientes.Name = "btnRepClientes";
            this.btnRepClientes.Size = new System.Drawing.Size(185, 44);
            this.btnRepClientes.TabIndex = 1;
            this.btnRepClientes.Text = "Reporte de Clientes";
            this.btnRepClientes.UseVisualStyleBackColor = true;
            this.btnRepClientes.Click += new System.EventHandler(this.btnRepClientes_Click);
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(138, 279);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(99, 29);
            this.btninicio.TabIndex = 77;
            this.btninicio.Text = "Regresar a Inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(27, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Cliente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Proveedor :";
            // 
            // cmbCli
            // 
            this.cmbCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCli.FormattingEnabled = true;
            this.cmbCli.Location = new System.Drawing.Point(87, 217);
            this.cmbCli.Name = "cmbCli";
            this.cmbCli.Size = new System.Drawing.Size(121, 21);
            this.cmbCli.TabIndex = 81;
            // 
            // cmbProv
            // 
            this.cmbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Location = new System.Drawing.Point(87, 191);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(121, 21);
            this.cmbProv.TabIndex = 80;
            // 
            // btn_Cliente_rep
            // 
            this.btn_Cliente_rep.Location = new System.Drawing.Point(214, 217);
            this.btn_Cliente_rep.Name = "btn_Cliente_rep";
            this.btn_Cliente_rep.Size = new System.Drawing.Size(160, 23);
            this.btn_Cliente_rep.TabIndex = 79;
            this.btn_Cliente_rep.Text = "Generar Reporte de Ventas";
            this.btn_Cliente_rep.UseVisualStyleBackColor = true;
            this.btn_Cliente_rep.Click += new System.EventHandler(this.btn_Cliente_rep_Click);
            // 
            // btn_Prov_rep
            // 
            this.btn_Prov_rep.Location = new System.Drawing.Point(214, 191);
            this.btn_Prov_rep.Name = "btn_Prov_rep";
            this.btn_Prov_rep.Size = new System.Drawing.Size(160, 23);
            this.btn_Prov_rep.TabIndex = 78;
            this.btn_Prov_rep.Text = "Generar Reporte de compras";
            this.btn_Prov_rep.UseVisualStyleBackColor = true;
            this.btn_Prov_rep.Click += new System.EventHandler(this.btn_Prov_rep_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCli);
            this.Controls.Add(this.cmbProv);
            this.Controls.Add(this.btn_Cliente_rep);
            this.Controls.Add(this.btn_Prov_rep);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnRepClientes);
            this.Controls.Add(this.btnRepProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRepProveedores;
        private System.Windows.Forms.Button btnRepClientes;
        internal System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCli;
        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.Button btn_Cliente_rep;
        private System.Windows.Forms.Button btn_Prov_rep;
    }
}