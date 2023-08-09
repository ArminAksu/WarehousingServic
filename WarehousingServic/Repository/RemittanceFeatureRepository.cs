using WarehousingServic.Data;
using WarehousingServic.Entity;

namespace WarehousingServic.Repository
{
    public class RemittanceFeatureRepository : IRemittanceFeatureRepository
    {
        private readonly DataContext _dataContext;
        public RemittanceFeatureRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public RemittanceFeature GetRemittanceFeature(int id)
        {
            var result = _dataContext.RemittanceFeatures.Find(id);
            return result;
        }
        public IEnumerable<RemittanceFeature> GetRemittanceFeatures()
        {
            return _dataContext.RemittanceFeatures.ToList();
        }
        public RemittanceFeature UpdateRemittanceFeature(RemittanceFeature RemittanceFeature)
        {
            var result = _dataContext.RemittanceFeatures.Update(RemittanceFeature).Entity;
            return result;
        }
    }
}
