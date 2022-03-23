using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catagory.Categories;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace eShopSolutionAdminApp.Services
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {

        public CategoryApiClient(
            IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, configuration, httpContextAccessor)
        {
        }
        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            return await GetListAsync<CategoryVm>($"/api/categories?languageId={languageId}");
        }
    }
}
