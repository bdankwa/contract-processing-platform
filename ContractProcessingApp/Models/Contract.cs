﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class Contract
    {
        /**Primary Key**/
        [Key, Column(Order = 0)]
        public int ContractID { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("ServiceRequest")]
        public int ServiceRequestID { get; set; }

        /**Other Attributes**/



        /**Foriegn Keys**/
        [ForeignKey("User")]
        public string EmployeeID { get; set; }

        public virtual ApplicationUser User { get; set; } //Employee - Who created? One-to-One
        public virtual ServiceRequest ServiceRequest { get; set; } //One-to-One
        public virtual ICollection<Project> Projects { get; set; } //One-to-Many
        public virtual ICollection<Ammendment> Ammendments { get; set; } //One-to-Many

    }
}