using Krypton_Toolkit_Demo.Negocio.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Negocio.Entities.Classes
{
    internal class Menu
    {
        int id;
        string codigo;
        string Nombre;
        string descripcion;
        float precio;
        List<CInventario> insumos;
        Categoria categoria;

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Precio { get => precio; set => precio = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
        internal List<CInventario> Insumos { get => insumos; set => insumos = value; }
    }
}
