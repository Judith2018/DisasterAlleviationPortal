namespace DisasterAlleviationPortal.Logic
{
    public class LoginValidator
    {
        public bool ValidateCredentials(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return false;

            if (!email.Contains("@") || password.Length < 6)
                return false;

            return true;
        }
    }
}
