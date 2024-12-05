using BHF.MS.test18.Database.Context.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace BHF.MS.test18.Database.Context
{
    [ExcludeFromCodeCoverage(Justification = "It's EF context implementation")]
    public class CustomDbContext(DbContextOptions<CustomDbContext> options) : DbContext(options)
    {
        public virtual DbSet<DbItem> DbItems { get; set; }
    }
}
