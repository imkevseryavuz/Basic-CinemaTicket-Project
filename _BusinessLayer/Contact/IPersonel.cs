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
   public interface IPersonel
    {
        [WebInvoke(UriTemplate = "calisanEkle", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status EmplooyesAdd(Emplooye emplooye);

        [WebInvoke(UriTemplate = "calisanSil", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status OgretmenSil(Emplooye emplooye);
        [WebInvoke(UriTemplate = "calisanGuncelle", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status UpdateExam(Emplooye emplooye);

        [WebInvoke(UriTemplate = "calisanLogin", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status Login(Emplooye emplooyee);

        [WebGet(UriTemplate = "calisanJson", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Emplooye> EmplooyeAsJson();

        //[WebGet(UriTemplate = "bolumJson", ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //List<SP_Bolum_Result> BolumAsJson();
    }
}
