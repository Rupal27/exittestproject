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

namespace BAL.BusinessLogic
{
   public class BusinessLogicPopulation : IBusinessPopulation
    {


        DatabaseContext context;
        IPopulationRepos house;
        CustomAutoMapper mapper;

        public BusinessLogicPopulation(IPopulationRepos _house)
        {
            mapper = new CustomAutoMapper();
            house = _house;

        }

        public bool Delete(int id)
        {
            house.Delete(id);
            return true;
        }

        public PopulationRegistrationDTO Get(int UserID)
        {
            PopulationRegistration user = new PopulationRegistration();
            return mapper.PopulationRegistrationToPopulationRegistrationDTO(house.GetObjectByID(UserID));
        }

        public List<PopulationRegistrationDTO> GetAll()
        {

            List<PopulationRegistration> list = new List<PopulationRegistration>();
            return mapper.PopulationRegistrationToPopulationRegistrationDTOList(house.GetAll());

        }


        public bool Insert(PopulationRegistrationDTO value)
        {
            PopulationRegistration val = new PopulationRegistration();
            
            val = mapper.PopulationRegistrationDTOToPopulationRegistration(value);
            val.CreatedOn = DateTime.Now;
            val.ModifiedOn = DateTime.Now;
            house.Insert(val);
            
            return true;
        }

        public bool Update(PopulationRegistrationDTO value)
        {
            PopulationRegistration val = new PopulationRegistration();
           
            val = mapper.PopulationRegistrationDTOToPopulationRegistration(value);
            val.ModifiedOn = DateTime.Now;
            house.Update(val);
            
            return true;
        }
    }
}
