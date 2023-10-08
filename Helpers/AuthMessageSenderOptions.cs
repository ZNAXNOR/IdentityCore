namespace IdentityCore.Helpers
{
    public class AuthMessageSenderOptions
    {
        // API
        public string? ApiKey { get; set; }

        // SMTP
        public string? Host { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
