using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Layer.DTO;

namespace Shared_Layer.Interface
{
   public interface IBusinessPopulation
    {
        PopulationRegistrationDTO Get(int UserID);
        List<PopulationRegistrationDTO> GetAll();
        bool Insert(PopulationRegistrationDTO value);
        bool Update(PopulationRegistrationDTO value);
        bool Delete(int id);

    }
}
