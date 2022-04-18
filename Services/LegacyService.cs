namespace LiskovDemo.Services
{
    public class LegacyService : ILegacyService
    {
        public string GetUsername()
        {
            return "legacyUsername";
        }

        public string GetUserEmail(string username)
        {
            return "legacyEmail";
        }
    }
}
