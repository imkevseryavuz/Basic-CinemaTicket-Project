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
   public interface ITur
    {

        [WebGet(UriTemplate = "turlerJson", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Genre> GenderAsJson();


    }
}
