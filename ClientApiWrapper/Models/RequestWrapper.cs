using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiWrapper.Models
{
    [DataContract(Namespace = "")]
    public class RequestWrapper
    {
        public class MetaDataObject
        {
            [DataMember]
            public string ListId { get; set; }
            [DataMember]
            public string KeyField { get; set; }
            [DataMember]
            public string System { get; set; }
            [DataMember]
            public string DataType { get; set; }
            [DataMember]
            public short SchemaVersion { get; set; }
        }
        [DataMember]
        public MetaDataObject MetaData { get; set; }
        [DataMember]
        public object[] Data { get; set; }
    }
}
