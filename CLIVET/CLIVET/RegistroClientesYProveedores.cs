using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIVET
{
    public partial class RegistroClientesYProveedores : Form
    {
        public RegistroClientesYProveedores(string User, int lvl)
        {
            InitializeComponent();
            incio = 0;
            user = User;
            lbusuario.Text = user;
            nivel = lvl;
            CiudadesAgregar();
            AgregarProveedor();
            if (nivel != 1)
            {
                tbcCliente.TabPages.Remove(tabProducto);
            }
        }
        private string Estado = "";
        private string user = "";
        private int nivel = 0;
        private int incio = 0;
        private int inciop = 0;
        private string Query = "";

        private void btninicio_Click(object sender, EventArgs e)
        {
            HOME H = new HOME(user, nivel);
            H.Show();
            this.Close();
        }

        private void CiudadesAgregar()
        {
            Query = "select * from CatCiudad;";
            cmbCiudad1.DataSource = Connection.getData(Query);
            cmbCiudad1.DisplayMember = "Ciudad";
            cmbCiudad1.ValueMember = "idCiudad";
            cmbCiudad2.DataSource = Connection.getData(Query);
            cmbCiudad2.DisplayMember = "Ciudad";
            cmbCiudad2.ValueMember = "idCiudad";
        }
        private void AgregarProveedor()
        {
            Query = "select idProveedor,Proveedor from Proveedor where Proveedor != '' and Proveedor != 'NULL' and Proveedor != ' ' and Proveedor is not null;";
            cmbProveedor.DataSource = Connection.getData(Query);
            cmbProveedor.DisplayMember = "Proveedor";
            cmbProveedor.ValueMember = "idProveedor";
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void AgregarCliente(string nombre, string ciudad, string rfc, string direc)
        {
            Query = "exec RegistroCliente '" + nombre + "', '" + ciudad + "','" + rfc + "','" + direc + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }

        private void ModificarCliente(string nombre, string ciudad, string rfc, string direc)
        {
            Query = "exec ModifCliente '" + nombre + "', '" + ciudad + "','" + rfc + "','" + direc + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }

        private void AgregarProveedor(string nombre, string ciudad, string rfc, string direc)
        {
            Query = "exec RegistroProveedor '" + nombre + "', '" + ciudad + "','" + rfc + "','" + direc + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }

        private void ModificarProveedor(string nombre, string ciudad, string rfc, string direc)
        {
            Query = "exec ModifProveedor '" + nombre + "', '" + ciudad + "','" + rfc + "','" + direc + "';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }


        private void AgregarProducto(string nombre, int existencia, int precio, string unidad, string proveedor)
        {
            Query = "exec RegistroProducto '" + nombre + "', '" + existencia + "','" + precio + "','" + unidad + "','"+proveedor+"';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }
        private void ModificarProducto(string nombre, int existencia, int precio, string unidad, string proveedor)
        {
            Query = "exec ModifProducto '" + nombre + "', '" + existencia + "','" + precio + "','" + unidad + "','"+proveedor+"';";
            Estado = Connection.getData(Query).Rows[0]["Estado"].ToString();
            MessageBox.Show(Estado);
        }


        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabCliente"])
            {
                if (txtCliente.Text != "" && cmbCiudad1.Text != "" && txtClienteRFC.Text != "" && txtClienteDireccion.Text != "")
                {
                    AgregarCliente(txtCliente.Text, cmbCiudad1.Text, txtClienteRFC.Text, txtClienteDireccion.Text);
                    this.dataGridView1.DataSource = Connection.getData("Select p.Cliente,p.Direccion,p.RFC,CatCiudad.Ciudad from Cliente as p,CatCiudad where CatCiudad.idCiudad=p.idCiudad and p.Direccion != 'NULL' and p.Cliente != '' and p.RFC != 'NULL'");
                }
                else
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
            }
            else
            {
                if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProveedor"])
                {
                    if (txtProveedor.Text != "" && cmbCiudad2.Text != "" && txtProveedorRFC.Text != "" && txtProveedorDireccion.Text != "")
                    {
                        AgregarProveedor(txtProveedor.Text, cmbCiudad2.Text, txtProveedorRFC.Text, txtProveedorDireccion.Text);
                        this.dataGridView1.DataSource = Connection.getData("Select p.Proveedor,p.Direccion,p.RFC,CatCiudad.Ciudad from Proveedor as p,CatCiudad where CatCiudad.idCiudad=p.idCiudad and p.Direccion != 'NULL' and p.Proveedor != '' and p.RFC != 'NULL'");
                    }
                    else
                    {
                        MessageBox.Show("Faltan campos por llenar");
                    }
                }
                else
                {
                    if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProducto"])
                    {
                        if (txtProducto.Text != "" && txtExistencia.Text != "" && txtPrecio.Text != "" && cmbUnidad.Text != "")
                        {
                            AgregarProducto(txtProducto.Text, Convert.ToInt32(txtExistencia.Text), Convert.ToInt32(txtPrecio.Text), cmbUnidad.Text, cmbProveedor.Text);
                            this.dataGridView1.DataSource = Connection.getData("select Producto,Existencia,Precio,Unidad from Producto where Producto!='' and Unidad!='NULL'");
                        }
                        else
                        {
                            MessageBox.Show("Faltan campos por llenar");
                        }
                    }
                    else
                    {
                        char[] arreglo;
                        arreglo = txtProveedorRFC.Text.ToCharArray();
                        for (int i = 0; i < 12; i++)
                        {
                            char letraACheCar = arreglo[i];
                            if (!(char.IsNumber(letraACheCar)))
                            {
                                MessageBox.Show("El RFC contiene letras y numeros, favor de verificar");

                            }

                            else
                            {
                                AgregarProducto(txtProducto.Text, Convert.ToInt32(txtExistencia.Text), Convert.ToInt32(txtPrecio.Text), cmbUnidad.Text, cmbProveedor.Text);
                            }

                        }


                    }

                }

            }
        }

        private void EliminarValor(string Tabla, string Valor)
        {
            Query = "delete " + Tabla + " where " + Tabla + "='" + Valor + "';";
            Connection.getData(Query);
            if (Tabla == "Producto") 
            {
                Query = "declare @pru varchar(100); select @pru = " + Tabla + " from conexion where " + Tabla + " = " + Valor + "; if @pru is not null (delete from conexion where " + Tabla + " = '" + Valor + "');";
                Connection.getData(Query);
            }
            else
            {
                if(Tabla == "Proveedor")
                {
                    Query = "declare @pru varchar(100); select @pru = " + Tabla + " from conexion where " + Tabla + " = " + Valor + "; if @pru is not null (update conexion set Proveedor = '' where Proveedor = '" + Valor + "');";
                    Connection.getData(Query);
                }
            }
            MessageBox.Show(Valor + " ha sido eliminado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabCliente"])
            {
                if (txtCliente.Text != "")
                {
                    EliminarValor("Cliente", txtCliente.Text);
                    this.dataGridView1.DataSource = Connection.getData("Select p.Cliente,p.Direccion,p.RFC,CatCiudad.Ciudad from Cliente as p,CatCiudad where CatCiudad.idCiudad=p.idCiudad and p.Direccion != 'NULL' and p.Cliente != '' and p.RFC != 'NULL'");
                }
                else
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
            }
            else
            {
                if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProveedor"])
                {
                    if (txtProveedor.Text != "")
                    {
                        EliminarValor("Proveedor", txtProveedor.Text);
                        this.dataGridView1.DataSource = Connection.getData("Select p.Proveedor,p.Direccion,p.RFC,CatCiudad.Ciudad from Proveedor as p,CatCiudad where CatCiudad.idCiudad=p.idCiudad and p.Direccion != 'NULL' and p.Proveedor != '' and p.RFC != 'NULL'");
                    }
                    else
                    {
                        MessageBox.Show("Faltan campos por llenar");
                    }
                }
                else
                {
                    if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProducto"])
                    {
                        if (txtProducto.Text != "")
                        {
                            EliminarValor("Producto", txtProducto.Text);
                            this.dataGridView1.DataSource = Connection.getData("select Producto,Existencia,Precio,Unidad from Producto where Producto!='' and Unidad!='NULL'");
                        }
                        else
                        {
                            MessageBox.Show("Faltan campos por llenar");
                        }
                    }
                    else { MessageBox.Show("No hay Tablas seleccionadas"); }
                }
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabCliente"])
            {
                if (txtCliente.Text != "" && cmbCiudad1.Text != "")
                {
                    ModificarCliente(txtCliente.Text, cmbCiudad1.Text, txtClienteRFC.Text, txtClienteDireccion.Text);
                    this.dataGridView1.DataSource = Connection.getData("Select p.Cliente,p.Direccion,p.RFC,CatCiudad.Ciudad from Cliente as p,CatCiudad where CatCiudad.idCiudad=p.idCiudad and p.Direccion != 'NULL' and p.Cliente != '' and p.RFC != 'NULL'");
                }
                else
                {
                    MessageBox.Show("Faltan campos por llenar");
                }
            }
            else
            {
                if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProveedor"])
                {
                    if (txtProveedor.Text != "" && cmbCiudad2.Text != "")
                    {
                        ModificarProveedor(txtProveedor.Text, cmbCiudad2.Text, txtProveedorRFC.Text, txtProveedorDireccion.Text);
                        this.dataGridView1.DataSource = Connection.getData("Select p.Proveedor,p.Direccion,p.RFC,CatCiudad.Ciudad from Proveedor as p,CatCiudad where CatCiudad.idCiudad=p.idCiudad and p.Direccion != 'NULL' and p.Proveedor != '' and p.RFC != 'NULL'");
                    }
                    else
                    {
                        MessageBox.Show("Faltan campos por llenar");
                    }
                }
                else
                {
                    if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProducto"])
                    {
                        if (txtProducto.Text != "" && txtExistencia.Text != "" && txtPrecio.Text != "")
                        {
                            ModificarProducto(txtProducto.Text, Convert.ToInt32(txtExistencia.Text), Convert.ToInt32(txtPrecio.Text), cmbUnidad.Text, cmbProveedor.Text);
                            this.dataGridView1.DataSource = Connection.getData("select p.Producto,p.Existencia,p.Precio,p.Unidad,c.Proveedor from Producto as p, conexion as c where p.Producto!='' and p.Unidad!='NULL' and c.Producto=p.Producto");
                        }
                        else
                        {
                            MessageBox.Show("Faltan campos por llenar");
                        }
                    }
                    else { MessageBox.Show("No hay Tablas seleccionadas"); }
                }
            }
        }


        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }



        private void txtExistencia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void tabProducto_Click(object sender, EventArgs e)
        {

        }

        private void txtProveedorRFC_TextChanged(object sender, EventArgs e)
        {



        }

        private void RegistroClientesYProveedores_Load(object sender, EventArgs e)
        {
            incio = 0;
            if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabCliente"])
            {
                this.dataGridView1.DataSource = Connection.getData("Select p.Cliente,p.Direccion,p.RFC,CatCiudad.Ciudad from Cliente as p,CatCiudad where CatCiudad.idCiudad=p.idCiudad and p.Direccion != 'NULL' and p.Cliente != '' and p.RFC != 'NULL'");
                
            }
            else
            {
                if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProveedor"])
                {
                    this.dataGridView1.DataSource = Connection.getData("Select p.Proveedor,p.Direccion,p.RFC,CatCiudad.Ciudad from Proveedor as p,CatCiudad where CatCiudad.idCiudad=p.idCiudad and p.Direccion != 'NULL' and p.Proveedor != '' and p.RFC != 'NULL'");
                    
                }
                else
                {
                    if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProducto"])
                    {
                        this.dataGridView1.DataSource = Connection.getData("select p.Producto,p.Existencia,p.Precio,p.Unidad,c.Proveedor from Producto as p, conexion as c where p.Producto!='' and p.Unidad!='NULL' and c.Producto=p.Producto");
                    }
                    else { MessageBox.Show("No hay Tablas seleccionadas"); }
                }
            }
        }

        private void tabCliente_Click(object sender, EventArgs e)
        {

        }

        private void tbcCliente_Click(object sender, EventArgs e)
        {
            incio = 0;
            if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabCliente"])
            {
                this.dataGridView1.DataSource = Connection.getData("Select p.Cliente,p.Direccion,p.RFC,CatCiudad.Ciudad from Cliente as p,CatCiudad where CatCiudad.idCiudad=p.idCiudad and p.Direccion != 'NULL' and p.Cliente != '' and p.RFC != 'NULL'");
                txtCliente.Text = "";txtClienteDireccion.Text = "";txtClienteRFC.Text = "";cmbCiudad1.Text = "Tampico";
            }
            else
            {
                if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProveedor"])
                {
                    this.dataGridView1.DataSource = Connection.getData("Select p.Proveedor,p.Direccion,p.RFC,CatCiudad.Ciudad from Proveedor as p,CatCiudad where CatCiudad.idCiudad=p.idCiudad and p.Direccion != 'NULL' and p.Proveedor != '' and p.RFC != 'NULL'");
                    txtProveedor.Text = "";txtProveedorDireccion.Text = "";txtProveedorRFC.Text = "";cmbCiudad2.Text = "Tampico";
                }
                else
                {
                    if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProducto"])
                    {
                        this.dataGridView1.DataSource = Connection.getData("select p.Producto,p.Existencia,p.Precio,p.Unidad,c.Proveedor from Producto as p, conexion as c where p.Producto!='' and p.Unidad!='NULL' and c.Producto=p.Producto");
                        txtProducto.Text = "";txtPrecio.Text = "";txtExistencia.Text = "";cmbUnidad.Text = "";cmbProveedor.Text = "pruebaX";
                    }
                    else { MessageBox.Show("No hay Tablas seleccionadas"); }
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (inciop == 0)
            {
                inciop++;
                incio = 2;
            }
            else
            {
                if (incio == 0 || incio == 1)
                    incio++;
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {

                        if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabCliente"])
                        {

                            txtCliente.Text = row.Cells[0].Value.ToString();
                            txtClienteDireccion.Text = row.Cells[1].Value.ToString();
                            cmbCiudad1.Text = row.Cells[3].Value.ToString();
                            //cmbCiudad1.Items.Equals(row.Cells[3].Value.ToString());
                            txtClienteRFC.Text = row.Cells[2].Value.ToString();
                        }
                        else
                        {
                            if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProveedor"])
                            {


                                txtProveedor.Text = row.Cells[0].Value.ToString();
                                txtProveedorDireccion.Text = row.Cells[1].Value.ToString();
                                cmbCiudad2.Items.Equals(row.Cells[3].Value.ToString());
                                txtProveedorRFC.Text = row.Cells[2].Value.ToString();

                            }
                            else
                            {
                                if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProducto"])
                                {
                                    txtProducto.Text = row.Cells[0].Value.ToString();
                                    txtPrecio.Text = row.Cells[1].Value.ToString();
                                    txtExistencia.Text = row.Cells[2].Value.ToString();
                                    cmbUnidad.Text = row.Cells[3].Value.ToString();
                                    cmbProveedor.Text = row.Cells[4].Value.ToString();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabCliente"])
            {

                txtCliente.Clear();
                txtClienteDireccion.Clear();
                txtClienteRFC.Clear();
            }
            else
            {
                if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProveedor"])
                {

                    txtProveedor.Clear();
                    txtProveedorDireccion.Clear();
                    txtProveedorRFC.Clear();

                }
                else
                {
                    if (tbcCliente.SelectedTab == tbcCliente.TabPages["tabProducto"])
                    {
                        txtProducto.Clear();
                        txtExistencia.Clear();
                        cmbUnidad.SelectedIndex = -1;
                        txtPrecio.Clear();
                    }
                }
            }
        }
    }
} 
