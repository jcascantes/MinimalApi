using Microsoft.EntityFrameworkCore;

namespace MinimalApi.Models
{
    [PrimaryKey("Id")]
    public class Client
    {        
        public Guid Id { get; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
