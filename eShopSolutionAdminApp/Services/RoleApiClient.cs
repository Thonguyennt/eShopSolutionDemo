using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Roles;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace eShopSolutionAdminApp.Services
{
    public class RoleApiClient : BaseApiClient, IRoleApiClient
    {

        public RoleApiClient(
            IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, configuration, httpContextAccessor)
        {
        }

        public async Task<ApiResult<List<RoleVm>>> GetAll()
        {
            return await GetAsync<ApiResult<List<RoleVm>>>("/api/roles");
        }
    }
}