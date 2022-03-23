using System.Collections.Generic;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catagory.Products;
using eShopSolution.ViewModels.Common;

namespace eShopSolutionAdminApp.Services
{
    public interface IProductApiClient
    {
        Task<ApiResult<PagedResult<ProductVm>>> GetPagings(GetManageProductPagingRequest request);
        Task<ApiResult<bool>> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductVm> GetById(int id, string languageId);

    }
}
