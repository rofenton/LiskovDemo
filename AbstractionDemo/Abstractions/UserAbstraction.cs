namespace LiskovDemo.AbstractionDemo.Abstractions
{
    public class UserAbstraction
    {
        public string UserId { get; private set; }
        public string UserEmail { get; private set; }

        public UserAbstraction(string UserId, string UserEmail)
        {
            this.UserId = UserId;
            this.UserEmail = UserEmail;
        }
    }
}
