using static WarehousingServic.Repository.ReceiptFeatureRepository;
using WarehousingServic.Data;
using WarehousingServic.Entity;

namespace WarehousingServic.Repository
{
    public class ReceiptFeatureRepository : IReceiptFeatureRepository
       
        {
            private readonly DataContext _dataContext;
            public ReceiptFeatureRepository(DataContext dataContext)
            {
                _dataContext = dataContext;
            }
            public ReceiptFeature GetReceiptFeature(int id)
            {
                var result = _dataContext.ReceiptFeatures.Find(id);
                return result;
            }
            public IEnumerable<ReceiptFeature> GetReceiptFeatures()
            {
                return _dataContext.ReceiptFeatures.ToList();
            }
            public ReceiptFeature UpdateReceiptFeature(ReceiptFeature ReceiptFeature)
            {
                var result = _dataContext.ReceiptFeatures.Update(ReceiptFeature).Entity;
                return result;
            }

        }
    }
