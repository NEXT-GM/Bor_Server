using AutoMapper;
using Bor.BusinessLogic.Core.Interfaces;
using Bor.BusinessLogic.Core.Models;
using Bor.DataAccess.Core.Interfaces;
using Bor.DataAccess.Core.Models;
using Microsoft.EntityFrameworkCore;
using Share.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bor.BusinessLogic.Services
{
    class UserServices : IUserService
    {

        private readonly IMapper _mapper;
        private readonly IContext _context;


        public UserServices(IMapper mapper, IContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public Task<UserInformationBlo> Auth(int numberprefix, int number, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int numberPrefix, int number)
        {
            throw new NotImplementedException();
        }

        public async Task<UserInformationBlo> Get(int userId)
        {
           UserRto user = await _context.Users.FirstOrDefaultAsync(h => h.Id == userId);
            if (user == null) 
                throw new NotFoundException($"Пользователь с id {userId} не найден.");

            UserInformationBlo userInformationBlo = await ConvertToUserInformation(user);
            return userInformationBlo;
        }

        public Task<UserInformationBlo> Register(UserIdentityBlo userIdentityBlo)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(UserUpdateBlo userUpdateBlo, UserIdentityBlo userIdentityBlo)
        {
            throw new NotImplementedException();
        }
        private async Task<UserInformationBlo> ConvertToUserInformation(UserRto userRto)
        {
            if (userRto == null) throw new ArgumentNullException(nameof(userRto));

            var userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);

            return userInformationBlo;
        }
    }
}
