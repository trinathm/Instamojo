using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo.Model
{
    public class PaymentRequestsResponse
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "payment_requests")]
        public List<PaymentRequest> PaymentRequests { get; set; }
    }
}
