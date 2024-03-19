using MinimalApi.Contracts;
using MinimalApi.Mappings;
using MinimalApi.Models;
using MinimalApi.Repositories;

namespace MinimalApi.Services
{
    public class ClientsService : IClientsService
    {
        readonly IClientsRepository repository;

        public ClientsService(IClientsRepository repository)
        {
            this.repository = repository;
        }

        public async Task<CreateClientResponse?> Create(CreateClientRequest request)
        {
            var result = await repository.Create(request.ToClient());
            return result?.ToCreateClientResponse();
        }

        public async Task<CreateClientResponse?> Get(Guid id)
        {
            var response = await repository.GetAsync(id);
            return response?.ToCreateClientResponse();
        }
    }
}
