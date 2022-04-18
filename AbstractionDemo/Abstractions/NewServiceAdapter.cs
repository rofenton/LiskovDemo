namespace LiskovDemo.AbstractionDemo.Abstractions
{
    using global::LiskovDemo.Services;

    public class NewServiceAdapter
    {
        public UserAbstraction GetUser()
        {
            var legacyService = new NewService();

            var user = legacyService.GetUser();

            var userAbstraction = new UserAbstraction(user.Username, user.Email);

            return userAbstraction;
        }
    }
}
