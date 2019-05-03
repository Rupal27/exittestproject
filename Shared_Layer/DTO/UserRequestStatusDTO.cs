using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Layer.DTO
{
   public class UserRequestStatusDTO
    {
        public int UserRequestStatusID { get; set; }
        public int MemberID { get; set; }
        public Enum.RequestStatus RequestStatus { get; set; }
    }
}
