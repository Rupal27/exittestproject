using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Domain;
using Shared_Layer.DTO;

namespace BAL
{
    public class CustomAutoMapper
    {
        IMapper Mapper;

        public CustomAutoMapper()
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<HouseListing, HouseListingDTO>().ReverseMap();
                cfg.CreateMap<Member, MemberDTO>().ReverseMap();
                cfg.CreateMap<PopulationRegistration, PopulationRegistrationDTO>().ReverseMap();
                cfg.CreateMap<UserRequestStatus, UserRequestStatusDTO>().ReverseMap();

            });

            Mapper = config.CreateMapper();
        }

            public List<HouseListingDTO> HouseListToHouseDTOList(List<HouseListing> houselist)
        {
            return Mapper.Map<List<HouseListingDTO>>(houselist);
        }

        public List<HouseListing> HouseDTOListToHouseList(List<HouseListingDTO> houselist)
        {
            return Mapper.Map<List<HouseListing>>(houselist);
        }

        public HouseListingDTO HouseToHouseDTO(HouseListing houselist)
        {
            return Mapper.Map<HouseListingDTO>(houselist);
        }
        public HouseListing HouseDTOToHouse (HouseListingDTO houselist)
        {
            return Mapper.Map<HouseListing>(houselist);
        }



        public List<MemberDTO> MemberListToMemberDTOList(List<Member> houselist)
        {
            return Mapper.Map<List<MemberDTO>>(houselist);
        }

        public List<Member> MemberDTOListToMemberList(List<MemberDTO> houselist)
        {
            return Mapper.Map<List<Member>>(houselist);
        }

        public MemberDTO MemberToMemberDTO(Member houselist)
        {
            return Mapper.Map<MemberDTO>(houselist);
        }
        public Member MemberDTOToMember(MemberDTO houselist)
        {
            return Mapper.Map<Member>(houselist);
        }



        public List<PopulationRegistrationDTO> PopulationRegistrationToPopulationRegistrationDTOList(List<PopulationRegistration> houselist)
        {
            return Mapper.Map<List<PopulationRegistrationDTO>>(houselist);
        }

        public List<PopulationRegistration> PopulationRegistrationDTOListToPopulationRegistrationList(List<PopulationRegistrationDTO> houselist)
        {
            return Mapper.Map<List<PopulationRegistration>>(houselist);
        }

        public PopulationRegistrationDTO PopulationRegistrationToPopulationRegistrationDTO(PopulationRegistration houselist)
        {
            return Mapper.Map<PopulationRegistrationDTO>(houselist);
        }
        public PopulationRegistration PopulationRegistrationDTOToPopulationRegistration(PopulationRegistrationDTO houselist)
        {
            return Mapper.Map<PopulationRegistration>(houselist);
        }


        public List<UserRequestStatusDTO> UserRequestStatusToUserRequestStatusDTOList(List<UserRequestStatus> houselist)
        {
            return Mapper.Map<List<UserRequestStatusDTO>>(houselist);
        }

        public List<UserRequestStatus> UserRequestStatusDTOListToUserRequestStatusList(List<UserRequestStatusDTO> houselist)
        {
            return Mapper.Map<List<UserRequestStatus>>(houselist);
        }

        public UserRequestStatusDTO UserRequestStatusToUserRequestStatusDTO(UserRequestStatus houselist)
        {
            return Mapper.Map<UserRequestStatusDTO>(houselist);
        }
        public UserRequestStatus UserRequestStatusDTOToUserRequestStatus(UserRequestStatusDTO houselist)
        {
            return Mapper.Map<UserRequestStatus>(houselist);
        }
    }
}
