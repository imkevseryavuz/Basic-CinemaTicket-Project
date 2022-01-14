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
    public partial class CustomerAddForm : Form
    {
        public CustomerAddForm()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
             Musteriler musteri = new Musteriler()
            {

                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                CustomerName = txtName.Text,
                CustomerSurname = txtSurname.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
             
            };
            string jsonBody = JsonConvert.SerializeObject(musteri);
            HttpClient client = new HttpClient();
            var response = await client.PostAsync("http://kevser.etikbiri.net/MusteriService.svc/musteriEkle", new StringContent(jsonBody, Encoding.UTF8, "application/json"));

        }
    }
    }

