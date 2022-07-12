using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=PC-DARKSLAYER-X;Initial Catalog=AdministracionBD2022;Persist Security Info=True;User ID=sa;Password=pedroluis2992");
            Conexion.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);

            DP.Fill(DS);

            Conexion.Close();

            return DS;
        }

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;

            foreach (Control item in Objeto.Controls)
            {
                if (item is ErrortxtBox)
                {
                    ErrortxtBox Obj = (ErrortxtBox)item;

                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "No puede estar vacio");
                            HayErrores = true;
                        }
                    }
                    if (Obj.SoloNumeros == true)
                    {
                        int cont = 0, LetraEncontrada = 0;

                        foreach (char letra in Obj.Text.Trim())
                        {
                            if (char.IsLetter(Obj.Text.Trim(), cont)) 
                            {
                                LetraEncontrada++;
                            }
                            cont++;
                        }
                        if (LetraEncontrada != 0)
                        {
                            HayErrores = true;
                            ErrorProvider.SetError(Obj, "Solo Numeros.");
                        }
                    }
                }
            }
            return HayErrores;
        }
    }
}
