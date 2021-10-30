using CovidCases.Models;
using Microsoft.EntityFrameworkCore;

namespace CovidCases
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
