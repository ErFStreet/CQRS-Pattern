namespace Data.Contract;

public interface IUserQueriesRepository
{
    IEnumerable<User> FindAll();

    User? FindById(int userId);
}