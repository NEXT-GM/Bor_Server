using Bor.BusinessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bor.BusinessLogic.Core.Interfaces
{
    public interface IUserService 
    {
        Task <UserInformationBlo> Register(UserIdentityBlo userIdentityBlo);
        Task<UserInformationBlo> Auth(int numberprefix, int number, string password);
        Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo, UserIdentityBlo userIdentityBlo);
        Task<UserInformationBlo> Get(int userId);
        Task<bool> DoesExist(int numberPrefix, int number);
    }
}
