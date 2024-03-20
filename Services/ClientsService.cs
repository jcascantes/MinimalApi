using MinimalApi.Contracts;
using MinimalApi.Mappings;
using MinimalApi.Repositories;

namespace MinimalApi.Services
{
    public class ClientsService : IClientsService
    {
        readonly IClientsRepository repository;
        readonly ClientsMapper clientMapper;

        public ClientsService(IClientsRepository repository, ClientsMapper clientMapper)
        {
            this.repository = repository;
            this.clientMapper = clientMapper;
        }

        public async Task<CreateClientResponse?> Create(CreateClientRequest request)
        {
            var result = await repository.Create(clientMapper.ToClient(request));
            return result is not null?clientMapper.ToCreateClientReponse(result):null;
        }

        public async Task<CreateClientResponse?> Get(Guid id)
        {
            var response = await repository.GetAsync(id);
            return response is not null? clientMapper.ToCreateClientReponse(response): null;
        }
    }
}
