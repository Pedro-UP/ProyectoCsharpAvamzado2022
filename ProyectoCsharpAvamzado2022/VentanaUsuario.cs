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
    public partial class VentanaUsuario : FormBase
    {
        public VentanaUsuario()
        {
            InitializeComponent();
        }

        private void VentanaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUsuario_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE IdUsuario=" + VentanaLogin.Codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNomUs.Text = DS.Tables[0].Rows[0]["NomUsuario"].ToString();
            lblUsu.Text = DS.Tables[0].Rows[0]["Account"].ToString();
            lblCodigoU.Text = DS.Tables[0].Rows[0]["IdUsuario"].ToString();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal ConP = new ContenedorPrincipal();
            this.Hide();
            ConP.Show();
        }
    }
}
