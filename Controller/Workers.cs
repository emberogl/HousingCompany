using HousingCompany.Model;

namespace HousingCompany.Controller
{
    interface IWorkers
    {
        public CompanyBudget? CompanyBudget { get; set; }
        void RenovateWindow(Housing housing);
        void RenovateFloor(Housing housing);
        void RenovateKitchen(Housing housing);
    }
}