using System;

namespace Krypton_Toolkit_Demo.Negocio.Entities.Classes
{
    internal class Caja
    {
        int id;
        DateTime FechaCierre;
        float EfectivoInicial;
        float EfectivoFinal;
        float DepositoDia;
        float gastos;
        int IdUsuario;

        public int Id { get => id; set => id = value; }
        public DateTime FechaCierre1 { get => FechaCierre; set => FechaCierre = value; }
        public float EfectivoInicial1 { get => EfectivoInicial; set => EfectivoInicial = value; }
        public float EfectivoFinal1 { get => EfectivoFinal; set => EfectivoFinal = value; }
        public float DepositoDia1 { get => DepositoDia; set => DepositoDia = value; }
        public float Gastos { get => gastos; set => gastos = value; }
        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
    }
}
