using System.Numerics;
using WarehousingServic.Data;
using WarehousingServic.Entity;

namespace WarehousingServic.Repository
{
    public class ProductGroupRepository : IProductGroupRepository
    {
        private readonly DataContext _dataContext;
        public ProductGroupRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public ProductGroup GetProductGroupById(int id)
        {
            return _dataContext.ProductGroups.Find(id);
        }
        public ProductGroup GetProductGroupByParentGroupe(string ParentGroupe)
        {
            return _dataContext.ProductGroups.Where(p => p.ParentGroupe == ParentGroupe).FirstOrDefault();
        }

        object IProductGroupRepository.GetProductGroupById(string parentGroupe)
        {
            throw new NotImplementedException();
        }
    }
}