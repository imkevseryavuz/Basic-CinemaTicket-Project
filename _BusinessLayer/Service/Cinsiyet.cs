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
    public class Cinsiyet : ICinsiyet
    {
        public static List<Gender> EmplooyeList = new List<Gender>();
        public List<Gender> GenderAsJson()
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                List<Gender> lst = new List<Gender>();
                foreach (var item in db.Genders)
                {
                    lst.Add(new Gender
                    {
                        GenderId = item.GenderId,
                        GenderName = item.GenderName

                    });
                }
                return lst;
            }
        }
    }
}
