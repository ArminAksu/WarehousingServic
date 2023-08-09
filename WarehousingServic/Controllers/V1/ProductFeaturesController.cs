using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehousingServic.Data;
using WarehousingServic.Entity;
using WarehousingServic.Repository;
using WarehousingServic.Request;

namespace WarehousingServic.Controllers.V1
{

    [Route("api/[controller]")]
    [ApiVersion("1", Deprecated = true)]
    [ApiController]
    public class ProductFeaturesController : ControllerBase
    {
        DataContext _context;
        private readonly IProductFeatureRepository _ProductFeatureRepository;
        private readonly IRemittanceFeatureRepository _RemittanceFeatureRepository;
        public ProductFeaturesController(DataContext dataContext, IRemittanceFeatureRepository RemittanceFeatureRepository, IProductFeatureRepository ProductFeatureRepository)
        {
            _context = dataContext;
            _ProductFeatureRepository = _ProductFeatureRepository;
            _RemittanceFeatureRepository = _RemittanceFeatureRepository;

        }
        [HttpGet("getId")]
        public ActionResult<Entity.ProductFeature> GetInProductFeature(int ProductGroupId)
        {
            var ProductFeature = _ProductFeatureRepository.GetProductFeatureById(ProductGroupId);
            if (ProductFeature is null)
                return NotFound($"notfound ProductGroupId with {ProductGroupId}");
            else
                return Ok(ProductFeature);
        }
        [HttpGet("getAll")]
        public ActionResult GetProductFeatures()
        {
            var productFeature = _context.productFeatures.ToList();
            return Ok(productFeature);
        }
        [HttpPut("UpdateproductFeature")]
        public IActionResult UpdateproductFeature(int ProductGroupId, UpdateProductFeatureRequest request)
        {
            if (ModelState.IsValid)
            {
                var UpdateProductFeature = _context.productFeatures.Where(s => s.ProductGroupId == ProductGroupId).FirstOrDefault();
                if (UpdateProductFeature is not null)
                {
                    if (request.Name != null)
                        UpdateProductFeature.Name = request.Name;
                    if (request.Price != null)
                        UpdateProductFeature.Price = request.Price;
                    if (request.ProductGroupId != null)
                        UpdateProductFeature.ProductGroupId = request.ProductGroupId;
                    if (request.ExpirationData != null)
                        UpdateProductFeature.ExpirationData = request.ExpirationData;
                    var newProductFeature = _context.productFeatures.Update(UpdateProductFeature);
                    _context.SaveChanges();
                    return Ok(newProductFeature.Entity);
                }
                return NotFound("شخص با آیدی گروه کالا وارد شده یافت نشد");
            }
            return BadRequest("اطلاعات ارسالی صحیح نمی باشد");
        }
        [HttpPost("AddProductFeature")]
        public IActionResult InsertedProductFeature(InsertProductFeatureRequest request)
        {
            var existProductFeature = _context.productFeatures.Where(s => s.ProductGroupId == request.ProductGroupId).FirstOrDefault();
            if (existProductFeature is null)
            {
                Entity.ProductFeature newProductFeature = new Entity.ProductFeature()
                {
                    ExpirationData = request.ExpirationData,
                    Price = request.Price,
                    ProductGroupId = request.ProductGroupId,
                    Name = request.Name,
                };

                var InsertedProductFeature = _context.productFeatures.Add(newProductFeature);
                _context.SaveChanges();
            }
            return Ok();
        }
        [HttpDelete("DeleteProductFeature")]
        public IActionResult DeleteProductFeature(DeleteProductFeatureRequest request)
        {
            var deleteProductFeature = _context.productFeatures.Where(s => s.ProductGroupId == request.ProductGroupId).FirstOrDefault();
            if (deleteProductFeature != null)
            {
                _context.productFeatures.Remove(deleteProductFeature);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound("ویژگی کالایی با آیدی وارد یافت نشد");
        }
    }
}

