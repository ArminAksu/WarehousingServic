using DevExpress.Data.Browsing;
using DevExpress.Utils.Filtering;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WarehousingServic.Data;
using WarehousingServic.Entity;
using WarehousingServic.Repository;
using WarehousingServic.Request;
using static WarehousingServic.Repository.IProductGroupRepository;
using DataContext = WarehousingServic.Data.DataContext;
using IProductGroupRepository = WarehousingServic.Repository.IProductGroupRepository;

namespace WarehousingServic.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiVersion("1", Deprecated = true)]
    [ApiController]
    public class ProductGroupController : ControllerBase
    {
        DataContext _context;
        private readonly IProductGroupRepository _ProductGroupRepository;
        private readonly IReceiptFeatureRepository _ReceiptFeatureRepository;
        public ProductGroupController(DataContext dataContext, IReceiptFeatureRepository ReceiptFeatureRepository, IProductGroupRepository ProductGroupRepository)
        {
            _context = dataContext;
            _ProductGroupRepository = _ProductGroupRepository;
            _ReceiptFeatureRepository = _ReceiptFeatureRepository;

        }
        [HttpGet("getId")]
        public ActionResult<Entity.ProductGroup> GetInProductGroup(String ParentGroupe)
        {
            var ProductGroup = _ProductGroupRepository.GetProductGroupById(ParentGroupe);
            if (ProductGroup is null)
                return NotFound($"notfound ParentGroupe with {ParentGroupe}");
            else
                return Ok(ProductGroup);
        }
        [HttpGet("getAll")]
        public ActionResult GetProductGroups()
        {
            var ProductGroup = _context.ProductGroups.ToList();
            return Ok(ProductGroup);
        }
        [HttpPut("UpdateProductGroup")]
        public IActionResult UpdateProductGroup(String ParentGroupe, UpdateProductGroupRequest request)
        {
            if (ModelState.IsValid)
            {
                var UpdateProductGroup = _context.ProductGroups.Where(s => s.ParentGroupe == ParentGroupe).FirstOrDefault();
                if (UpdateProductGroup is not null)
                {
                    if (request.ProductGroupCode != null)
                        UpdateProductGroup.ProductGroupCode = request.ProductGroupCode;
                    if (request.ParentGroupe != null)
                        UpdateProductGroup.ParentGroupe = request.ParentGroupe;
                    if (request.name != null)
                        UpdateProductGroup.name = request.name;
                    var newProductGroup = _context.ProductGroups.Update(UpdateProductGroup);
                    _context.SaveChanges();
                    return Ok(newProductGroup.Entity);
                }
                return NotFound("شخص با گروه کالا وارد شده یافت نشد");
            }
            return BadRequest("اطلاعات ارسالی صحیح نمی باشد");
        }
        [HttpPost("AddProductGroup")]
        public IActionResult InsertProductGroup(InsertProductGroupRequest request)
        {
            var existProductGroup = _context.ProductGroups.Where(s => s.ParentGroupe == request.ParentGroupe).FirstOrDefault();
            if (existProductGroup is null)
            {
                Entity.ProductGroup newProductGroup = new Entity.ProductGroup()
                {
                    name = request.name,
                    ParentGroupe = request.ParentGroupe,
                    ProductGroupCode = request.ProductGroupCode,
                };

                var InsertProductGroup = _context.ProductGroups.Add(newProductGroup);
                _context.SaveChanges();
            }
            return Ok();
        }
        [HttpPost("mojodi kala be tartib")]
        public IActionResult insertProductGroup(InsertProductGroupRequest request)
        {
            var existProductGroup = _context.ProductGroups.Where(s => s.ParentGroupe == request.ParentGroupe).FirstOrDefault();
            if (existProductGroup is null)
            {
                Entity.ProductGroup newProductGroup = new Entity.ProductGroup()
                {
                    name = request.name,
                    ParentGroupe = request.ParentGroupe,
                    ProductGroupCode = request.ProductGroupCode,
                };

                var insertedProductGroup = _context.ProductGroups.Add(newProductGroup);
                _context.SaveChanges();

                ReceiptFeature newReceiptFeature = new ReceiptFeature()

                {
                    Id = 0,
                    DateOfReceipt = DateTime.Now,
                    ProductId = 0,
                    NumberOfProduct = 0,
                    PriceOfProduct = 0,
                    TotalPrice = 0,
                };
                int[] NumberOfProduct = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Enter NumberOfProduct {0}:", i + 1);
                    
                }

                Array.Sort(NumberOfProduct);

                Console.Write("moratab shode adad ha: ");
                foreach (int num in NumberOfProduct)
                {
                    Console.Write(NumberOfProduct + " ");

                }
                _context.SaveChanges();
                return Ok();
            }
            return Ok();
        }
    
        [HttpDelete("DeleteProductGroup")]
        public IActionResult DeleteProductGroup(DeleteProductGroupRequest request)
        {
            var deleteProductGroup = _context.ProductGroups.Where(s => s.ParentGroupe == request.ParentGroupe).FirstOrDefault();
            if (deleteProductGroup != null)
            {
                _context.ProductGroups.Remove(deleteProductGroup);
                _context.SaveChanges();
                return Ok();
            }
            return NotFound("کالایی با گروه کالا وارد یافت نشد");
        }
    }
}

