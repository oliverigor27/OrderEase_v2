namespace OrderEase.ClientService.Application.Command.Users.CreateUser;

public class CreateUserCommand : IBaseCommand
{
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
