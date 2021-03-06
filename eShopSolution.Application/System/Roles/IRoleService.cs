using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Roles;

namespace eShopSolution.Application.System.Roles
{
    public interface IRoleService
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}
