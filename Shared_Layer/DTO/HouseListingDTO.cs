using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Layer.DTO
{
    public class HouseListingDTO
    {
        public int HouseListingID { get; set; }
        
        public string ApartmentNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string NameOfHead { get; set; }
        public Enum.OwnershipStatus OwnershipStatus { get; set; }
        public int NumberofRooms { get; set; }
    }
}
