using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Domain;
using DAL.InterfaceRepository;
using Shared_Layer.DTO;
using Shared_Layer.Interface;
using DAL.Repositories;
using DAL.UnitOfWork;
using DAL;

namespace BAL.BusinessLogic
{
   public class BusinessLogicHouse : IBusinessHouse
    {
        DatabaseContext context;
        IHouseRepos house;
        CustomAutoMapper mapper;
        PopulationRepository PopulationRepository;

        public BusinessLogicHouse(IHouseRepos _house)
        {
            mapper = new CustomAutoMapper();
            house = _house;
            PopulationRepository = new PopulationRepository(new UoWHouse(new DatabaseContext()) ); 

        }

        public bool Delete(int id)
        {
            house.Delete(id);
            return true;
        }

        public HouseListingDTO Get(int UserID)
        {
            HouseListing user = new HouseListing();
            return mapper.HouseToHouseDTO(house.GetObjectByID(UserID));
        }

        public List<HouseListingDTO> GetAll()
        {
            
            List<HouseListing> list = new List<HouseListing>();
            return mapper.HouseListToHouseDTOList(house.GetAll());
             
        }

      
        public bool Insert(HouseListingDTO value)
        {
            HouseListing val = new HouseListing();
           
            val = mapper.HouseDTOToHouse(value);
            val.CreatedOn = DateTime.Now;
            val.ModifiedOn = DateTime.Now;
            house.Insert(val);
          
            return true;
        }

        public bool Update(HouseListingDTO value)
        {
            HouseListing val = new HouseListing();
            val.ModifiedOn = DateTime.Now;
            val = mapper.HouseDTOToHouse(value);
            house.Update(val);
            
            return true;
        }

        public List<int> StatePopulation()
        {
            List<string> StateArray = new List<string>() { "Andaman & Nicobar", "Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chandigarh", "Chhattisgarh", "Dadra & Nagar Haveli", "Daman & Diu", "Delhi", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu & Kashmir", "Jharkhand", "Karnataka", "Kerala", "Lakshadweep", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Orissa", "Pondicherry", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Tripura", "Uttar Pradesh", "Uttaranchal", "West Bengal" };
            List<int> statePopulation = new List<int>();
            foreach (string state in StateArray)
            {

                List<HouseListing> houses = this.house.Find(house => house.State == state).ToList();
                if (houses.Count == 0)
                {
                    statePopulation.Add(0);

                }
                else
                {
                    int populationCount = 0;
                    foreach (HouseListing house in houses)
                    {
                        int counted = this.PopulationRepository.Find(houseMember => houseMember.HouseListingID == house.HouseListingID).ToList().Count;
                        populationCount = populationCount + counted;
                    }
                    statePopulation.Add(populationCount);
                }
            }
            return statePopulation;



        }

    }
}
