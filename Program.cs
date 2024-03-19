
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Contracts;
using MinimalApi.DataAccess;
using MinimalApi.Endpoints;
using MinimalApi.Repositories;
using MinimalApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IClientsService, ClientsService>();
builder.Services.AddScoped<IClientsRepository,  ClientsRepository>();
builder.Services.AddDbContext<MemoryContext>(opt => opt.UseInMemoryDatabase("ClientsDb"));

var app = builder.Build();


app.MapGet("/clients/{id}", async ([FromServices] IClientsService clientService, Guid id) => await ClientEndpoints.GetClient(clientService, id));
app.MapPost("/clients", async ([FromServices] IClientsService clientService, CreateClientRequest createClient) => await ClientEndpoints.CreateClient(clientService, createClient));

app.Run();
