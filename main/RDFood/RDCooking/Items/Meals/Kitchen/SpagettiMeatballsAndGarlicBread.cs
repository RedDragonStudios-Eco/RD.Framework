namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Kitchen
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;


    [Serialized]
    [LocDisplayName("Spaghetti, Meatballs, and Garlic Bread")]
    [Weight(1)]
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("Mom's Spaghetti with Garlic Bread")]
    public partial class SpaghettiMeatballsAndGarlicBreadItem : FoodItem
    {
        public override float Calories => 2000;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 20, Fat = 12, Protein = 16, Vitamins = 10 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
