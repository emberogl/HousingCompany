using HousingCompany.Model;
using HousingCompany.Model.Enums;

namespace HousingCompany.Controller
{
    /// <summary>
    /// Renovator implementation of interface workers
    /// </summary>
    public class Renovation : IWorkers
    {
        public CompanyBudget? CompanyBudget { get; set; } // Stores company budget from controller instance to deduct from

        // Renovates windows based on how big the apartment is
        void IWorkers.RenovateWindow(Housing housing)
        {
            CompanyBudget.DeductFromBudget((int)MaterialsEnum.MaterialPrices.ThreeBay);
            CompanyBudget.DeductFromBudget((int)WorkerEnum.WorkerExpensePerHour.Worker1 * 60);
            if (housing.GetRoomLength() == 4 || housing.GetRoomLength() == 5)
            {
                housing.NewWindow(MaterialsEnum.Materials.NewThreeBay);
            }
            else
            {
                housing.NewWindow(MaterialsEnum.Materials.NewTwoBay);
            }
        }

        // Renovates floor and deducts from budget based on how many square meters of apartment
        void IWorkers.RenovateFloor(Housing housing) 
        {
            CompanyBudget.DeductFromBudget((int)MaterialsEnum.MaterialPrices.Floor*housing.GetSizeSquareMeter());
            CompanyBudget.DeductFromBudget((int)WorkerEnum.WorkerExpensePerHour.Worker2 * 600);
            housing.NewFloor(MaterialsEnum.Materials.NewFloor);
        }

        // Renovates kitchen and increases 17% of the price depending on how many rooms there are
        void IWorkers.RenovateKitchen(Housing housing)
        {
            CompanyBudget.DeductFromBudget((((int)MaterialsEnum.MaterialPrices.Kitchen * 2)*(housing.GetRoomLength()*17))/100);
            CompanyBudget.DeductFromBudget((int)WorkerEnum.WorkerExpensePerHour.Worker3 * 1200);
            housing.NewKitchen(MaterialsEnum.Materials.NewKitchen);
        }
    }
}
