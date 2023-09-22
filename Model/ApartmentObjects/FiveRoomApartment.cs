using HousingCompany.Model.Enums;

namespace HousingCompany.Model.ApartmentObjects
{
    internal class FiveRoomApartment : Housing
    {
        public FiveRoomApartment()
        {
            HouseProperties["LivingroomWindowType"] = MaterialsEnum.Materials.OldThreeBay;

            HousingType = HousingTypeEnum.HousingType.Apartment;
            SizeSquareMeter = 110;
            Rooms = 5;
            Floors = 2;
            Furnished = false;
            SharingFriendly = true;
            AnimalsAllowed = false;
            Elevator = false;
            SeniorFriendly = false;
            OnlyForStudents = false;
            BalconyOrTerrace = true;
            Parking = true;
            Dishwasher = false;
            WashingMachine = false;
            ChargingStand = false;
            Dryer = false;
            EnergyLabel = 'D';
        }
    }
}
