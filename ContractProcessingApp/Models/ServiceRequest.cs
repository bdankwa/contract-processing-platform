﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class ServiceRequest
    {
        /**Primary Key**/
        [Key]
        public int ServiceRequestID { get; set; }

        /**Other Attributes**/

        /**Foreign Keys***/

        [ForeignKey("User")]
        public string CustomerID { get; set; }
        public virtual ApplicationUser User { get; set; } //Customer
    }
}