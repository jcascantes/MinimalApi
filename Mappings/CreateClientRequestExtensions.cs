using MinimalApi.Contracts;
using MinimalApi.Models;

namespace MinimalApi.Mappings
{
    public static class CreateClientRequestExtensions
    {
        public static Client ToClient(this CreateClientRequest request)
        {
            return new Client
            {
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email
            };
        }

        public static CreateClientResponse ToCreateClientResponse(this CreateClientRequest client)
        {
            return new CreateClientResponse(client.Id, client.Name, client.LastName, client.Email);
        }

        public static CreateClientResponse ToCreateClientResponse(this Client client)
        {
            return new CreateClientResponse(client.Id, client.Name, client.LastName, client.Email);
        }
    }
}
