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
public    interface IMusteri
    {
        [WebInvoke(UriTemplate = "musteriEkle", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status CustomerAdd(Customer customer);

        /*Mobil Interface si*/
        [WebInvoke(UriTemplate = "musteriAdd?userName={userName}&password={password}&customerName={customerName}&customerSurname={customerSurname}&phone={phone}&address={address}", Method = "POST")]
        [OperationContract]
        void MusteriEkle(string userName, string password, string customerName, string customerSurname,string phone,string address);



        [WebInvoke(UriTemplate = "musteriSil", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status CustomerDelete(Customer customer);

        [WebInvoke(UriTemplate = "musteriGuncelle", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status CustomerUpdate(Customer customer);

      
        [WebGet(UriTemplate = "musteriLogin?username={username}&password={password}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        LoginResult Login(string username, string password);

        [WebGet(UriTemplate = "musteriJson", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Customer> CustomerAsJson();
    }
}
