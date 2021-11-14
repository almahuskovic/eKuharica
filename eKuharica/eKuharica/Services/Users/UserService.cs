using System;
using AutoMapper;
using eKuharica.Filters;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseRead;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace eKuharica.Services.Users
{
    public class UserService : BaseReadService<UserDto, User, UserSearchRequest>, IUserService
    {
        public UserService(Context context, IMapper mapper):base(context,mapper)
        {
        }

        public override IEnumerable<UserDto> Get(UserSearchRequest request)
        {
            var query = Context.User.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.FirstName))
                query = query.Where(x => x.FirstName.Contains(request.FirstName));

            var list = query.ToList();
            return _mapper.Map<List<UserDto>>(list);
        }
        public User Insert(UserInsertRequest request)
        {
            throw new NotImplementedException();
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public async Task<UserDto> Login(string username, string password)
        {
            var entity = await Context.User.Include("UserRoles.Role").FirstOrDefaultAsync(x => x.Username == username);

            if (entity == null)
            {
                throw new UserException("Pogrešan username ili password");
            }

            var hash = GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
            {
                throw new UserException("Pogrešan username ili password");
            }

            return _mapper.Map<UserDto>(entity);
        }
    }
}
