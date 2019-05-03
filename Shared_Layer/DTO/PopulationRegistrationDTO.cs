using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Layer.DTO
{
    public class PopulationRegistrationDTO
    {
        public int PopulationRegistrationID { get; set; }

        public Enum.RelationToHead RelationToHead { get; set; }
        public Enum.Gender Gender { get; set; }
        public Enum.MaritalStatus MaritalStatus { get; set; }
        public Enum.OccupationStatus OccupationStatus { get; set; }
        public Enum.NatureOfOccupation NatureOfOccupation { get; set; }
        public int HouseListingID;
        public int MemberID;
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public int AgeAtMarriage { get; set; }
    }
}
