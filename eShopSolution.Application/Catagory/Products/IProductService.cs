using System.Collections.Generic;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catagory.ProductImages;
using eShopSolution.ViewModels.Catagory.Products;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.Application.Catagory.Products
{
    public interface IProductService
    {
        Task<ApiResult<int>> Create(ProductCreateRequest request);

        Task<ApiResult<int>> Update(ProductUpdateRequest request);

        Task<ApiResult<int>> Delete(int productId);

        Task<ApiResult<ProductVm>> GetById(int productId, string languageId);

        Task<ApiResult<bool>> UpdatePrice(int productId, decimal newPrice);

        Task<ApiResult<bool>> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<ApiResult<PagedResult<ProductVm>>> GetAllPaging(GetManageProductPagingRequest request);

        Task<ApiResult<int>> AddImages(int productId, ProductImageCreateRequest request);

        Task<ApiResult<int>> RemoveImages(int imageId);

        Task<ApiResult<int>> UpdateImage(int imageId, ProductImageUpdateRequest productImage);

        Task<ApiResult<ProductImageViewModel>> GetImageById(int imageId);

        Task<ApiResult<List<ProductImageViewModel>>> GetListImage(int productId);

        Task<ApiResult<PagedResult<ProductViewModel>>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);

        Task<ApiResult<List<ProductViewModel>>> GetAll(string languageId);
        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);
    }
}