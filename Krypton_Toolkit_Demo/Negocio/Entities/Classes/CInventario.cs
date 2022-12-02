namespace Krypton_Toolkit_Demo.Negocio.Entities.Classes
{
    internal class CInventario
    {
        int id;
        string codigoI;
        string nombre;
        string descripcion;
        int cantidadLimite;
        int cantidadActual;
        Proveedor proveedor;

        public int Id { get => id; set => id = value; }
        public string CodigoI { get => codigoI; set => codigoI = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CantidadLimite { get => cantidadLimite; set => cantidadLimite = value; }
        public int CantidadActual { get => cantidadActual; set => cantidadActual = value; }
        public Proveedor Proveedor { get => proveedor; set => proveedor = value; }
    }
}
