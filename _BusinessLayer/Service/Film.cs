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


    public class Film : IFilm
    {
        public static List<Movy> MovieList = new List<Movy>();

       

        public List<MovieRestList> filmbul(string filmadi)
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                var _pro = db.Movies.Where(m => m.MovieName == filmadi).ToList();
                List < MovieRestList> mrl = new List<MovieRestList>();
                foreach (var item in _pro)
                {
                    Genre g = db.Genres.Find(item.GenreId);
                    mrl.Add(new MovieRestList {
                        Moveid = item.MovieId.ToString(),
                        MovieName = item.MovieName,
                        DirectorName = item.DirectorName,
                        GenreName=g.GenreName,
                        VisionStartD = item.VisionStartD,
                        VisionFinishD = item.VisionFinishD
                    });
                    
                }
                return mrl;
            }
        }

        public List<SP_GetMovieByGender_Result> First(string name)
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                var pro = db.SP_GetMovieByGender(name);
                List<SP_GetMovieByGender_Result> tempList = new List<SP_GetMovieByGender_Result>();
                foreach (var item in pro)
                {
                    tempList.Add(new SP_GetMovieByGender_Result
                    {
                        MovieId = item.MovieId,
                        MovieName = item.MovieName,
                        DirectorName = item.DirectorName,
                        VisionStartD = item.VisionStartD,
                        VisionFinishD = item.VisionFinishD

                    });
                }
                return tempList;
            }

        }


        public Status MovieAdd(Movy movie)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    Movy s = new Movy
                    {
                        MovieId = movie.MovieId,
                        MovieName = movie.MovieName,
                        DirectorName = movie.DirectorName,
                        GenreId = movie.GenreId,
                        VisionStartD = movie.VisionStartD,
                        VisionFinishD = movie.VisionFinishD
                    };
                    db.Movies.Add(s);
                    db.SaveChanges();
                }
                return new Status(true, "İşlem başarıyla gerçekleştirildi!");
            }
            catch (Exception ex)
            {
                return new Status(false, ex.ToString());
            }
        }

        public List<MovieRestList> MovieAsJson()
        {
            using (CinemaTicketEntities db = new CinemaTicketEntities())
            {
                List<MovieRestList> lst = new List<MovieRestList>();
                foreach (var item in db.Movies)
                {
                    Genre g = db.Genres.Find(item.GenreId);
                    lst.Add(new MovieRestList
                    {
                        Moveid = item.MovieId.ToString(),
                        MovieName = item.MovieName,
                        DirectorName = item.DirectorName,
                        GenreName = g.GenreName,
                        VisionStartD = item.VisionStartD,
                        VisionFinishD = item.VisionFinishD
                    });
                }
                return lst;
            }
        }

        public Status MovieDelete(Movy movie)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    var foundUser = db.Movies.Where(x => x.MovieId == movie.MovieId).FirstOrDefault();
                    if (foundUser != null)
                    {
                        db.Movies.Attach(foundUser);
                        db.Movies.Remove(foundUser);
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

        public Status MovieUpdate(Movy movie)
        {
            try
            {
                using (CinemaTicketEntities db = new CinemaTicketEntities())
                {
                    var foundUser = db.Movies.Where(x => x.MovieId == movie.MovieId).FirstOrDefault();
                    if (foundUser != null)
                    {
                        foundUser.MovieName = movie.MovieName;
                        foundUser.DirectorName = movie.DirectorName;
                        foundUser.GenreId = movie.GenreId;
                        foundUser.VisionStartD = movie.VisionStartD;
                        foundUser.VisionFinishD = movie.VisionFinishD;

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

