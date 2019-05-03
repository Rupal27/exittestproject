using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Domain;
using Shared_Layer;

namespace DAL.Domain
{
    public class Member : DomainClass
    {
        [Required]
        public bool IsApprover { get; set; }

        [MaxLength(50)]
        [Required]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ProfileImage { get; set; }
        [Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberID { get; set; }
        public virtual ICollection<PopulationRegistration> PopulationRegistration { get; set; }

        [MaxLength(12)]
        [Required]
        [Index(IsUnique = true)]
        public string AadharNo { get; set; }
       

    
    }
}

