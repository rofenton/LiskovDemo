namespace LiskovDemo.Services
{
    public class NewService : INewService
    {
        public User GetUser()
        {
            return new User("newUsername", "newEmail");
        }
    }
}
