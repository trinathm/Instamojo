using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo
{
    /// <summary>
    /// Class PaymentRequestsResponse.
    /// </summary>
    public class PaymentRequestsResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="PaymentRequestsResponse" /> is success.
        /// </summary>
        /// <value><c>true</c> if success; otherwise, <c>false</c>.</value>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the payment requests.
        /// </summary>
        /// <value>The payment requests.</value>
        [JsonProperty(PropertyName = "payment_requests")]
        public List<PaymentRequest> PaymentRequests { get; set; }
    }
}
