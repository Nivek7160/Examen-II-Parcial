using Sistema_Tickets.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Tickets.Vistas
{
    public partial class DetalleView : Form
    {
        public DetalleView()
        {
            InitializeComponent();
            DetalleController controller = new DetalleController(this);
        }
    }
}
