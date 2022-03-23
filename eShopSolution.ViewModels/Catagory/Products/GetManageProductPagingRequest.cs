using System.Collections.Generic;
using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catagory.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public int? CategoryId { get; set; }
        public string LanguageId { get; set; }
    }
}