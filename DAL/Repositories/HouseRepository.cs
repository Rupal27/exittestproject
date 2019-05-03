using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Domain;
using DAL.InterfaceRepository;
using Shared_Layer.Interface;

namespace DAL.Repositories
{
    public class HouseRepository : BaseRepository<HouseListing>, IHouseRepos
    {


        public HouseRepository(IUnitofWork unit) : base(unit)
        {
            _unitofwork = unit;
        }


    }
}
