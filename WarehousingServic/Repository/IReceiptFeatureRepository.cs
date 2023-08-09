using WarehousingServic.Entity;

namespace WarehousingServic.Repository
{
    public interface IReceiptFeatureRepository
    {
        ReceiptFeature UpdateReceiptFeature(ReceiptFeature ReceiptFeature);
        IEnumerable<ReceiptFeature> GetReceiptFeatures();
        ReceiptFeature GetReceiptFeature(int id);
    }
}
