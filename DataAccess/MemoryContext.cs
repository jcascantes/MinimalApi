using Microsoft.EntityFrameworkCore;
using MinimalApi.Models;

namespace MinimalApi.DataAccess
{
    public class MemoryContext : DbContext
    {
        public MemoryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Client> Clients => Set<Client>();
    }
}
