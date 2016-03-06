using Instamojo.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo
{
    /// <summary>
    /// Class Instamojo.
    /// </summary>
    public class Instamojo
    {
        /// <summary>
        /// The headers
        /// </summary>
        private WebHeaderCollection Headers { get; set; }

        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>The base URL.</value>
        private string BaseUrl { get; set; }

        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        /// <value>The API key.</value>
        private string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the authentication token.
        /// </summary>
        /// <value>The authentication token.</value>
        private string AuthToken { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Instamojo" /> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="authToken">The authentication token.</param>
        /// <param name="baseUrl">The base URL.</param>
        public Instamojo(string apiKey, string authToken, string baseUrl)
        {
            ApiKey = apiKey;
            AuthToken = authToken;
            BaseUrl = baseUrl;
        }

        /// <summary>
        /// Creates the payment request.
        /// </summary>
        /// <param name="paymentRequest">The payment request.</param>
        /// <returns>Return the payment request response.</returns>
        public async Task<PaymentRequestResponse> CreatePaymentRequest(PaymentRequest paymentRequest)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-KEY", ApiKey);
                client.DefaultRequestHeaders.Add("X-AUTH-TOKEN", AuthToken);
                var response = await client.PostAsJsonAsync<PaymentRequest>(this.BaseUrl + RequestEndpoints.PaymentRequest, paymentRequest);
                var responseString = await response.Content.ReadAsStringAsync();
                return await Task.Run(() => JsonConvert.DeserializeObject<PaymentRequestResponse>(responseString));
            }
        }

        /// <summary>
        /// Gets the payment request status.
        /// </summary>
        /// <param name="paymentId">The payment identifier.</param>
        /// <returns>Return payment request response for given payment id.</returns>
        public async Task<PaymentRequestResponse> GetPaymentRequestStatus(string paymentId)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-KEY", ApiKey);
                client.DefaultRequestHeaders.Add("X-AUTH-TOKEN", AuthToken);
                var response = await client.GetAsync(this.BaseUrl + RequestEndpoints.PaymentRequest + paymentId);
                var responseString = await response.Content.ReadAsStringAsync();
                return await Task.Run(() => JsonConvert.DeserializeObject<PaymentRequestResponse>(responseString));
            }
        }

        /// <summary>
        /// Gets the payment requests.
        /// </summary>
        /// <returns>Return all the payment request responses.</returns>
        public async Task<PaymentRequestsResponse> GetPaymentRequests()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-KEY", ApiKey);
                client.DefaultRequestHeaders.Add("X-AUTH-TOKEN", AuthToken);
                var response = await client.GetAsync(this.BaseUrl + RequestEndpoints.PaymentRequest);
                var responseString = await response.Content.ReadAsStringAsync();
                return await Task.Run(() => JsonConvert.DeserializeObject<PaymentRequestsResponse>(responseString));
            }
        }

        /// <summary>
        /// Gets the payment requests.
        /// </summary>
        /// <param name="minimumCreatedDate">The minimum created date.</param>
        /// <param name="maximumCreatedDate">The maximum created date.</param>
        /// <param name="minimumModifiedDate">The minimum modified date.</param>
        /// <param name="maximumModifiedDate">The maximum modified date.</param>
        /// <returns>Return payment requests response based on the given params.</returns>
        public PaymentRequestsResponse GetPaymentRequests(DateTime? minimumCreatedDate = null, DateTime? maximumCreatedDate = null, DateTime? minimumModifiedDate = null, DateTime? maximumModifiedDate = null)
        {
            var queryString = "?"
            

            if(minimumCreatedDate != null)
            {
                url += FilterKeys.MinCreatedAt + 
            }

            var uri = new Uri(this.BaseUrl + this.PaymentRequestEndpoint + "?");
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            if(minimumCreatedDate != null)
            {

            }
        }
    }
}
