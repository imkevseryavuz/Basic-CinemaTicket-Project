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

    public class Musteri : IMusteri
    {
        public static List<Customer> CustomerList = new List<Customer>();
        public Status CustomerAdd(Customer customer)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    Customer s = new Customer
                    {
                        UserName = customer.UserName,
                        Password = customer.Password,
                        CustomerName = customer.CustomerName,
                        CustomerSurname = customer.CustomerSurname,
                        Phone = customer.Phone,
                        Address = customer.Address
                    };
                    db.Customers.Add(s);
                    db.SaveChanges();
                }
                return new Status(true, "İşlem başarıyla gerçekleştirildi!");
            }
            catch (Exception ex)
            {
                return new Status(false, ex.ToString());
            }
        }

        public List<Customer> CustomerAsJson()
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                List<Customer> lst = new List<Customer>();
                foreach (var item in db.Customers)
                {
                    lst.Add(new Customer
                    {
                        CustomerId = item.CustomerId,
                        UserName = item.UserName,
                        Password = item.Password,
                        CustomerName = item.CustomerName,
                        CustomerSurname = item.CustomerSurname,
                        Phone = item.Phone,
                        Address = item.Address
                    });
                }
                return lst;
            }
        }

        public Status CustomerDelete(Customer customer)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    var foundUser = db.Customers.Where(x => x.CustomerId == customer.CustomerId).FirstOrDefault();
                    if (foundUser != null)
                    {
                        db.Customers.Attach(foundUser);
                        db.Customers.Remove(foundUser);
                        db.SaveChanges();
                    }
                    else
                    {
                        return new Status(false, "Kullanıcı bulunamadı!");
                    }
                }
                return new Status(true, "silindi");
            }
            catch (Exception ex)
            {
                return new Status(false, ex.Message.ToString());
            }
        }

        public Status CustomerUpdate(Customer customer)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    var foundUser = db.Customers.Where(x => x.CustomerId == customer.CustomerId).FirstOrDefault();
                    if (foundUser != null)
                    {
                        foundUser.UserName = customer.UserName;
                        foundUser.Password = customer.Password;
                        foundUser.CustomerName = customer.CustomerName;
                        foundUser.CustomerSurname = customer.CustomerSurname;
                        foundUser.Phone = customer.Phone;
                        foundUser.Address = customer.Address;
                        db.SaveChanges();
                    }
                    else
                    {
                        return new Status(false, "Kullanıcı bulunamadı!");
                    }
                }
                return new Status(true, "Başarıyla Güncellendi");
            }
            catch (Exception ex)
            {
                return new Status(false, ex.Message.ToString());
            }
        }


        public LoginResult Login(string username, string password)
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                try
                {
                    var user = db.Customers.Where(m => m.UserName == username && m.Password == password).FirstOrDefault();
                    if (user != null)
                    {
                        
                        return LoginResult.Sucsses;
                    }
                    else
                    {
                        return LoginResult.UserNotFound;
                    }
                }
                catch
                {

                    return LoginResult.Error;
                }
            }
        }

        public void MusteriEkle(string userName, string password, string customerName, string customerSurname, string phone, string address)
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                Customer c = new Customer { UserName = userName, Password = userName, CustomerName = customerName, CustomerSurname = customerSurname, Phone=phone,Address=address };
                db.Customers.Add(c);
                db.SaveChanges();
            }
        }
    }
}
