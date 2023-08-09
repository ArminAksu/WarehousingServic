using System.Numerics;
using WarehousingServic.Entity;

namespace WarehousingServic.Repository
{
    public interface IProductGroupRepository
    {
        object GetProductGroupById(string parentGroupe);

        public interface IProductGroupRepository
        {
            ProductGroup GetProductGroupById(int id);
            ProductGroup GetProductGroupByParentGroupe(string ParentGroupe);
        }
    }
}
