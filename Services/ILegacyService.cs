namespace LiskovDemo.Services
{
    public interface ILegacyService
    {
        string GetUserEmail(string username);
        string GetUsername();
    }
}