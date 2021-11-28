using AutoMapper;
using eKuharica.Model.DTO;
using eKuharica.Model.Entities;
using eKuharica.Model.Requests;
using eKuharica.Services.BaseCRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica.Services.Roles
{
    public class RoleService : BaseCRUDService<RoleDto, Role, object, RoleUpsertRequest, RoleUpsertRequest>, IRoleService
    {
        public RoleService(Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
