using WarehousingServic.Entity;

namespace WarehousingServic.Repository
{
    public interface IProductFeatureRepository
    {
        ProductFeature GetProductFeatureById(int id);
        ProductFeature GetProductFeatureByProductGroupId(int ProductGroupId);
    }
}
