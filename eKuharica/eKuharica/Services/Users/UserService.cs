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
    public class UserService :  IUserService
    {
        public Context Context { get; set; }
        protected readonly IMapper _mapper;
        public UserService(Context context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public List<UserDto> Get(UserSearchRequest request)
        {
            var query = Context.User.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.FirstName))
                query = query.Where(x => x.FirstName.Contains(request.FirstName));

            if (!string.IsNullOrWhiteSpace(request.UserName))
                query = query.Where(x => x.Username == request.UserName);

            var list = query.ToList();
            return _mapper.Map<List<UserDto>>(list);
        }

        public UserDto Insert(UserInsertRequest request)
        {
            var entity = _mapper.Map<User>(request);
            Context.Add(entity);
            if (request.Password != request.PasswordConfirm)
            {
                //throw new NotImplementedException();
                throw new UserException("Lozinka nije ispravna");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            Context.SaveChanges();

            foreach (var role in request.Roles)
            {
                UserRole userRole = new UserRole();
                userRole.UserId = entity.Id;
                userRole.RoleId = role;
                userRole.ModifiedAt = DateTime.Now;

                Context.UserRole.Add(userRole);
            }

            Context.SaveChanges();

            return _mapper.Map<UserDto>(entity);
        }

        public UserDto Update(int id, UserUpdateRequest request)
        {
            var entity = Context.User.Find(id);
            _mapper.Map(request, entity);

            Context.SaveChanges();
            return _mapper.Map<UserDto>(entity);
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

        public UserDto GetById(int id)
        {
            var entity = Context.User.Find(id);

            return _mapper.Map<UserDto>(entity);
        }
    }
}
