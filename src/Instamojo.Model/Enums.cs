using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instamojo.Model
{
    /// <summary>
    /// Enum Status
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Both email and SMS(whichever applicable) are not yet sent.
        /// </summary>
        Pending,

        /// <summary>
        /// Either email or SMS(whichever applicable) is sent to the payer.
        /// </summary>
        Sent,

        /// <summary>
        /// Both email and SMS(whichever applicable) failed to deliver to the user.
        /// </summary>
        Failed,

        /// <summary>
        /// Payment was made by a payer.
        /// </summary>
        Completed, 
    }

    /// <summary>
    /// Enum NotificationStatus
    /// </summary>
    public enum NotificationStatus
    {
        /// <summary>
        /// Request not yet sent from our end.
        /// </summary>
        Pending,
        /// <summary>
        /// Request failed.
        /// </summary>
        Failed,
        /// <summary>
        /// Request sent to the payer.
        /// </summary>
        Sent,
        /// <summary>
        /// Field not applicable, i.e when send_email and/or send_sms is set to False
        /// </summary>
        Null
    }
}
