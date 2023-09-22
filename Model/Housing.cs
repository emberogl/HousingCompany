using HousingCompany.Model.Enums;

namespace HousingCompany.Model
{
    /// <summary>
    /// Every housing can be a different housing type, and the properties to change in the house is a dict
    /// </summary>
    abstract class Housing
    {
        protected Dictionary<string, MaterialsEnum.Materials> HouseProperties = new Dictionary<string, MaterialsEnum.Materials> 
        {
            { "Floor", MaterialsEnum.Materials.OldFloor }, { "Kitchen", MaterialsEnum.Materials.OldKitchen },
            { "Bathroom", MaterialsEnum.Materials.OldBathroom }, { "EntranceDoor", MaterialsEnum.Materials.OldEntranceDoor },
            { "BackDoor", MaterialsEnum.Materials.OldBackDoor }, { "RoomWindow", MaterialsEnum.Materials.OldOneBay },
            { "LivingroomWindowType", MaterialsEnum.Materials.OldTwoBay }
        };

        protected HousingTypeEnum.HousingType? HousingType;
        protected int SizeSquareMeter;
        protected int Rooms;
        protected int Floors;
        protected bool Furnished;
        protected bool SharingFriendly;
        protected bool AnimalsAllowed;
        protected bool Elevator;
        protected bool SeniorFriendly;
        protected bool OnlyForStudents;
        protected bool BalconyOrTerrace;
        protected bool Parking;
        protected bool Dishwasher;
        protected bool WashingMachine;
        protected bool ChargingStand;
        protected bool Dryer;
        protected char EnergyLabel;

        public override string ToString()
        {
            return $"\n{Rooms} room {HousingType}:\n{HousingType} floor: {HouseProperties["Floor"]} | {HousingType} kitchen: {HouseProperties["Kitchen"]}" +
                $" | {HousingType} bathroom: {HouseProperties["Bathroom"]}, | {HousingType} entrance door: {HouseProperties["EntranceDoor"]}" +
                $"| {HousingType} back door: {HouseProperties["BackDoor"]} | {HousingType} room window: {HouseProperties["RoomWindow"]}" +
                $"| {HousingType} livingroom window: {HouseProperties["LivingroomWindowType"]}";
        }

        public int GetFloorLength()
        {
            return Floors;
        }

        public int GetRoomLength()
        {
            return Rooms;
        }
        public int GetSizeSquareMeter()
        {
            return SizeSquareMeter;
        }

        public void NewWindow(MaterialsEnum.Materials window)
        {
            HouseProperties["LivingroomWindowType"] = window;
        }

        public void NewFloor(MaterialsEnum.Materials floor)
        {
            HouseProperties["Floor"] = floor;
        }

        public void NewKitchen(MaterialsEnum.Materials kitchen) 
        {
            HouseProperties["Kitchen"] = kitchen;
        }
    }
}
