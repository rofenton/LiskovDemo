namespace LiskovDemo.LiskovDemo.Shims
{
    using global::LiskovDemo.Services;

    public class LegacyServiceShim : ILegacyService
    {
        private readonly INewService newService;

        public LegacyServiceShim(INewService newService)
        {
            this.newService = newService;
        }

        public string GetUserEmail(string username)
        {
            return this.newService.GetUser().Email;
        }

        public string GetUsername()
        {
            return this.newService.GetUser().Username;
        }
    }
}
