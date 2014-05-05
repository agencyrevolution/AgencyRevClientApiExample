using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using IPS.ClientApi.Messages;
using System.Runtime.Serialization;

namespace ClientApiWrapper.Models
{
    [DataContract(Namespace = "")]
    public class ApiResponse
    {
        [DataContract(Namespace = "")]
        public class MetaInfo
        {
            [DataMember]
            public HttpStatusCode ResponseCode { get; set; }
            [DataMember]
            public string Error { get; set; }
            [DataMember]
            public bool Result { get; set; }
            [DataMember]
            public string Help { get; set; }
        }

        [DataMember]
        public MetaInfo Meta { get; set; }
        [DataMember]
        public Account Account { get; set; }
    }
}


