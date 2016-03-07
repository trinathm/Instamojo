using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo
{
    /// <summary>
    /// Enum Status
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Both email and SMS(whichever applicable) are not yet sent.
        /// </summary>
        pending,

        /// <summary>
        /// Either email or SMS(whichever applicable) is sent to the payer.
        /// </summary>
        sent,

        /// <summary>
        /// Both email and SMS(whichever applicable) failed to deliver to the user.
        /// </summary>
        failed,

        /// <summary>
        /// Payment was made by a payer.
        /// </summary>
        completed, 
    }

    /// <summary>
    /// Enum NotificationStatus
    /// </summary>
    public enum NotificationStatus
    {
        /// <summary>
        /// Request not yet sent from our end.
        /// </summary>
        pending,
        /// <summary>
        /// Request failed.
        /// </summary>
        failed,
        /// <summary>
        /// Request sent to the payer.
        /// </summary>
        sent
    }
}
