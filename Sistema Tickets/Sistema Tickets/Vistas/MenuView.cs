using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Tickets.Vistas
{
    public partial class MenuView : SfForm
    {
        public MenuView()
        {
            InitializeComponent();

            this.Style.TitleBar.Height = 26;
            this.Style.TitleBar.BackColor = Color.White;
            this.Style.TitleBar.IconBackColor = Color.FromArgb(15, 161, 212);
            this.BackColor = Color.White;
            this.Style.TitleBar.ForeColor = ColorTranslator.FromHtml("#343434");
            this.Style.TitleBar.CloseButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MaximizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.MinimizeButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.HelpButtonForeColor = Color.DarkGray;
            this.Style.TitleBar.IconHorizontalAlignment = HorizontalAlignment.Left;
            this.Style.TitleBar.Font = this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.TitleBar.TextHorizontalAlignment = HorizontalAlignment.Center;
            this.Style.TitleBar.TextVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
        }

        TicketsView VistaTicket;
        DetalleView VistaDetalle;

        private void toolStripEx2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TicketTolStripButton_Click(object sender, EventArgs e)
        {
            if (VistaTicket == null)
            {
                VistaTicket = new TicketsView();
                VistaTicket.MdiParent = this;
                VistaTicket.FormClosed += Vista_FormClosed;
                VistaTicket.Show();
            }
            else
            {
                VistaTicket.Activate();
            }
        }
        private void Vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            VistaTicket = null;
        }

        private void DetalleTicketsToolStripButton_Click(object sender, EventArgs e)
        {
            if (VistaDetalle == null)
            {
                VistaDetalle = new DetalleView();
                VistaDetalle.MdiParent = this;
                VistaDetalle.FormClosed += VistaDetalle_FormClosed;
                VistaDetalle.Show();
            }
            else
            {
                VistaDetalle.Activate();
            }
        }

        private void VistaDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            VistaDetalle = null;
        }

        private void MenuView_Load(object sender, EventArgs e)
        {

        }

    }
}
