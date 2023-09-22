namespace HousingCompany.Model.Enums
{
    /// <summary>
    /// MaterialsEnum for all materials to work with
    /// MaterialPrices for renovation cost
    /// </summary>
    public struct MaterialsEnum
    {
        public enum Materials
        {
            OldOneBay,
            OldTwoBay,
            OldThreeBay,
            OldFloor,
            OldKitchen,
            OldBathroom,
            OldEntranceDoor,
            OldBackDoor,
            NewFloor,
            NewKitchen,
            NewBathroom,
            NewEntranceDoor,
            NewBackDoor,
            NewOneBay,
            NewTwoBay,
            NewThreeBay,
        }

        public enum MaterialPrices
        {
            OneBay = 1879,
            TwoBay = 2709,
            ThreeBay = 4678,
            Floor = 179,
            Kitchen = 37899
        }
    }
}
