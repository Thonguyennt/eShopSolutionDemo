using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}
