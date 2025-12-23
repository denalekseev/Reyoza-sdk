using ReyozaSdk.DataContracts;
using Restub;

namespace ReyozaSdk
{
    /// <summary>
    /// Reyoza API Credentials.
    /// </summary>
    public class ReyozaCredentials : Credentials<ReyozaClient, ReyozaAuthToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReyozaCredentials"/> class.
        /// </summary>
        public ReyozaCredentials()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReyozaCredentials"/> class.
        /// </summary>
        /// <param name="clientAccount">Client account.</param>
        /// <param name="clientSecret">Client secret.</param>
        public ReyozaCredentials(string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Gets or sets client ApiKey
        /// </summary>
        public string ApiKey { get; set; }

        public override ReyozaAuthToken Authenticate(ReyozaClient client)
        {
            return new ReyozaAuthToken()
            {
                ApiKey = ApiKey
            };
        }
    }
}
