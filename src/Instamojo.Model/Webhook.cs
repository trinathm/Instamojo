using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo.Model
{
    public class Webhook
    {
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "buyer")]
        public string Buyer { get; set; }

        [JsonProperty(PropertyName = "buyer_name")]
        public string BuyerName { get; set; }

        [JsonProperty(PropertyName = "buyer_phone")]
        public string BuyerPhone { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "fees")]
        public string Fees { get; set; }

        [JsonProperty(PropertyName = "longurl")]
        public string LongUrl { get; set; }

        [JsonProperty(PropertyName = "mac")]
        public string Mac { get; set; }

        [JsonProperty(PropertyName = "payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "payment_request_id")]
        public string PaymentRequestId { get; set; }

        [JsonProperty(PropertyName = "purpose")]
        public string Purpose { get; set; }

        [JsonProperty(PropertyName = "shorturl")]
        public string ShortUrl { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
