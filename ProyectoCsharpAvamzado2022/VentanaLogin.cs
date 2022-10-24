using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;

namespace ProyectoCsharpAvamzado2022
{
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static String Codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE Account='{0}' AND Password='{1}'", txtUser.Text.Trim(), txtPass.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contraseña = ds.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (cuenta == txtUser.Text.Trim() && contraseña == txtPass.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true) 
                    {
                        VentanaAdmin VentAdm = new VentanaAdmin();
                        this.Hide();
                        VentAdm.Show();
                    }
                    else
                    {
                        VentanaUsuario VentUser = new VentanaUsuario();
                        this.Hide();
                        VentUser.Show();
                    }
                }
               
            }
            catch (Exception error)
            {
                MessageBox.Show("Error de usuario");
            }
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
