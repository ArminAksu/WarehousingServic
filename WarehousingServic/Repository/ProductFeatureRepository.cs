using WarehousingServic.Data;
using WarehousingServic.Entity;

namespace WarehousingServic.Repository
{
    public class ProductFeatureRepository : IProductFeatureRepository
    {
        private readonly DataContext _dataContext;
        public ProductFeatureRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public ProductFeature GetProductFeatureById(int id)
        {
            return _dataContext.productFeatures.Find(id);
        }
        public ProductFeature GetProductFeatureByProductGroupId(int ProductGroupId)
        {
            return _dataContext.productFeatures.Where(p => p.ProductGroupId == ProductGroupId).FirstOrDefault();
        }
    }
}
