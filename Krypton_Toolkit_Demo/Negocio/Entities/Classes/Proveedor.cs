namespace Krypton_Toolkit_Demo.Negocio.Entities.Classes
{
    internal class Proveedor
    {
        int id;
        string nombre;
        string telefono;
        string direccion;
        string correo;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}
