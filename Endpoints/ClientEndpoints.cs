using Microsoft.AspNetCore.Mvc;
using MinimalApi.Contracts;
using MinimalApi.Services;

namespace MinimalApi.Endpoints;

public static class ClientEndpoints
{
    public async static Task<IResult> GetClient(IClientsService clientsService, Guid clientId)
    {
        var response = await clientsService.Get(clientId);
        return response is not null ? Results.Ok(response) : Results.BadRequest();
    }

    public static async Task<IResult> CreateClient(IClientsService clientsService, CreateClientRequest createClient)
    {
        var response = await clientsService.Create(createClient);
        return response is not null? Results.Ok(response) : Results.BadRequest();
    }
}
