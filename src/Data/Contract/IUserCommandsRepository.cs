namespace Data.Contract;

public interface IUserCommandsRepository
{
    void Create(User user);

    void Delete(User user);

    void Update(User user);
}