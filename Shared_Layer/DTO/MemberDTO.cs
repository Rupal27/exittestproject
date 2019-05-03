using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Layer.DTO
{
    public class MemberDTO
    {
        public bool IsApprover { get; set; }

        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ProfileImage { get; set; }
        public int MemberID { get; set; }
        

        [MaxLength(12)]
        [Index(IsUnique = true)]
        public string AadharNo { get; set; }

    }
}
