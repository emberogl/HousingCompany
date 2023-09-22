using HousingCompany.Model.Enums;

namespace HousingCompany.Model.ApartmentObjects
{
    internal class OneRoomApartment : Housing
    {
        public OneRoomApartment()
        {
            HousingType = HousingTypeEnum.HousingType.Apartment;
            SizeSquareMeter = 40;
            Rooms = 1;
            Floors = 1;
            Furnished = false;
            SharingFriendly = false;
            AnimalsAllowed = true;
            Elevator = false;
            SeniorFriendly = false;
            OnlyForStudents = true;
            BalconyOrTerrace = false;
            Parking = true;
            Dishwasher = true;
            WashingMachine = true;
            ChargingStand = true;
            Dryer = true;
            EnergyLabel = 'D';
        }
    }
}
