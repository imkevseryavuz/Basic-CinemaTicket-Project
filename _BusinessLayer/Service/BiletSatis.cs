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
    public class BiletSatis : IBiletSatisi
    {
        public static List<TicketSale> TicketSale = new List<TicketSale>();

        public void KategoriEkle(string customerPhone, string totalTicket, string movieId, string dateofPurchase)
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                TicketSale c = new TicketSale { CustomerPhone = customerPhone, TotalTicket = int.Parse(totalTicket),MovieId=movieId,DateOfPurchase=dateofPurchase };
                db.TicketSales.Add(c);
                db.SaveChanges();
            }
        }

        public List<TicketSale> TicketAsJson()
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                List<TicketSale> lst = new List<TicketSale>();
                foreach (var item in db.TicketSales)
                {
                    lst.Add(new TicketSale
                    {
                        SaleId = item.SaleId,
                        CustomerPhone = item.CustomerPhone,
                        TotalTicket = Convert.ToInt32(item.TotalTicket),
                        MovieId = item.MovieId,
                        DateOfPurchase = item.DateOfPurchase
                    });
                }
                return lst;
            }
        }

        //public Status TicketSaleAdd(TicketSale ticketsale)
        //{
        //    try
        //    {
        //        using (CinemaTicketEntities db = new CinemaTicketEntities())
        //        {
        //            TicketSale s = new TicketSale
        //            {
        //                CustomerPhone = ticketsale.CustomerPhone,
        //                TotalTicket = Convert.ToInt32(ticketsale.TotalTicket),
        //                MovieId = ticketsale.MovieId,
        //                DateOfPurchase = ticketsale.DateOfPurchase
        //            };
        //            db.TicketSales.Add(s);
        //            db.SaveChanges();
        //        }
        //        return new Status(true, "İşlem başarıyla gerçekleştirildi!");
        //    }
        //    catch (Exception ex)
        //    {
        //        return new Status(false, ex.ToString());
        //    }
        //}

        public Status TicketSaleDelete(TicketSale ticketsale)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    var foundUser = db.TicketSales.Where(x => x.SaleId == ticketsale.SaleId).FirstOrDefault();
                    if (foundUser != null)
                    {
                        db.TicketSales.Attach(foundUser);
                        db.TicketSales.Remove(foundUser);
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

        public Status TicketSaleUpdate(TicketSale ticketsale)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    var foundUser = db.TicketSales.Where(x => x.SaleId == ticketsale.SaleId).FirstOrDefault();
                    if (foundUser != null)
                    {
                        foundUser.CustomerPhone = ticketsale.CustomerPhone;
                        foundUser.TotalTicket = Convert.ToInt32(ticketsale.TotalTicket);
                        foundUser.MovieId = ticketsale.MovieId;
                        foundUser.DateOfPurchase = ticketsale.DateOfPurchase;

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
    }
    }

