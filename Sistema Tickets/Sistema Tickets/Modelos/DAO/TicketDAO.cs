using Sistema_Tickets.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Tickets.Modelos.DAO
{

    public class TicketDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool GenerarTicket(Ticket ticket)
        {
            bool inserto = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKET ");
                sql.Append(" VALUES (@Soporte, @Estado, @Detalle);");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Soporte", SqlDbType.NVarChar, 50).Value = ticket.SoporteTicket;
                comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 50).Value = ticket.EstadoTicket;
                comando.Parameters.Add("@Detalle", SqlDbType.NVarChar, 50).Value = ticket.DetalleTicket;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetTickets()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TICKET ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dt;
        }
    }
}
