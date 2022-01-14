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
 public   interface IBiletSatisi
    {
        //[WebInvoke(UriTemplate = "biletsatisEkle", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        //[OperationContract]
        //Status TicketSaleAdd(TicketSale ticketsale);

        [WebInvoke(UriTemplate = "biletsatisEkle?customerPhone={customerPhone}&totalTicket={totalTicket}&movieId={movieId}&dateofPurchase={dateofPurchase}", Method = "POST")]
        [OperationContract]
        void KategoriEkle(string customerPhone, string totalTicket, string movieId, string dateofPurchase);

        [WebInvoke(UriTemplate = "biletsatisSil", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status TicketSaleDelete(TicketSale ticketsale);

        [WebInvoke(UriTemplate = "biletsatisGuncelle", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [OperationContract]
        Status TicketSaleUpdate(TicketSale ticketsale);


        [WebGet(UriTemplate = "biletsatisJson", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<TicketSale> TicketAsJson();
    }
}
