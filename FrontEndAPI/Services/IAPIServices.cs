namespace FrontEndAPI.Services
{
    public interface IAPIServices
    {
        Task<string> GetResponseFromApi(string URI);

    }
}
