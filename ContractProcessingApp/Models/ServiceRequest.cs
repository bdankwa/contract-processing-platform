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
        [Display(Name = "Request ID:")]
        public int ServiceRequestID { get; set; }

        /**Other Attributes**/
        /*Request Details*/
        [Required]
        [Display(Name = "Service Category:")]
        public string RequestCategory { get; set; }

        [Required]
        [Display(Name = "Summary of Request:")]
        [DataType(DataType.MultilineText)]
        public string Summary { get; set; }

        /*Location of Property*/
        [Required]
        [Display(Name = "Country:")]
        public string RequestCountry { get; set; }

        [Required]
        [Display(Name = "Region:")]
        public string RequestRegion { get; set; }

        [Required]
        [Display(Name = "Closest City or Town:")]
        public string RequestCity { get; set; }

        [Display(Name = "Additional Location Information:")]
        public string AdditionalLocationInfo { get; set; }

        [Required]
        [Display(Name = "Contact E-Mail:")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "E-mail is invalid")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Contact Phone Number:")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string PhoneNumber { get; set; }

        /**Date of Project**/
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Approximate State Date:")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Desired Completion Date:")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CompleteDate { get; set; }


        /*Internal*/
        //[Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        public DateTime DataCreated {
            get
            {
                return dateCreated ?? DateTime.Now;
            }
            set
            {
                this.dateCreated = value;
            }

        }
        public ServiceRequestStatus Status { get; set; }

        /**Foreign Keys***/

        [ForeignKey("User")]
        //[Required]
        public string CustomerID { get; set; }
        public virtual ApplicationUser User { get; set; } //Customer

        /**Miscellanous**/
        private DateTime? dateCreated = null;
    }
}