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
    public partial class EmployeeAddForm : Form
    {
        public EmployeeAddForm()
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Personeller musteri = new Personeller()
            {

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
            string jsonBody = JsonConvert.SerializeObject(musteri);
            HttpClient client = new HttpClient();
            var response = await client.PostAsync("http://kevser.etikbiri.net/PersonelService.svc/calisanEkle", new StringContent(jsonBody, Encoding.UTF8, "application/json"));

        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            CinsiyetList();
        }
    }
}
