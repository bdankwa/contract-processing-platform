using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
/// <summary>
/// Amendment Table
/// This table stores the ammendments created againts a contract.
/// 
/// Each contract can have multiple ammendments associated with it.
/// Each Ammendment must be associated with at most one service that
/// is being removed or added to a contract.
/// 
/// Other information such as the time of creating and the user who
/// crated it should be stored.
/// </summary>

namespace ContractProcessingApp.Models
{
    public class Ammendment
    {
        /**Primary Key**/
        [Key]
        public int AmmendmentID { get; set; }

        /**Other Attributes**/


        /**Foriegn Keys**/
        [ForeignKey("User")]
        public string EmployeeID { get; set; }
        public virtual ApplicationUser User { get; set; } //Employee - Who created? One-to-One
        public virtual ServiceCatalog Services { get; set; }
    }
}