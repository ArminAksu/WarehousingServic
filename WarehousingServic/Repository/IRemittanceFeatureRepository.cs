using WarehousingServic.Entity;

namespace WarehousingServic.Repository
{
    public interface IRemittanceFeatureRepository
    {
        RemittanceFeature UpdateRemittanceFeature(RemittanceFeature RemittanceFeature);
        IEnumerable<RemittanceFeature> GetRemittanceFeatures();
        RemittanceFeature GetRemittanceFeature(int id);
    }
}
