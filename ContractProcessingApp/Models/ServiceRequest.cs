using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public enum ServiceRequestStatus
    {
        Draft,
        Submitted,
        Approved,
        Rejected,
        Completed,
        Cancelled
    }

    public class ServiceRequest
    {
        /**Primary Key**/
        [Key]
        public int ServiceRequestID { get; set; }

        /**Other Attributes**/
        public string Name { get; set; }
        public string RequestCategory { get; set; }
        public string Summary { get; set; }
        public string RequeustCountry { get; set; }
        public string RequestCity { get; set; }
        public string RequestLocality { get; set; }
        public string AdditionalLocationInfo { get; set; }
        public DateTime DateTimeProperty { get; set; }
        public DateTime? DateTimeNullableProperty { get; set; }
        public TimeSpan TimeSpanProperty { get; set; }
        public ServiceRequestStatus Status { get; set; }

        /**Foreign Keys***/

        [ForeignKey("User")]
        public string CustomerID { get; set; }
        public virtual ApplicationUser User { get; set; } //Customer
    }
}