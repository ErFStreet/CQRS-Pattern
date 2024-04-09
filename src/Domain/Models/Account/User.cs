namespace Domain.Models.Account;

public class User : object
{
    public User() : base()
    {
    }

    public int Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Email { get; set; }

    public required string HashedPassword { get; set; }
}
