using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _PresentationLayer.Models
{
    public class Personeller
    {

        public int EmplooyeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmplooyeTC { get; set; }
        public string EmplooyeName { get; set; }
        public string EmplooyeSurname { get; set; }
        public string DateOfBirth { get; set; }
        public string GenderId { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
    }

    public class Status
    {
        [JsonProperty(PropertyName = "success", Order = 1)]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "reason", Order = 1)]
        public string Reason { get; set; }
    }

    public class BiletSatis
    {
        
        public int SaleId { get; set; }
        
        public string CustomerPhone { get; set; }
        
        public int TotalTicket { get; set; }
        
        public string MovieId { get; set; }
       
        public string DateOfPurchase { get; set; }
        

    }
    public class Musteriler
    {

        public int CustomerId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }

    public class Cinsiyet
    {

        public int GenderId { get; set; }

        public string GenderName { get; set; }

    }

    public class Turler
    {

        public int GenreId { get; set; }

        public string GenreName { get; set; }

    }

    public class Filmler
    {

        public int Moveid { get; set; }

        public string MovieName { get; set; }

        public string DirectorName { get; set; }

        public int GenreId { get; set; }

        public string VisionStartD { get; set; }

        public string VisionFinishD { get; set; }
    }
}
