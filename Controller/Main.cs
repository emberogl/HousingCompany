using HousingCompany.Model;
using HousingCompany.Model.ApartmentObjects;
using HousingCompany.View;

namespace HousingCompany.Controller
{
    /// <summary>
    /// Example run to show how the program works
    /// </summary>
    public class Main
    {
        public void Controller()
        {
            Random random = new Random();

            List<Housing> FiveRoomApartments = new List<Housing>();
            List<Housing> FourRoomApartments = new List<Housing>();
            List<Housing> ThreeRoomApartments = new List<Housing>();
            List<Housing> TwoRoomApartments = new List<Housing>();
            List<Housing> OneRoomApartments = new List<Housing>();

            for (int i = 0; i < 47; i++)
            {
                FiveRoomApartments.Add(new FiveRoomApartment());
            }
            for (int i = 0; i < 97; i++)
            {
                FourRoomApartments.Add(new FourRoomApartment());
            }
            for (int i = 0; i < 167; i++)
            {
                ThreeRoomApartments.Add(new ThreeRoomApartment());
            }
            for (int i = 0; i < 235; i++)
            {
                TwoRoomApartments.Add(new TwoRoomApartment());
            }
            for (int i = 0; i < 368; i++)
            {
                OneRoomApartments.Add(new OneRoomApartment());
            }

            Housing randomApartment = FourRoomApartments.ElementAt(random.Next(0, FourRoomApartments.Count()));

            Gui gui = new Gui();
            gui.Print(randomApartment.ToString()); // First output is what the apartment looks like before renovation

            IWorkers workers = new Renovation();
            CompanyBudget budget = new CompanyBudget();
            workers.CompanyBudget = budget;

            gui.Print(budget.GetBudget()); // Second output is the company budget before renovating

            /// Renovating the random apartment from above (didn't have time to implement all renovating methods)
            workers.RenovateKitchen(randomApartment);
            workers.RenovateFloor(randomApartment);
            workers.RenovateWindow(randomApartment);

            gui.Print(randomApartment.ToString()); // Third output is the state of the apartment after the renovations above
            gui.Print(budget.GetBudget()); // Fourth output is the budget after the renovations including material and work cost

            /// Renovating all five room apartments
            foreach (Housing housing in FiveRoomApartments)
            {
                workers.RenovateKitchen(housing);
                workers.RenovateFloor(housing);
                workers.RenovateWindow(housing);
            }

            gui.Print(budget.GetBudget()); // Fifth output is the budget after renovating all 47 five room apartments
        }
    }
}
