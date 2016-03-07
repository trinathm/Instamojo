using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo.Model
{
    /// <summary>
    /// Class PaymentRequestResponse.
    /// </summary>
    public class PaymentRequestResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="PaymentRequestResponse" /> is success.
        /// </summary>
        /// <value><c>true</c> if success; otherwise, <c>false</c>.</value>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the payment request.
        /// </summary>
        /// <value>The payment request.</value>
        [JsonProperty(PropertyName = "payment_request")]
        public PaymentRequest PaymentRequest { get; set; }
    }
}
