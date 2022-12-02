using Krypton_Toolkit_Demo.Negocio.Entities.Classes;
using Krypton_Toolkit_Demo.Negocio.Interfaces;
using Krypton_Toolkit_Demo.Negocio.Util;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Krypton_Toolkit_Demo.Negocio.Implement.Pedido
{
    internal class VentaDaoImplement : VentaDao<Venta>
    {
        public bool Create(Venta entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Venta entity)
        {
            throw new System.NotImplementedException();
        }

       
        public DataTable GetAll()
        {
           
            throw new System.NotImplementedException();
        }

        public Venta GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public  DataTable GetVentaByDate(DateTime d)
        {
            DataTable dt = new DataTable();
            ConexionDB conexion = ConexionDB.getInstance("obtenerFacturarDia");


            SqlParameter ParFecha = new SqlParameter("@fecha", SqlDbType.DateTime);
            ParFecha.Value = d;

            conexion.sqlCommand.Parameters.Add(ParFecha);
            conexion.conectarPLectura(dt);
            return dt;
        }

        public bool Update(Venta entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
