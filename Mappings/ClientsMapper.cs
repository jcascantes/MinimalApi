using MinimalApi.Contracts;
using MinimalApi.Models;
using Riok.Mapperly.Abstractions;

namespace MinimalApi.Mappings
{
    [Mapper]
    public partial class ClientsMapper
    {
        public partial Client ToClient(CreateClientRequest request);
        public partial CreateClientResponse ToCreateClientReponse(Client client);
    }
}
