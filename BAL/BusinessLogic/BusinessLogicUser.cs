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
    public class BusinessLogicUser : IBusinessUser
    {
        readonly DatabaseContext context;
        IUserRepos house;
        readonly CustomAutoMapper mapper;

        public BusinessLogicUser(IUserRepos _house)
        {
            mapper = new CustomAutoMapper();
            house = _house;

        }

        public bool Delete(int id)
        {
            house.Delete(id);
            return true;
        }

        public UserRequestStatusDTO Get(int UserID)
        {
            UserRequestStatus user = new UserRequestStatus();
            return mapper.UserRequestStatusToUserRequestStatusDTO(house.GetObjectByID(UserID));
        }

        public List<UserRequestStatusDTO> GetAll()
        {

            List<UserRequestStatus> list = new List<UserRequestStatus>();
            return mapper.UserRequestStatusToUserRequestStatusDTOList(house.GetAll());

        }


        public bool Insert(UserRequestStatusDTO value)
        {
            UserRequestStatus val = new UserRequestStatus();
            val = mapper.UserRequestStatusDTOToUserRequestStatus(value);
            house.Insert(val);
            val.CreatedOn = DateTime.Now;
            val.ModifiedOn = DateTime.Now;
            return true;
        }

        public bool Update(UserRequestStatusDTO value)
        {
            UserRequestStatus val = new UserRequestStatus();
            val = mapper.UserRequestStatusDTOToUserRequestStatus(value);
            val.ModifiedOn = DateTime.Now;
            val.CreatedOn = DateTime.Now;
            house.Update(val);
            return true;
        } 

    }  
}
