using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo.Model
{
    /// <summary>
    /// Class PaymentRequest.
    /// </summary>
    public class PaymentRequest
    {
        /// <summary>
        /// Gets or sets the purpose.
        /// </summary>
        /// <value>Purpose of the payment request. (max-characters: 30)</value>
        public string Purpose { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>Amount requested (min-value: 9 ; max-value: 200000).</value>
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets the name of the buyer.
        /// </summary>
        /// <value>Name of the payer. (max-characters: 100).</value>
        [JsonProperty(PropertyName = "buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>Email of the payer. (max-characters: 75)</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>Phone number of the payer.</value>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [send email].
        /// </summary>
        /// <value>Set this to True if you want to send email to the payer if email is specified.
        /// If email is not specified then an error is raised.
        /// (default value: False)</value>
        [JsonProperty(PropertyName = "send_email")]
        public bool SendEmail { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [send SMS].
        /// </summary>
        /// <value>Set this to True if you want to send SMS to the payer if phone is specified. 
        /// If phone is not specified then an error is raised. 
        /// (default value: False)</value>
        [JsonProperty(PropertyName = "send_sms")]
        public bool SendSms { get; set; }

        /// <summary>
        /// Gets or sets the redirect URL.
        /// </summary>
        /// <value>set this to a thank-you page on your site. 
        /// Buyers will be redirected here after successful payment.</value>
        [JsonProperty(PropertyName = "redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets the webhook.
        /// </summary>
        /// <value>set this to a URL that can accept POST requests made by Instamojo server after successful payment.</value>
        public string Webhook { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow repeated payments].
        /// </summary>
        /// <value>To disallow multiple payments on a Payment Request pass False for this field. (default value: True).</value>
        [JsonProperty(PropertyName = "allow_repeated_payments")]
        public bool AllowRepeatedPayments { get; set; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; }
        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public Status Status { get; }

        /// <summary>
        /// Gets the SMS status.
        /// </summary>
        /// <value>The SMS status.</value>
        [JsonProperty(PropertyName = "sms_status")]
        public NotificationStatus SmsStatus { get; }

        /// <summary>
        /// Gets the email status.
        /// </summary>
        /// <value>The email status.</value>
        [JsonProperty(PropertyName = "email_status")]
        public NotificationStatus EmailStatus { get; }

        /// <summary>
        /// Gets the short URL.
        /// </summary>
        /// <value>The short URL.</value>
        [JsonProperty(PropertyName = "shorturl")]
        public string ShortUrl { get; }

        [JsonProperty(PropertyName = "longurl")]
        public string LongUrl { get; }


        [JsonProperty(PropertyName = "created_at")]
        public string CreatedAt { get; }

        [JsonProperty(PropertyName = "modified_at")]
        public string ModifiedAt { get; }

    }
}
