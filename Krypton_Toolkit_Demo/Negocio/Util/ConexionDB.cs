namespace Krypton_Toolkit_Demo.Negocio.Util
{
    public class ConexionDB
    {
        private static ConexionDB conexionDB;

       private ConexionDB()
        {

        }
        
        
        public ConexionDB getInstance()
        {
           if(conexionDB == null)
            {
                conexionDB = new ConexionDB();
            }
            return conexionDB;
        }

        public void conectar()
        {

        }

        public void desconectar()
        {

        }

    }
}
