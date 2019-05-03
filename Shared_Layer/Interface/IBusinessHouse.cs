using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Layer.DTO;

namespace Shared_Layer.Interface
{
   public interface IBusinessHouse
    {
        HouseListingDTO Get(int UserID);
        List<HouseListingDTO> GetAll();
        bool Insert(HouseListingDTO value);
        bool Update(HouseListingDTO value);
        bool Delete(int id);
        List<int> StatePopulation();

    }
}
