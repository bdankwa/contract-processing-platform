using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Ammendment> Ammendments { get; set; }
        public IDbSet<Bid> Bids { get; set; }
        public IDbSet<ServiceRequest> ServiceRequests { get; set; }
        public IDbSet<Contract> Contracts { get; set; }
        public IDbSet<Project> Projects { get; set; }
        public IDbSet<ServiceCatalog> Services { get; set; }
        public IDbSet<ProjectTask> Tasks { get; set; }

        public System.Data.Entity.DbSet<ContractProcessingApp.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}