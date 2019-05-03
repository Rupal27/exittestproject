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
    public class HouseListing : DomainClass
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HouseListingID { get; set; }
        public virtual ICollection<PopulationRegistration> PopulationRegistration { get; set; }
        [Required]
        public string ApartmentNumber { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string NameOfHead { get; set; }
        [Required]
        public Shared_Layer.Enum.OwnershipStatus OwnershipStatus { get; set; }
        [Required]
        public int NumberofRooms { get; set; }

    }
}
