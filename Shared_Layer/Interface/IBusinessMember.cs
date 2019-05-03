using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Layer.DTO;

namespace Shared_Layer.Interface
{
   public interface IBusinessMember
    {
        MemberDTO Get(int UserID);
        List<MemberDTO> GetAll();
        int Check(MemberDTO value);
        bool Insert(MemberDTO value);
        bool Update(MemberDTO value);
        bool Delete(int id);

    }
}
