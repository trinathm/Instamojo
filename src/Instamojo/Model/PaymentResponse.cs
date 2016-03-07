using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo
{
    /// <summary>
    /// Class PaymentResponse.
    /// </summary>
    public class PaymentResponse
    {
        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets the buyer.
        /// </summary>
        /// <value>The buyer.</value>
        public string Buyer { get; set; }

        /// <summary>
        /// Gets the name of the buyer.
        /// </summary>
        /// <value>The name of the buyer.</value>
        [JsonProperty(PropertyName = "buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// Gets the buyer phone.
        /// </summary>
        /// <value>The buyer phone.</value>
        [JsonProperty(PropertyName = "buyer_phone")]
        public string BuyerPhone { get; set; }

        /// <summary>
        /// Gets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string Currency { get; set; }

        /// <summary>
        /// Gets the fees.
        /// </summary>
        /// <value>The fees.</value>
        public string Fees { get; set; }

        /// <summary>
        /// Gets the longurl.
        /// </summary>
        /// <value>The longurl.</value>
        public string Longurl { get; set; }

        /// <summary>
        /// Gets the mac.
        /// </summary>
        /// <value>The mac.</value>
        public string Mac { get; set; }

        /// <summary>
        /// Gets the payment identifier.
        /// </summary>
        /// <value>The payment identifier.</value>
        [JsonProperty(PropertyName = "payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets the payment request identifier.
        /// </summary>
        /// <value>The payment request identifier.</value>
        [JsonProperty(PropertyName = "payment_request_id")]
        public string PaymentRequestId { get; set; }

        /// <summary>
        /// Gets the purpose.
        /// </summary>
        /// <value>The purpose.</value>
        public string Purpose { get; set; }

        /// <summary>
        /// Gets the shorturl.
        /// </summary>
        /// <value>The shorturl.</value>
        public string Shorturl { get; set; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public Status Status { get; set; }
    }
}
