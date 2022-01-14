using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _BusinessLayer.Contact;
using _DataLayer;
using _BusinessLayer.Model;


namespace _BusinessLayer.Service
{
    public class Tur : ITur
    {
        public static List<Genre> GenreList = new List<Genre>();
        public List<Genre> GenderAsJson()
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                List<Genre> lst = new List<Genre>();
                foreach (var item in db.Genres)
                {
                    lst.Add(new Genre
                    {
                        GenreId = item.GenreId,
                        GenreName = item.GenreName
                    });
                }
                return lst;
            }
        }

       
    }
}
