using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Layer.Interface;

namespace Shared_Layer
{
     public class DomainClass : IDomain
        {
           

            [Required]
            [DataType(DataType.Date)]
            public DateTime CreatedOn { get; set; }

            [Required]
            [DataType((DataType.Date))]
            public DateTime ModifiedOn { get; set; }
        }
   
}
