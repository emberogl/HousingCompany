using HousingCompany.Model.Enums;

namespace HousingCompany.Model.ApartmentObjects
{
    internal class FourRoomApartment : Housing
    {
        public FourRoomApartment()
        {
            HouseProperties["LivingroomWindowType"] = MaterialsEnum.Materials.OldThreeBay;

            HousingType = HousingTypeEnum.HousingType.Apartment;
            SizeSquareMeter = 85;
            Rooms = 4;
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
            ChargingStand = true;
            Dryer = false;
            EnergyLabel = 'D';
        }
    }
}
