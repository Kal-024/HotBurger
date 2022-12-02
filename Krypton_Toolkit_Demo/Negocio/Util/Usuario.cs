using System.Data.SqlClient;
using System.Data;
using System;

namespace Krypton_Toolkit_Demo.Negocio.Util
{
    public class Usuario
    {
        int IdUsuario;
        string userName;
        string password;
        string NombreEmpleado;

        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string NombreEmpleado1 { get => NombreEmpleado; set => NombreEmpleado = value; }
        
        public bool changePassword(string oldPassword, string newPassword)
        {
            return true;
        }

        public static bool logIn(string username , string password)
        {
            if (username == null || password == null)
            {
                return false;
            }

            DataTable dt = new DataTable();
            ConexionDB conexion = ConexionDB.getInstance("Validar_Acceso");
    

                SqlParameter ParUsername = new SqlParameter("@usuario", SqlDbType.VarChar, 50);
                ParUsername.Value =username;


                SqlParameter ParPassword = new SqlParameter("@contraseña", SqlDbType.VarChar, 50);
                ParPassword.Value = password;

                conexion.sqlCommand.Parameters.Add(ParUsername);
                conexion.sqlCommand.Parameters.Add(ParPassword);

                conexion.conectar(dt);

                if(dt.Rows.Count > 0)
                {
                   if(dt.Rows[0][0].ToString().Equals("Acceso Denegado"))
                    {
                        return false;
                    }
                   
                }
                return true;
            }


        }

    
    }