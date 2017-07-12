﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class ServiceCategory
    {
        /**Primary Key**/
        [Key]
        public string CategoryID { get; set; }

        /**Other Attributes Key**/
        public string Name { get; set; }

        public string Description { get; set; }

        /**Foreign Key**/
        public virtual ICollection<ServiceCatalog> Services { get; set; }
    }
}