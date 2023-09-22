using HousingCompany.Model.Enums;

namespace HousingCompany.Model.ApartmentObjects
{
    internal class TwoRoomApartment : Housing
    {
        public TwoRoomApartment()
        {
            HousingType = HousingTypeEnum.HousingType.Apartment;
            SizeSquareMeter = 55;
            Rooms = 2;
            Floors = 1;
            Furnished = false;
            SharingFriendly = true;
            AnimalsAllowed = true;
            Elevator = false;
            SeniorFriendly = false;
            OnlyForStudents = false;
            BalconyOrTerrace = false;
            Parking = true;
            Dishwasher = true;
            WashingMachine = true;
            ChargingStand = false;
            Dryer = true;
            EnergyLabel = 'D';
        }
    }
}
