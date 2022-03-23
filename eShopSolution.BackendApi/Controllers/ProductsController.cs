using System.Threading.Tasks;
using eShopSolution.Application.Catagory.Products;
using eShopSolution.ViewModels.Catagory.ProductImages;
using eShopSolution.ViewModels.Catagory.Products;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _ProductService;

        public ProductsController(IProductService IProductService)
        {
            _ProductService = IProductService;
        }

        [HttpGet("GetAllProduct/{languageId}")]
        public async Task<IActionResult> GetAllProduct(string languageId)
        {
            var products = await _ProductService.GetAll(languageId);
            if (products == null)
                return BadRequest();
            return Ok(products);
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetManageProductPagingRequest request)
        {
            var product = await _ProductService.GetAllPaging(request);
            return Ok(product);
        }

        //http://localhost:port/product/1
        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var products = await _ProductService.GetById(productId, languageId);
            if (products == null)
                return BadRequest("Cannot find product");
            return Ok(products.ResultObj);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _ProductService.Create(request);
            if (!result.IsSuccessed)
                return BadRequest();

            var product = await _ProductService.GetById(result.ResultObj, request.LanguageId);

            return CreatedAtAction(nameof(GetById), new { id = result.ResultObj }, product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedResult = await _ProductService.Update(request);
            if (!affectedResult.IsSuccessed)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _ProductService.Delete(productId);
            if (!affectedResult.IsSuccessed)
                return BadRequest();
            return Ok();
        }

        [HttpPut("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int id, int price)
        {
            var result = await _ProductService.UpdatePrice(id, price);
            if (result.IsSuccessed)
                return Ok();
            return BadRequest();
        }

        //Images
        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _ProductService.GetImageById(imageId);
            if (image == null)
                return BadRequest("Cannot find image");
            return Ok(image);
        }

        [HttpPost("{productId}/images")]
        public async Task<IActionResult> Create(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _ProductService.AddImages(productId, request);
            if (!result.IsSuccessed)
                return BadRequest();

            var image = await _ProductService.GetImageById(result.ResultObj);

            return CreatedAtAction(nameof(GetImageById), new { id = result.ResultObj }, image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var resuld = await _ProductService.UpdateImage(imageId, request);
            if (!resuld.IsSuccessed)
                return BadRequest();

            var image = await _ProductService.GetImageById(imageId);

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> DeleteImage(int imageId)
        {
            var image = await _ProductService.RemoveImages(imageId);
            if (!image.IsSuccessed)
                return BadRequest("Cannot find image");
            return Ok(image);
        }

        [HttpPut("{id}/categories")]
        public async Task<IActionResult> CategoryAssign(int id, [FromBody] CategoryAssignRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _ProductService.CategoryAssign(id, request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
    }
}