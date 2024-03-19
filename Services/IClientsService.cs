using MinimalApi.Contracts;

namespace MinimalApi.Services
{
    public interface IClientsService
    {
        Task<CreateClientResponse?> Create(CreateClientRequest request);
        Task<CreateClientResponse?> Get(Guid id);
    }
}