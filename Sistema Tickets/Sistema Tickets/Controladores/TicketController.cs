using Sistema_Tickets.Modelos.DAO;
using Sistema_Tickets.Modelos.Entidades;
using Sistema_Tickets.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Tickets.Controladores
{
   
    public class TicketController
    {
        TicketsView vista;
        Ticket ticket = new Ticket();
        TicketDAO ticketDao = new TicketDAO();

        public TicketController(TicketsView view)
        {
            vista = view;
            vista.GenerarButton.Click += new EventHandler(GenerarTicket);
        }

        private void GenerarTicket(object serder,EventArgs e)
        {
            
            if (vista.SoporteComboBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.SoporteComboBox, "Elija el soporte");
                vista.SoporteComboBox.Focus();
                return;
            }
            if (vista.EstadoComboBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.EstadoComboBox, "Elija el estado");
                vista.EstadoComboBox.Focus();
                return;
            }
            if (vista.DetalleTextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.DetalleTextBox, "Ingrese el detalle");
                vista.DetalleTextBox.Focus();
                return;
            }

            ticket.SoporteTicket = vista.SoporteComboBox.Text;
            ticket.EstadoTicket = vista.EstadoComboBox.Text;
            ticket.DetalleTicket = vista.DetalleTextBox.Text;

            bool inserto = ticketDao.GenerarTicket(ticket);

            if (inserto)
            {
                MessageBox.Show("Ticket generado exitosamente");

            }
            else
            {
                MessageBox.Show("Ticket erroneo");
            }
        }
    }
}
