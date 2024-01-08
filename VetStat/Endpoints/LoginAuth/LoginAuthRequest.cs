namespace VetStat.Endpoints.LoginAuth
{
    public class LoginAuthRequest
    {
        public string usernameOrEmail { get; set; }

        public string password { get; set; }

        public bool? rememberMe { get; set; } = false;
    }
}
