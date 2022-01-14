using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _PresentationLayer.FilmServiceReference;
using _PresentationLayer.Models;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;

namespace _PresentationLayer
{
    public partial class MovieAddForm : Form
    {
        public MovieAddForm()
        {
            InitializeComponent();
        }
        private async void TurlerList()
        {
            HttpClient client = new HttpClient();
            var donen = await client.GetAsync("http://kevser.etikbiri.net/TurService.svc/turlerJson").Result.Content.ReadAsStringAsync();
            cmbGenre.DataSource = JsonConvert.DeserializeObject<List<Turler>>(donen);
            cmbGenre.DisplayMember = "GenreName";
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Filmler musteri = new Filmler()
            {

                MovieName = txtMovieName.Text,
                DirectorName = txtDirector.Text,
                GenreId = cmbGenre.SelectedIndex,
                VisionStartD = txtVisionSD.Text,
                VisionFinishD = txtVisionFD.Text,
            

            };
            string jsonBody = JsonConvert.SerializeObject(musteri);
            HttpClient client = new HttpClient();
            var response = await client.PostAsync("http://kevser.etikbiri.net/FilmService.svc/filmEkle", new StringContent(jsonBody, Encoding.UTF8, "application/json"));

        }

        private void MovieAddForm_Load(object sender, EventArgs e)
        {
            TurlerList();
        }
    }
    }

