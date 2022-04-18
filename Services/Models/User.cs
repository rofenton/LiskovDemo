namespace LiskovDemo.Services
{
    public class User
    {
        public string Username { get; private set; }

        public string Email { get; private set; }

        public User(string Username, string Email)
        {
            this.Username = Username;
            this.Email = Email;
        }
    }
}
