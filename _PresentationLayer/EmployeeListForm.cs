using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _PresentationLayer.PersonelServiceReference;
using _PresentationLayer.Models;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;

namespace _PresentationLayer
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }
        private async void CinsiyetList()
        {
            HttpClient client = new HttpClient();
            var donen = await client.GetAsync("http://kevser.etikbiri.net/CinsiyetService.svc/cinsiyetJson").Result.Content.ReadAsStringAsync();
            cmbGender.DataSource = JsonConvert.DeserializeObject<List<Cinsiyet>>(donen);
            cmbGender.DisplayMember = "GenderName";
        }
        public async void PersonelList()
        {
            HttpClient client = new HttpClient();
            var donen = await client.GetAsync("http://kevser.etikbiri.net/PersonelService.svc/calisanJson").Result.Content.ReadAsStringAsync();
            dtList.DataSource = JsonConvert.DeserializeObject<List<Personeller>>(donen);
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            CinsiyetList();
            PersonelList();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
              Personeller personel = new Personeller
            {
                 EmplooyeId= id
            };
            string jsonBody = JsonConvert.SerializeObject(personel);
            HttpClient client = new HttpClient();
            var statusCode = await client.PostAsync("http://kevser.etikbiri.net/PersonelService.svc/calisanSil", new StringContent(jsonBody, Encoding.UTF8, "application/json"));
            Status status = JsonConvert.DeserializeObject<Status>(await statusCode.Content.ReadAsStringAsync());
            MessageBox.Show(status.Reason);
            PersonelList();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller()
            {
                EmplooyeId = int.Parse(txtId.Text),
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                EmplooyeTC = txtTc.Text,
                EmplooyeName = txtName.Text,
                EmplooyeSurname = txtSurname.Text,
                DateOfBirth = txtBirth.Text,
                GenderId = cmbGender.Text,
                StartDate = txtSD.Text,
                FinishDate = txtFD.Text,
            };
            string jsonBody = JsonConvert.SerializeObject(personeller);

            HttpClient client = new HttpClient();
            var response = await client.PostAsync("http://kevser.etikbiri.net/PersonelService.svc/calisanGuncelle", new StringContent(jsonBody, Encoding.UTF8, "application/json"));
            PersonelList();
        }
        int id;
        private void dtList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dtList.Rows[e.RowIndex].Cells["EmplooyeId"].Value);

            txtId.Text = dtList.Rows[e.RowIndex].Cells["EmplooyeId"].Value.ToString();
            txtUserName.Text = dtList.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            txtPassword.Text = dtList.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            txtTc.Text = dtList.Rows[e.RowIndex].Cells["EmplooyeTC"].Value.ToString();
            txtName.Text = dtList.Rows[e.RowIndex].Cells["EmplooyeName"].Value.ToString();
            txtSurname.Text = dtList.Rows[e.RowIndex].Cells["EmplooyeSurname"].Value.ToString();
            txtBirth.Text = dtList.Rows[e.RowIndex].Cells["DateOfBirth"].Value.ToString();
            cmbGender.Text = dtList.Rows[e.RowIndex].Cells["GenderId"].Value.ToString();
            txtSD.Text = dtList.Rows[e.RowIndex].Cells["StartDate"].Value.ToString();
            txtFD.Text = dtList.Rows[e.RowIndex].Cells["FinishDate"].Value.ToString();
        }
    }
}
