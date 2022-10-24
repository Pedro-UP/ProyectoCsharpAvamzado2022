using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace ProyectoCsharpAvamzado2022
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void lblAtiende_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE IdUsuario=" + VentanaLogin.Codigo;

            DataSet ds;
            ds = Utilidades.Ejecutar(cmd);

            lblLeAtiende.Text = ds.Tables[0].Rows[0]["NomUsuario"].ToString().Trim();
        }

        private void txtCodC_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodC.Text.Trim()) == false)
            {
                try
                {
                    string cmd = string.Format("SELECT NombreCliente FROM Cliente WHERE idClientes='{0}'", txtCodC.Text.Trim());

                    DataSet ds = Utilidades.Ejecutar(cmd);

                    txtCliente.Text = ds.Tables[0].Rows[0]["NombreCliente"].ToString().Trim();

                    txtCodPro.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }
        }

        public static int cont_fila = 0;
        public static double total;

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    dataGridView2.Rows.Add(txtCodPro.Text, txtDescr.Text, txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView2.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView2.Rows[cont_fila].Cells[3].Value);
                    dataGridView2.Rows[cont_fila].Cells[4].Value = importe;

                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dataGridView2.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == txtCodPro.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        dataGridView2.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView2.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView2.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView2.Rows[num_fila].Cells[3].Value);

                        dataGridView2.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView2.Rows.Add(txtCodPro.Text, txtDescr.Text, txtPrecio.Text, txtCantidad.Text);
                        double importe = Convert.ToDouble(dataGridView2.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView2.Rows[cont_fila].Cells[3].Value);
                        dataGridView2.Rows[cont_fila].Cells[4].Value = importe;

                        cont_fila++;
                    }

                }
                txtCodPro.Text = "";
                txtDescr.Text = "";
                txtPrecio.Text = "";
                txtCantidad.Text = "";
                txtCodPro.Focus();

                total = 0;
                foreach (DataGridViewRow Fila in dataGridView2.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);
                }

                lblTotal.Text = "Mx$ " + total.ToString();
            }
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = "Mx$ " + total.ToString();

                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);

                cont_fila--;
            }
        }

        private void btnClie_Click(object sender, EventArgs e)
        {
            ConsultarClientes ConsClie = new ConsultarClientes();
            ConsClie.ShowDialog();

            if (ConsClie.DialogResult == DialogResult.OK)
            {
                txtCodC.Text = ConsClie.dataGridView1.Rows[ConsClie.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = ConsClie.dataGridView1.Rows[ConsClie.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                txtCodPro.Focus();
            }
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            ConsultasProductos ConPro = new ConsultasProductos();
            ConPro.ShowDialog();

            if (ConPro.DialogResult == DialogResult.OK)
            {
                txtCodPro.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescr.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                txtCantidad.Focus();
                errorProvider1.Clear();

            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public override void Nuevo()
        {
            txtCodC.Text = "";
            txtCliente.Text = "";
            txtCodPro.Text = "";
            txtDescr.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            lblTotal.Text = "Mx$ ";
            dataGridView2.Rows.Clear();
            cont_fila = 0;
            total = 0;
            txtCodC.Focus();
            errorProvider1.Clear();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            if (cont_fila != 0)
            {
                try
                {
                    string cmd = string.Format("Exec ActualizaFacturas '{0}'", txtCodC.Text.Trim());

                    DataSet ds = Utilidades.Ejecutar(cmd);

                    string Numfact = ds.Tables[0].Rows[0]["NumFact"].ToString().Trim();

                    foreach (DataGridViewRow Fila in dataGridView2.Rows) 
                    {
                        cmd = string.Format("Exec ActualizaDetalles '{0}','{1}','{2}','{3}'", Numfact, Fila.Cells[0].Value.ToString(), Fila.Cells[2].Value.ToString().Replace(',','.'), Fila.Cells[3].Value.ToString());
                        ds = Utilidades.Ejecutar(cmd);
                    }

                    cmd = "Exec Datosfactura " + Numfact;
                    ds = Utilidades.Ejecutar(cmd);

                    //Ventana Reporte
                    Reporte rp = new Reporte();

                    rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    rp.ShowDialog();

                    Nuevo(); 
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error " + error.Message);
                }
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
