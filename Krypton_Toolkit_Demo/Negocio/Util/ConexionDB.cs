using System.Data;
using System.Data.SqlClient;
namespace Krypton_Toolkit_Demo.Negocio.Util
{
    public class ConexionDB
    {
        private static ConexionDB conexionDB;

        const string CnSaul = "Data Source= .; Initial Catalog=HotBurger; user=sa; password =123456";
        const string CnCaleb = "Data Source= .; Initial Catalog=HotBurger; user=sa; password =123456";
        
        SqlConnection sqlConnection;

        public SqlCommand sqlCommand = new SqlCommand();

        public SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

       private ConexionDB()
        {

        }
        
        
        public static ConexionDB getInstance(string nameProcedure)
        {
           if(conexionDB == null)
            {
                conexionDB = new ConexionDB();
                conexionDB.sqlConnection = new SqlConnection(CnSaul);
                conexionDB.sqlCommand.Connection = conexionDB.sqlConnection;
                conexionDB.sqlCommand.CommandType = CommandType.StoredProcedure;
                conexionDB.sqlDataAdapter.SelectCommand = conexionDB.sqlCommand;

            }
            conexionDB.sqlCommand.CommandText = nameProcedure;
            conexionDB.sqlCommand.Parameters.Clear();
            return conexionDB;
        }

        public void conectarPLectura(DataTable dt)
        {
           sqlConnection.Open();
           sqlDataAdapter.Fill(dt);
           desconectar();
        }

        public string  ConectarPEscritura()
        {
            sqlConnection.Open();
            string respuesta = sqlDataAdapter.SelectCommand.ExecuteNonQuery() == 0 ? "No se puede guardar registro" : "OK";
            desconectar();
            return respuesta;
        }

        void desconectar()
        {
            if(sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();

            }
        }

    }
}
