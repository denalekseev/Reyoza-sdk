using System.Runtime.Serialization;
using Restub.DataContracts;

namespace ReyozaSdk.DataContracts
{
    [DataContract]
    public class ReyozaAuthToken : AuthToken
    {
        [DataMember(Name = "apiKey")]
        public string ApiKey { get; set; }
    }
}
