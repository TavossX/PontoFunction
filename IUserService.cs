namespace PontoFunction
{
    public interface IUserService
    {
        Task<String> PunchIn(PunchDto dto);
    }
}
