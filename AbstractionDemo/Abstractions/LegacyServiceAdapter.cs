namespace LiskovDemo.AbstractionDemo.Abstractions
{
    using global::LiskovDemo.Services;

    public class LegacyServiceAdapter
    {
        public UserAbstraction GetUser()
        {
            var legacyService = new LegacyService();

            var userId = legacyService.GetUsername();

            var userAbstraction = new UserAbstraction(userId, legacyService.GetUserEmail(userId));

            return userAbstraction;
        }
    }
}
