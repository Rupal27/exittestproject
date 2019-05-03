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
    public class UserRequestStatus : DomainClass
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserRequestStatusID { get; set; }
        public int MemberID { get; set; } 
        [Required]
        public Shared_Layer.Enum.RequestStatus RequestStatus { get; set; }
        [ForeignKey("MemberID")]
        public virtual Member Member { get; set; }
    }
}
