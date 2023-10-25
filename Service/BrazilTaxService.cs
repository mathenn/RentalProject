
namespace RentalProject.Service
{
    internal class BrazilTaxService : ITaxService // Interface realization //
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
                return amount * 0.2;
            else
                return amount * 0.15;
        }
    }
}
