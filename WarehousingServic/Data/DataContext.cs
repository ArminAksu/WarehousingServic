using Microsoft.EntityFrameworkCore;
using WarehousingServic.Entity;

namespace WarehousingServic.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<ProductFeature> productFeatures { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ReceiptFeature> ReceiptFeatures { get; set; }
        public DbSet<RemittanceFeature> RemittanceFeatures { get; set; }
        public DbSet<JwtFeilds> jwtFeilds { get; set; }
        public DbSet<LoginFieldRequest> loginFieldRequests { get; set; }
    }
}
