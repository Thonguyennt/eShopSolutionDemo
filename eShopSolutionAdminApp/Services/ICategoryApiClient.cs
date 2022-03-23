using System.Collections.Generic;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catagory.Categories;
using eShopSolution.ViewModels.Common;

namespace eShopSolutionAdminApp.Services
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);
    }
}
