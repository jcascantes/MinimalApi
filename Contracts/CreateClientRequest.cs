namespace MinimalApi.Contracts;

public record class CreateClientRequest
{
    public CreateClientRequest(string name, string lastName, string email)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        Email = email;
    }

    public Guid Id { get;}
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
