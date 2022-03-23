using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catagory.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}