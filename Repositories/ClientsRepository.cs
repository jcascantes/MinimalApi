using Microsoft.EntityFrameworkCore;
using MinimalApi.DataAccess;
using MinimalApi.Models;

namespace MinimalApi.Repositories
{
    public class ClientsRepository : IClientsRepository
    {
        readonly MemoryContext dbContext;

        public ClientsRepository(MemoryContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Client?> Create(Client client)
        {
            var result = await dbContext.Clients.AddAsync(client);           
            if(result.State == EntityState.Added)
            {
                dbContext.SaveChanges();
                return result.Entity;
            }
            return null;
        }

        public async Task<Client> GetAsync(Guid id)
        {
            var result = await dbContext.Clients.FindAsync(id);
            return result;
        }
    }
}
