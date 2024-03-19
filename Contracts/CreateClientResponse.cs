﻿namespace MinimalApi.Contracts;

public record CreateClientResponse
{
    public CreateClientResponse(Guid id, string name, string lastName, string email)
    {
        Id = id;
        Name = name;
        LastName = lastName;
        Email = email;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
