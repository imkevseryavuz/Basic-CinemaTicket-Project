using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PresentationLayer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            MovieAddForm movie = new MovieAddForm();
            movie.ShowDialog();
        }

        private void btnFilmListesi_Click(object sender, EventArgs e)
        {
            MovieListForm movieForm = new MovieListForm();
            movieForm.ShowDialog();
        }

        private void btnBiletListesi_Click(object sender, EventArgs e)
        {
            TicketSalesForm ticketForm = new TicketSalesForm();
            ticketForm.ShowDialog();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            CustomerAddForm customeraddForm = new CustomerAddForm();
            customeraddForm.ShowDialog();
        }

        private void btnMusteriListesi_Click(object sender, EventArgs e)
        {
            CustomerListForm customerlistForm = new CustomerListForm();
            customerlistForm.ShowDialog();
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeelistform = new EmployeeListForm();
            employeelistform.ShowDialog();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            EmployeeAddForm emplooyeaddform = new EmployeeAddForm();
            emplooyeaddform.ShowDialog();
        }
    }
}
