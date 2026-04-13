////using System.Runtime.Serialization;

////namespace ReyozaSdk.DataContracts
////{
////    /// <summary>
////    /// Order supplier status.
////    /// </summary>
////    [DataContract]
////    public enum OrderSupplierStatus
////    {
////        /// <summary>
////        /// резерв подтвержден - если резерв при создании укомплектован 
////        /// </summary>
////        [EnumMember(Value = "approved")]
////        Approved,

////        /// <summary>
////        /// заказ в пути - подтип документа отгруженная доставка
////        /// </summary>
////        [EnumMember(Value = "in_transit")]
////        InTransit,

////        /// <summary>
////        /// готов к выдаче - здесь надо привязаться когда сдек нам отдаст этот статус, отдать им
////        /// </summary>
////        [EnumMember(Value = "ready_for_issue")]
////        ReadyForIssue,

////        /// <summary>
////        /// вручен - десь надо привязаться когда сдек нам отдаст этот статус, отдать им
////        /// </summary>
////        [EnumMember(Value = "delivered")]
////        Delivered,

////        /// <summary>
////        /// заказ не доехал (утерян в СДЭК) - десь надо привязаться когда сдек нам отдаст этот статус, отдать им
////        /// </summary>
////        [EnumMember(Value = "not_delivered")]
////        NotDelivered,

////        /// <summary>
////        /// возврат потому что не забрали в ПВЗ или истек срок хранения - десь надо привязаться когда сдек нам отдаст этот статус, отдать им
////        /// </summary>
////        [EnumMember(Value = "on_return")]
////        OnReturn,

////        /// <summary>
////        /// предлагаю добавить такой статус, который вы выбираете, если заказ сможете отправить не полностью - на этот сделать команду вручную
////        /// </summary>
////        [EnumMember(Value = "change")]
////        Change,

////        /// <summary>
////        /// открыт спор
////        /// </summary>
////        [EnumMember(Value = "in_dispute")]
////        InDispute,

////        /// <summary>
////        /// заказ исполнен - здесь надо привязаться когда сдек нам отдаст этот статус, отдать им
////        /// </summary>
////        [EnumMember(Value = "closed")]
////        Closed,
////    }
////}