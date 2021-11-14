using Sistema_Tickets.Modelos.DAO;
using Sistema_Tickets.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Tickets.Controladores
{
    public class DetalleController
    {
        DetalleView vista;
        TicketDAO ticketDAO = new TicketDAO();

        public DetalleController(DetalleView view)
        {
            vista = view;
            vista.Load += new EventHandler(Load);
        }

        private void Load(object sender, EventArgs e)
        {
            ListarDetalle();
        }

        private void ListarDetalle()
        {
            vista.DetalleDataGridView.DataSource = ticketDAO.GetTickets();
        }
    }
}
