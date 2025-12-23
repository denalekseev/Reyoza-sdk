using System;
using System.Collections.Generic;
using System.Linq;
using ReyozaSdk.DataContracts;
using ReyozaSdk.Toolbox;
using RestSharp;
using RestSharp.Authenticators;
using Restub;
using Restub.DataContracts;

namespace ReyozaSdk
{
    /// <summary>
    /// Reyoza API Client.
    /// </summary>
    public partial class ReyozaClient : RestubClient
    {
        /// <summary>
        /// Production API endpoint.
        /// </summary>
        public const string ProductionApiUrl = "https://crm.reyouza.ru/appx/api.php";

        /// <summary>
        /// Initializes a new instance of the <see cref="ReyozaClient"/> class.
        /// </summary>
        /// <param name="baseUrl">Base API endpoint.</param>
        /// <param name="credentials">Credentials.</param>
        public ReyozaClient(string baseUrl, ReyozaCredentials credentials)
            : base(baseUrl, credentials)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReyozaClient"/> class.
        /// </summary>
        /// <param name="сlient">REST API client.</param>
        /// <param name="credentials">Credentials.</param>
        public ReyozaClient(string baseUrl, string apiKey)
            : base(baseUrl, new ReyozaCredentials(apiKey))
        {
        }

        public ReyozaClient(string apiKey)
            : base(ProductionApiUrl, new ReyozaCredentials(apiKey))
        {
        }

        /// <inheritdoc/>
        public override string LibraryName =>
            $"{nameof(ReyozaSdk)}.{nameof(ReyozaClient)} v{LibraryVersion}, {base.LibraryName}";

        /// <inheritdoc/>
        protected override IAuthenticator GetAuthenticator() =>
            new ReyozaAuthenticator(this, (ReyozaCredentials)Credentials);

        /// <inheritdoc/>
        protected override IRestubSerializer CreateSerializer() =>
            new ReyozaSerializer();

        /// <inheritdoc/>
        protected override Exception CreateException(IRestResponse res, string msg, IHasErrors errors) =>
            new ReyozaException(res.StatusCode, msg, base.CreateException(res, msg, errors))
            {
                ErrorResponseText = res.Content,
            };
    }
}