using HousingCompany.Model.Enums;

namespace HousingCompany.Model.ApartmentObjects
{
    internal class ThreeRoomApartment : Housing
    {
        public ThreeRoomApartment()
        {
            HousingType = HousingTypeEnum.HousingType.Apartment;
            SizeSquareMeter = 70;
            Rooms = 3;
            Floors = 1;
            Furnished = false;
            SharingFriendly = true;
            AnimalsAllowed = true;
            Elevator = false;
            SeniorFriendly = true;
            OnlyForStudents = false;
            BalconyOrTerrace = false;
            Parking = true;
            Dishwasher = false;
            WashingMachine = false;
            ChargingStand = false;
            Dryer = false;
            EnergyLabel = 'D';
        }
    }
}
