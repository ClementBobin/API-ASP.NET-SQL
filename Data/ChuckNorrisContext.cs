using Microsoft.EntityFrameworkCore;
using ChuckNorrisApi.Models;

namespace ChuckNorrisApi.Data
{
    public class ChuckNorrisContext : DbContext
    {
        public ChuckNorrisContext(DbContextOptions<ChuckNorrisContext> options)
            : base(options) { }

        public DbSet<ChuckNorrisQuote> Quotes { get; set; }
    }
}
