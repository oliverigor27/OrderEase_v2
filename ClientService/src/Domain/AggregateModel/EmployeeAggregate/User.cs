using OrderEase.ClientService.Domain.SeedWork;

namespace OrderEase.ClientService.Domain.AggregateModel.EmployeeAggregate;

public sealed class User : BaseEntity, AggregateRoot
{
    public User(string username, string email, string password)
    {
        Username = username;
        Email = email;
        Password = password;
    }

    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
