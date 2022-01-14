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
    public partial class MovieListForm : Form
    {
        public MovieListForm()
        {
            InitializeComponent();
        }
        public class MovieRestList
        {
                public int Moveid { get; set; }
                public string MovieName { get; set; }
                public string DirectorName { get; set; }
                public string GenreName { get; set; }
                public string VisionStartD { get; set; }
                public string VisionFinishD { get; set; }
            
        }
        public async void FilmList()
        {
            HttpClient client = new HttpClient();
            var donen = await client.GetAsync("http://kevser.etikbiri.net/FilmService.svc/filmJson").Result.Content.ReadAsStringAsync();
            dataGridView1.DataSource = JsonConvert.DeserializeObject<List<MovieRestList>>(donen);
        }
        private async void TurlerList()
        {
            HttpClient client = new HttpClient();
            var donen = await client.GetAsync("http://kevser.etikbiri.net/TurService.svc/turlerJson").Result.Content.ReadAsStringAsync();
            cmbGenre.DataSource = JsonConvert.DeserializeObject<List<Turler>>(donen);
            cmbGenre.DisplayMember = "GenreName";
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            Filmler ogr = new Filmler()
            {
                Moveid = int.Parse(txtId.Text),
                MovieName = txtMovieName.Text,
                DirectorName = txtDirector.Text,
                GenreId = cmbGenre.SelectedIndex,
                VisionStartD = txtVisionSD.Text,
                VisionFinishD = txtVisionFD.Text,
          
            };
            string jsonBody = JsonConvert.SerializeObject(ogr);

            HttpClient client = new HttpClient();
            var response = await client.PostAsync("http://kevser.etikbiri.net/FilmService.svc/filmGuncelle", new StringContent(jsonBody, Encoding.UTF8, "application/json"));
            FilmList();
        }

        private void MovieListForm_Load(object sender, EventArgs e)
        {
            TurlerList();
            FilmList();
        }
        int id;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Moveid"].Value);

            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["Moveid"].Value.ToString();
            txtMovieName.Text = dataGridView1.Rows[e.RowIndex].Cells["MovieName"].Value.ToString();
            txtDirector.Text = dataGridView1.Rows[e.RowIndex].Cells["DirectorName"].Value.ToString();
            cmbGenre.Text = dataGridView1.Rows[e.RowIndex].Cells["GenreName"].Value.ToString();
            txtVisionSD.Text = dataGridView1.Rows[e.RowIndex].Cells["VisionStartD"].Value.ToString();
            txtVisionFD.Text = dataGridView1.Rows[e.RowIndex].Cells["VisionFinishD"].Value.ToString();

        }


    }
}
