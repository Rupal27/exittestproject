using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Layer.Interface
{
   public interface IDomain
    {
        

        [DataType(DataType.Date)]
        DateTime CreatedOn { get; set; }

        [DataType(DataType.Date)]
        DateTime ModifiedOn { get; set; }
    }
}
