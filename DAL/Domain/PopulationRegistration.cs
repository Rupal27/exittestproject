using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Layer;

namespace DAL.Domain
{
    public class PopulationRegistration : DomainClass
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PopulationRegistrationID { get; set; }

        [Required]
        public Shared_Layer.Enum.RelationToHead RelationToHead { get; set; }
        [Required]
        public Shared_Layer.Enum.Gender Gender { get; set; }
        [Required]
        public Shared_Layer.Enum.MaritalStatus MaritalStatus { get; set; }
        [Required]
        public Shared_Layer.Enum.OccupationStatus OccupationStatus { get; set; }
        [Required]
        public Shared_Layer.Enum.NatureOfOccupation NatureOfOccupation { get; set; }

        [Required]
        public string FullName { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public int AgeAtMarriage { get; set; }
        public int MemberID { get; set; }
        public int HouseListingID { get; set; }
        [ForeignKey("MemberID")]
        public virtual Member Member { get; set; }
        [ForeignKey("HouseListingID")]
        public virtual HouseListing HouseListing { get; set; }
    }
}
