using LenguajeDB.Utilidad;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenguajeDB.Interfaces
{
    public partial class Imprimir : Form
    {
        public Imprimir(List<LineaFactura> lineas, Cliente ctl, Totales tot)
        {
            InitializeComponent();
            this.lineas = lineas;
            this.ctl = ctl;
            this.tot = tot;
        }

        private List<LineaFactura> lineas { set; get; }
        private Cliente ctl { set; get; }
        private Totales tot { set; get; }


        private void Imprimir_Load_1(object sender, EventArgs e)
        {
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            ReportDataSource lines = new ReportDataSource();
            lines.Name = "LineasFactura";
            lines.Value = lineas;
            reportViewer1.LocalReport.DataSources.Add(lines);

            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(ctl);
            ReportDataSource client = new ReportDataSource();
            client.Name = "Cliente";
            client.Value = clientes;
            reportViewer1.LocalReport.DataSources.Add(client);

            List<ReportParameter> reportParameters = new List<ReportParameter>
        {
        new ReportParameter("pFecha", DateTime.Now.ToString()),
        new ReportParameter("pTotal", tot.Total.ToString())
        };

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
