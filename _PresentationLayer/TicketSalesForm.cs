using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _PresentationLayer.BiletSatisServiceReference;
using _PresentationLayer.Models;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;

namespace _PresentationLayer
{
    public partial class TicketSalesForm : Form
    {
        public TicketSalesForm()
        {
            InitializeComponent();
        }
        public async void BiletSatisList()
        {
            HttpClient client = new HttpClient();
            var donen = await client.GetAsync("http://kevser.etikbiri.net/BiletSatisService.svc/biletsatisJson").Result.Content.ReadAsStringAsync();
            dataGridView1.DataSource = JsonConvert.DeserializeObject<List<BiletSatis>>(donen);
        }

        private void TicketSalesForm_Load(object sender, EventArgs e)
        {
            BiletSatisList();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            BiletSatis ogr = new BiletSatis
            {
                SaleId = id
            };
            string jsonBody = JsonConvert.SerializeObject(ogr);
            HttpClient client = new HttpClient();
            var statusCode = await client.PostAsync("http://kevser.etikbiri.net/BiletSatisService.svc/biletsatisSil", new StringContent(jsonBody, Encoding.UTF8, "application/json"));
            Status status = JsonConvert.DeserializeObject<Status>(await statusCode.Content.ReadAsStringAsync());
            MessageBox.Show(status.Reason);
            BiletSatisList();
        }
        int id;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SaleId"].Value);
        }
    }
}
