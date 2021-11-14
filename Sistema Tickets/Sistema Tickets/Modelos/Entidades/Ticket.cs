using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Tickets.Modelos.Entidades
{
    public class Ticket
    {
        public int IdTicket { get; set; }
        public string SoporteTicket { get; set; }
        public string EstadoTicket { get; set; }
        public string DetalleTicket { get; set; }
    }
}
