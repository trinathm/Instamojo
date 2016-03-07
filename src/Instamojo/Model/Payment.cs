using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo
{
    public class Payment
    {
        [JsonProperty(PropertyName = "payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "link_slug")]
        public object LinkSlug { get; set; }

        [JsonProperty(PropertyName = "link_title")]
        public object LinkTitle { get; set; }

        [JsonProperty(PropertyName = "buyer_name")]
        public string BuyerName { get; set; }

        [JsonProperty(PropertyName = "buyer_phone")]
        public string BuyerPhone { get; set; }

        [JsonProperty(PropertyName = "buyer_email")]
        public string BuyerEmail { get; set; }

        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        [JsonProperty(PropertyName = "unit_price")]
        public string UnitPrice { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "fees")]
        public string Fees { get; set; }

        [JsonProperty(PropertyName = "shipping_address")]
        public object ShippingAddress { get; set; }

        [JsonProperty(PropertyName = "shipping_city")]
        public object ShippingCity { get; set; }

        [JsonProperty(PropertyName = "shipping_state")]
        public object ShippingState { get; set; }

        [JsonProperty(PropertyName = "shipping_zip")]
        public object ShippingZip { get; set; }

        [JsonProperty(PropertyName = "shipping_country")]
        public object ShippingCountry { get; set; }

        [JsonProperty(PropertyName = "discount_code")]
        public object DiscountCode { get; set; }

        [JsonProperty(PropertyName = "discount_amount_off")]
        public object DiscountAmountOff { get; set; }

        [JsonProperty(PropertyName = "variants")]
        public List<object> variants { get; set; }

        [JsonProperty(PropertyName = "affiliate_id")]
        public object AffiliateId { get; set; }

        [JsonProperty(PropertyName = "affiliate_commission")]
        public string AffiliateCommission { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; set; }
    }
}
