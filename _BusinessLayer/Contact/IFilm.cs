using _DataLayer;
using System.ServiceModel;
using System.ServiceModel.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _BusinessLayer.Model;

namespace _BusinessLayer.Contact
{
    [ServiceContract]
  public  interface IFilm
    {
        [WebInvoke(UriTemplate = "filmEkle", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status MovieAdd(Movy movie);

        [WebInvoke(UriTemplate = "filmSil", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status MovieDelete(Movy movie);

        [WebInvoke(UriTemplate = "filmGuncelle", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status MovieUpdate(Movy movie);

        [WebGet(UriTemplate = "filmbul?filmadi={filmadi}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<MovieRestList> filmbul(string filmadi);


        [WebGet(UriTemplate = "filmJson", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<MovieRestList> MovieAsJson();


        [WebGet(UriTemplate = "genrefind?turbyfilm={name}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<SP_GetMovieByGender_Result> First(string name);

 

    }
}
