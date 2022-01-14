using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _PresentationLayer.MusteriServiceReference;
using _PresentationLayer.Models;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;

namespace _PresentationLayer
{
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        public async void MusteriList()
        {
            HttpClient client = new HttpClient();
            var donen = await client.GetAsync("http://kevser.etikbiri.net/MusteriService.svc/musteriJson").Result.Content.ReadAsStringAsync();
            dataGridView1.DataSource = JsonConvert.DeserializeObject<List<Musteriler>>(donen);
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            
            MusteriList();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Musteriler ogr = new Musteriler
            {
                 CustomerId= id
            };
            string jsonBody = JsonConvert.SerializeObject(ogr);
            HttpClient client = new HttpClient();
            var statusCode = await client.PostAsync("http://kevser.etikbiri.net/MusteriService.svc/musteriSil", new StringContent(jsonBody, Encoding.UTF8, "application/json"));
            Status status = JsonConvert.DeserializeObject<Status>(await statusCode.Content.ReadAsStringAsync());
            MessageBox.Show(status.Reason);
            MusteriList();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Musteriler ogr = new Musteriler()
            {
                CustomerId = int.Parse(txtId.Text),
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                CustomerName = txtName.Text,
                CustomerSurname = txtSurname.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
            };
            string jsonBody = JsonConvert.SerializeObject(ogr);

            HttpClient client = new HttpClient();
            var response = await client.PostAsync("http://kevser.etikbiri.net/MusteriService.svc/musteriGuncelle", new StringContent(jsonBody, Encoding.UTF8, "application/json"));
            MusteriList();
        }
        int id;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          

            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value);

            txtId.Text= dataGridView1.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString();
            txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells["CustomerSurname"].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
        }
    }
}
