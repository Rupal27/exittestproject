using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Layer.DTO;

namespace Shared_Layer.Interface
{
    public interface IBusinessUser
    {
        UserRequestStatusDTO Get(int UserID);
        List<UserRequestStatusDTO> GetAll();
        bool Insert(UserRequestStatusDTO value);
        bool Update(UserRequestStatusDTO value);
        bool Delete(int id);

    }
}
