using Microsoft.EntityFrameworkCore;
using ViewsService.MainViews;

namespace DAL
{
    public class CovidDataContext : DbContext
    {
        public CovidDataContext(DbContextOptions<CovidDataContext> options)
            : base(options)
        {
        }

        public DbSet<CovidData> CovidData { get; set; }
    }
}
