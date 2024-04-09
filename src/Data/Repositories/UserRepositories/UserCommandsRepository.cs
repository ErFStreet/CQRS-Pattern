namespace Data.Repositories.UserRepositories;

public class UserCommandsRepository : object, IUserCommandsRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public UserCommandsRepository(ApplicationDbContext applicationDbContext) : base()
    {
        _applicationDbContext = applicationDbContext;
    }

    public void Create(User user)
    {
        _applicationDbContext.Add(entity: user);
    }

    public void Update(User user)
    {
        _applicationDbContext.Update(entity: user);
    }

    public void Delete(User user)
    {
        _applicationDbContext.Remove(entity: user);
    }
}
