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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Personeller ogr = new Personeller()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };
            string jsonBody = JsonConvert.SerializeObject(ogr);
            HttpClient client = new HttpClient();
            var response = await client.PostAsync("http://kevser.etikbiri.net/PersonelService.svc/calisanLogin", new StringContent(jsonBody, Encoding.UTF8, "application/json"));
            Status status = JsonConvert.DeserializeObject<Status>(await response.Content.ReadAsStringAsync());
            MessageBox.Show(status.Reason);
            if(status.Success)
            {
                Menu frm = new Menu();
                this.Hide();
                frm.ShowDialog();
            }


        }
    }
}
