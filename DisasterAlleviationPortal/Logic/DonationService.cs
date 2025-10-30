namespace DisasterAlleviationPortal.Logic
{
    public class DonationService
    {
        public bool ValidateDonation(string resourceType, int quantity)
        {
            if (string.IsNullOrWhiteSpace(resourceType) || quantity <= 0)
                return false;
            return true;
        }
    }
}

