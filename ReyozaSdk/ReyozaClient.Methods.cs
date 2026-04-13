using ReyozaSdk.DataContracts;
using ReyozaSdk.DataContracts.Documents;
using RestSharp;
using Restub.Toolbox;
using System.Linq;

namespace ReyozaSdk
{
    /// <remarks>
    /// Reyoza API Client, methods.
    /// </remarks>
    public partial class ReyozaClient
    {
        /// <summary>
        /// Получить список заказов
        /// </summary>
        public GetOrdersResponse GetOrders(DataContracts.Documents.GetOrdersRequest request, string[] statuses, string[] ids) =>
            Get<GetOrdersResponse>($"", r => AddQueryString(request, r, statuses, ids));

        public void InitRequest(IRestRequest initReq)
        {
            initReq.AddHeader("Content-Type", "application/json");
            initReq.AddHeader("Accept", "application/json");
        }

        /// <summary>
        /// Передать статус заказа
        /// </summary>
        public void SendOrderStatus(string orderId, string supplierStatus, string trackingNumber)
        {
            var req = new SendOrderStatusRequest()
            {
                OrderId = orderId,
                Action = SendOrderStatusAction.UpdateStatus,
                SupplierStatus = supplierStatus,
                TrackingNumber = trackingNumber
            };

            Post<GetOrdersResponse>($"", req,  r => InitRequest(r));
        }


        public void AddQueryString(DataContracts.Documents.GetOrdersRequest req, IRestRequest initReq, string[] statuses, string[] ids)
        {
            InitRequest(initReq);

            initReq.AddQueryParameter("page", req.Page.ToString());
            initReq.AddQueryString(req);

            if (statuses != null && statuses.Any())
            {
                foreach (var item in statuses.Where(r => !string.IsNullOrWhiteSpace(r)))
                {
                    initReq.AddQueryParameter("statuses", item);
                }
            }

            if (ids != null && ids.Any())
            {
                foreach (var item in ids.Where(r => !string.IsNullOrWhiteSpace(r)))
                {
                    initReq.AddQueryParameter("ids", item);
                }
            }
        }
    }
}