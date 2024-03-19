using MinimalApi.Models;

namespace MinimalApi.Repositories;

public interface IClientsRepository
{
    Task<Client> GetAsync(Guid id);
    Task<Client?> Create(Client client);
}