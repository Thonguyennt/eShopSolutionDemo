using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using eShopSolution.ViewModels.Catagory.Products;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace eShopSolutionAdminApp.Services
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        public ProductApiClient(
            IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, configuration, httpContextAccessor)
        {
        }

        public async Task<ApiResult<PagedResult<ProductVm>>> GetPagings(GetManageProductPagingRequest request)
        {
            return await GetAsync<ApiResult<PagedResult<ProductVm>>>(
                $"/api/products/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.Keyword}&languageId={request.LanguageId}&CategoryId={request.CategoryId}");
        }



        public async Task<ApiResult<bool>> CreateProduct(ProductCreateRequest request)
        {

            var client = base.GetHeader();

            var languageId = base.LanguageId();
            var requestContent = new MultipartFormDataContent();

            if (request.ThumbnailImage != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "thumbnailImage", request.ThumbnailImage.FileName);
            }

            requestContent.Add(new StringContent(request.Price.ToString()), "price");
            requestContent.Add(new StringContent(request.OriginalPrice.ToString()), "originalPrice");
            requestContent.Add(new StringContent(request.Stock.ToString()), "stock");
            requestContent.Add(new StringContent(request.Name.ToString()), "name");
            requestContent.Add(new StringContent(request.Description.ToString()), "description");

            requestContent.Add(new StringContent(request.Details.ToString()), "details");
            requestContent.Add(new StringContent(request.SeoDescription.ToString()), "seoDescription");
            requestContent.Add(new StringContent(request.SeoTitle.ToString()), "seoTitle");
            requestContent.Add(new StringContent(request.SeoAlias.ToString()), "seoAlias");
            requestContent.Add(new StringContent(languageId), "languageId");

            var response = await client.PostAsync($"/api/products/", requestContent);

            return new ApiSuccessResult<bool>(response.IsSuccessStatusCode);
        }

        public async Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request)
        {
            return await UpdateAsync<ApiResult<bool>>($"/api/products/{id}/categories", request);
        }

        public async Task<ProductVm> GetById(int id, string languageId)
        {
            return await GetAsync<ProductVm>($"/api/products/{id}/{languageId}");
        }
    }
}
