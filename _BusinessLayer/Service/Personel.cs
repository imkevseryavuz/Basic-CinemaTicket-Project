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
    public class Personel : IPersonel
    {
        public static List<Emplooye> EmplooyeList = new List<Emplooye>();
        public List<Emplooye> EmplooyeAsJson()
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                List<Emplooye> lst = new List<Emplooye>();
                foreach (var item in db.Emplooyes)
                {
                    lst.Add(new Emplooye
                    {
                        EmplooyeId = item.EmplooyeId,
                        UserName=item.UserName,
                        Password=item.Password,
                        EmplooyeTC=item.EmplooyeTC,
                        EmplooyeName=item.EmplooyeName,
                        EmplooyeSurname=item.EmplooyeSurname,
                        DateOfBirth=item.DateOfBirth,
                        GenderId=item.GenderId,
                        StartDate=item.StartDate,
                        FinishDate=item.FinishDate
                    });
                }
                return lst;
            }
        }

        public Status EmplooyesAdd(Emplooye emplooye)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    Emplooye s = new Emplooye
                    {
                        UserName = emplooye.UserName,
                        Password = emplooye.Password,
                        EmplooyeTC = emplooye.EmplooyeTC,
                        EmplooyeName = emplooye.EmplooyeName,
                        EmplooyeSurname = emplooye.EmplooyeSurname,
                        DateOfBirth = emplooye.DateOfBirth,
                        GenderId = emplooye.GenderId,
                        StartDate = emplooye.StartDate,
                        FinishDate=emplooye.FinishDate
                    };
                    db.Emplooyes.Add(s);
                    db.SaveChanges();
                }
                return new Status(true, "İşlem başarıyla gerçekleştirildi!");
            }
            catch (Exception ex)
            {
                return new Status(false, ex.ToString());
            }
        }

        public Status Login(Emplooye emplooyee)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    var a = db.Emplooyes.Where(u => u.UserName == emplooyee.UserName && u.Password == emplooyee.Password).FirstOrDefault();
                    if (a == null)
                        return new Status(false, "Başarısız giriş");
                    else
                        return new Status(true, "Başarılı giriş");
                }
            }
            catch (Exception ex)
            {

                return new Status(false, ex.ToString());
            }
        }

        public Status OgretmenSil(Emplooye emplooye)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    var foundUser = db.Emplooyes.Where(x => x.EmplooyeId == emplooye.EmplooyeId).FirstOrDefault();
                    if (foundUser != null)
                    {
                        db.Emplooyes.Attach(foundUser);
                        db.Emplooyes.Remove(foundUser);
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

        public Status UpdateExam(Emplooye emplooye)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    var foundUser = db.Emplooyes.Where(x => x.EmplooyeId == emplooye.EmplooyeId).FirstOrDefault();
                    if (foundUser != null)
                    {
                        foundUser.UserName = emplooye.UserName;
                        foundUser.Password = emplooye.Password;
                        foundUser.EmplooyeTC = emplooye.EmplooyeTC;
                        foundUser.EmplooyeName = emplooye.EmplooyeName;
                        foundUser.EmplooyeSurname = emplooye.EmplooyeSurname;
                        foundUser.DateOfBirth = emplooye.DateOfBirth;
                        foundUser.GenderId = emplooye.GenderId;
                        foundUser.StartDate = emplooye.StartDate;
                        foundUser.FinishDate = emplooye.FinishDate;
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
