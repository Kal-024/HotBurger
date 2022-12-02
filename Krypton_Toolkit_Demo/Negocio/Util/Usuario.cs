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

        public bool logIn(string username , string password)
        {
            return false;
        }

    
    }
}
