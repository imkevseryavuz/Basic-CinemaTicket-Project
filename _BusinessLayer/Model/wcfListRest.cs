using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _BusinessLayer.Model
{
    [DataContract]
    public class MovieRestList
    {
        [DataMember]
        public string Moveid { get; set; }
        [DataMember]
        public string MovieName { get; set; }
        [DataMember]
        public string DirectorName{ get; set; }
        [DataMember]
        public string GenreName { get; set; }
        [DataMember]
        public string VisionStartD { get; set; }
        [DataMember]
        public string VisionFinishD { get; set; }
    }
}
