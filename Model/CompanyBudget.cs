namespace HousingCompany.Model
{
    /// <summary>
    /// Total company budget to deduct from when renovating
    /// </summary>
    public class CompanyBudget
    {
        private int _companyBudget { get; set; } = 550000000;

        public void DeductFromBudget(int price)
        {
            _companyBudget -= price;
        }

        public string GetBudget()
        {
            return $"\nThe company budget is presently {_companyBudget} DKK";
        }
    }
}
