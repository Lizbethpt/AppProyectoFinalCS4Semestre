using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppProyectoFinalCS4Semestre
{
    public partial class FrmBanxico : Form
    {
        bool maximizado;
        public FrmBanxico()
        {
            InitializeComponent();
            maximizado = false;
        }
        private void ConsultarDatos(Response response)
        {
            Serie serie = response.seriesResponse.Series[0];
            TVDatos.Nodes.Clear();

            TreeNode rootNode = new TreeNode(serie.Title);
            TVDatos.Nodes.Add(rootNode);

            foreach (DataSerie dataSerie in serie.Data)
            {
                if (dataSerie.Data.Equals("N/E")) continue;

                TreeNode node = new TreeNode();
                node.Text = "Fecha: " + dataSerie.Fecha + " - Precio: " + dataSerie.Data;
                rootNode.Nodes.Add(node);
            }
            TVDatos.ExpandAll();
        }
        private void GraficarDatos(Response response)
        {
            Chart1.Series.Clear();
            Serie serie = response.seriesResponse.Series[0];
            Series series = Chart1.Series.Add(serie.Title);
            series.ChartType = SeriesChartType.Line;

            foreach (DataSerie dataSerie in serie.Data)
            {
                if (dataSerie.Data.Equals("N/E")) continue;
                double precio = Convert.ToDouble(dataSerie.Data);
                DateTime fecha = DateTime.Parse(dataSerie.Fecha);
                series.Points.AddXY(fecha, precio);
            }
        }
        private static Response read(string fechaDesde, string fechaHasta)
        {
            try
            {
                string url = "https://www.banxico.org.mx/SieAPIRest/service/v1/series/SF43718/datos/" + fechaDesde + "/" + fechaHasta;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Accept = "application/json";
                request.Headers["Bmx-Token"] = "69260904c3e398685c78e54928e7129fb21c7f79443e3c8b59e5c91f8319ef47";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(string.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                }
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
                object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                Response jsonResponse = objResponse as Response;
                return jsonResponse;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
        private void chart1_Click_1(object sender, EventArgs e)
        {
            if (maximizado)
            {
                Chart1.Location = new System.Drawing.Point(436, 12);
                Chart1.Height = 240; Chart1.Width = 320;
                TVDatos.Visible = true;
                LblFechainicio.Visible = true;
                LblFechaFinal.Visible = true;
            }
            else
            {
                Chart1.Location = new System.Drawing.Point(0, 0);
                Chart1.Height = this.Height; Chart1.Width = this.Width;
                TVDatos.Visible = false;
                LblFechainicio.Visible = false;
                LblFechaFinal.Visible = false;
            }
            maximizado = !maximizado;
        }
        private void BtnConsultar_Click_1(object sender, EventArgs e)
        {
            string fechaDesde = DTFechaInicial.Value.ToString("yyyy-MM-dd");
            string fechaHasta = DTFechaFinal.Value.ToString("yyyy-MM-dd");
            Response response = read(fechaDesde, fechaHasta);
            if (response != null)
            {
                ConsultarDatos(response);
                GraficarDatos(response);
            }
        }
        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            {
                Chart1.Series.Clear();
            }
        }
        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
