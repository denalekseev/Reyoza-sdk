using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReyozaSdk.DataContracts.Documents
{
    [DataContract]
    public class GetOrdersRequest
    {
        [DataMember(Name = "page")]
        public long? Page { get; set; }

        [DataMember(Name = "limit ")]
        public long? Limit { get; set; }
      
        [DataMember(Name = "dateFrom ")]
        public long? DateFrom { get; set; }
    }
}
