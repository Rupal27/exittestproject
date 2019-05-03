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
    public class BusinessLogicMember : IBusinessMember
    {
        DatabaseContext context;
        IMemberRepos house;
        IUserRepos userrep;
        CustomAutoMapper mapper;

        public BusinessLogicMember(IMemberRepos _house,IUserRepos _userrep)
        {
            mapper = new CustomAutoMapper();    
            house = _house;
            userrep = _userrep;

        }

        public bool Delete(int id)
        {
            house.Delete(id);
            return true;
        }

        public MemberDTO Get(int UserID)
        {
            Member user = new Member();
            return mapper.MemberToMemberDTO(house.GetObjectByID(UserID));
        }

        public List<MemberDTO> GetAll()
        {

            List<Member> list = new List<Member>();
            return mapper.MemberListToMemberDTOList(house.GetAll());

        }


        public bool Insert(MemberDTO value)
        {
            Member val = new Member();
        UserRequestStatus user=new UserRequestStatus();
            val = mapper.MemberDTOToMember(value);
            val.CreatedOn = DateTime.Now;
            val.ModifiedOn = DateTime.Now;
            house.Insert(val);
            Member memberr= house.Find(member => member.Email == val.Email).ToList().First();
            if (memberr.Email == "approver@gmail.com")
            {
                user.RequestStatus = Shared_Layer.Enum.RequestStatus.Accepted;
            }
            else
            {
                user.RequestStatus = Shared_Layer.Enum.RequestStatus.Pending;

            }
            user.MemberID= memberr.MemberID;
            user.CreatedOn = DateTime.Now;
            user.ModifiedOn = DateTime.Now;
            userrep.Insert(user);
            return true;
        }

        public bool Update(MemberDTO value)
        {
            Member val = new Member();
            val.ModifiedOn = DateTime.Now;
            val = mapper.MemberDTOToMember(value);
            house.Update(val);
            
            return true;
        }

        public int Check(MemberDTO value)
        {
            
            Member val = new Member();
            val = mapper.MemberDTOToMember(value);
            IEnumerable<Member> memberList=(house.Find((h) => (value.Email == h.Email) && (value.Password == h.Password)));
            if (memberList.Count()==0)
            {
                return -1;
            }
            else
            {
                val.ModifiedOn = DateTime.Now;
                var list = memberList.AsQueryable(); 
                return list.First().MemberID;

            }
        }
    }
}
