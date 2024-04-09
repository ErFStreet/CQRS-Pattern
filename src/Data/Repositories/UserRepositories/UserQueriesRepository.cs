namespace Data.Repositories.UserRepositories;

public class UserQueriesRepository : IUserQueriesRepository
{
    private readonly ApplicationDbContext _applicationDbContext;

    public UserQueriesRepository(ApplicationDbContext applicationDbContext) : base()
    {
        _applicationDbContext = applicationDbContext;
    }

    public User? FindById(int userId)
    {
        return _applicationDbContext.Users!.Find(keyValues: userId);
    }

    public IEnumerable<User> FindAll()
    {
        return _applicationDbContext.Users!
            .ToList();
    }
}
