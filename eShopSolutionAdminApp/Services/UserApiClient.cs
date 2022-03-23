using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace eShopSolutionAdminApp.Services
{
    public class UserApiClient : BaseApiClient, IUserApiClient
    {
        public UserApiClient(
            IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, configuration, httpContextAccessor)
        { }

        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            return await AddAsync<ApiResult<string>>("/api/users/authenticate", request);
        }

        public async Task<ApiResult<bool>> Delete(Guid id)
        {
            return await DeleteAsync<ApiResult<bool>>($"/api/users/{id}");
        }

        public async Task<ApiResult<UserVm>> GetById(Guid id)
        {
            return await GetAsync<ApiResult<UserVm>>($"/api/users/{id}");
        }


        public async Task<ApiResult<PagedResult<UserVm>>> GetUsersPagings(GetUserPagingRequest request)
        {
            return await GetAsync<ApiResult<PagedResult<UserVm>>>($"/api/users/paging?pageIndex=" +
                $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}");
        }

        public async Task<ApiResult<bool>> RegisterUser(RegisterRequest request)
        {
            return await AddAsync<ApiResult<bool>>("/api/users/register", request);
        }

        public async Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request)
        {
            return await UpdateAsync<ApiResult<bool>>($"/api/users/{id}/roles", request);
        }

        public async Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request)
        {
            return await UpdateAsync<ApiResult<bool>>($"/api/users/{id}", request);
        }
    }
}