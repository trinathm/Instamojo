using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo
{
    public class PaymentDetails : PaymentRequest
    {
        /// <summary>
        /// Class Payment.
        /// </summary>
        /// <value>The payment.</value>
        public Payment Payment { get; set; }
    }
}
