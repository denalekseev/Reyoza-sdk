using ReyozaSdk.DataContracts;
using Restub;

namespace ReyozaSdk
{
    /// <summary>
    /// Reyoza API authenticator using credentials.
    /// </summary>
    internal class ReyozaAuthenticator : Authenticator<ReyozaClient, ReyozaAuthToken>
    {
        public ReyozaAuthenticator(ReyozaClient apiClient, ReyozaCredentials credentials)
            : base(apiClient, credentials)
        {
        }

        public override void InitAuthHeaders(ReyozaAuthToken authToken) =>
            AuthHeaders["X-API-Key"] = $"{authToken.ApiKey}";
    }
}
