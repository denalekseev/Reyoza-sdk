using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReyozaSdk.DataContracts.Documents
{
    [DataContract]
    public class SendOrderStatusRequest
    {
        [DataMember(Name = "action")]
        public SendOrderStatusAction Action { get; set; } = SendOrderStatusAction.UpdateStatus;

        [DataMember(Name = "order_id")]
        public string OrderId { get; set; }

        [DataMember(Name = "supplier_status")]
        public string SupplierStatus { get; set; }

        [DataMember(Name = "tracking_number")]
        public string TrackingNumber { get; set; }
    }
}
