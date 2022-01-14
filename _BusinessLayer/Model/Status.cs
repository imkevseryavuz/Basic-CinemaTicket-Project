using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer.Model
{
    [DataContract]
    public class Status
    {
        /// <summary>
        /// İşlem gerçekleşme durumu.
        /// </summary>
        [DataMember(Name = "success", Order = 1)]
        public bool Success { get; set; }

        /// <summary>
        /// Hata varsa sebebi.
        /// </summary>
        [DataMember(Name = "reason", Order = 2)]
        public string Reason { get; set; }

        /// <summary>
        /// Değerler instance alınırken set edilir.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="reason">Varsayılan olarak boştur.</param>
        public Status(bool success, string reason = "")
        {
            this.Success = success;
            this.Reason = reason;
        }
    }
}
