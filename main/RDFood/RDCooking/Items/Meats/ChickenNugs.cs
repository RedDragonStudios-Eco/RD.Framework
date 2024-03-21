namespace RD.Framework.main.RDFood.RDCooking.Items.Meats
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;

    [Serialized]
    [LocDisplayName("Chicken Nuggets")]
    [Weight(100)]
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("Fried Chicken Nuggets")]
    public partial class ChickenNuggetsItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Chichen Nuggets");

        public override float Calories => 150;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 2, Fat = 7, Protein = 6, Vitamins = 2 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(110);
    }
}
