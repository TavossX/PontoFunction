namespace PontoFunction;

public class UserService : IUserService
{
    public Task<string> PunchIn(PunchDto dto)
    {
        return Task.FromResult("Punch in successful");
    }
}