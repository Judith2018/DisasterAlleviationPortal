<<<<<<< HEAD
﻿namespace DisasterAlleviationPortal.Logic
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
=======
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
>>>>>>> f1c96e60d4c1cbcce4c3189b9f7ad9cf7695dbe9
