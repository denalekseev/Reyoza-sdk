using System.Runtime.Serialization;

namespace ReyozaSdk.DataContracts
{
    /// <summary>
    /// Order supplier status.
    /// </summary>
    [DataContract]
    public enum SendOrderStatusAction
    {
        /// <summary>
        /// Обновление статуса
        /// </summary>
        [EnumMember(Value = "update_status")]
        UpdateStatus
    }
}