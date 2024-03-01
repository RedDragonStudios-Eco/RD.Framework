namespace RD.Framework.main.RDFood.RDCooking.Items.Ingredients
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Utils;

    [LocDisplayName("FetaCheese")]
    [Weight(100)]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true)]
    [LocDescription("Made from the milk of a goat.")]
    public partial class FetaCheeseItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("FetaCheese");

        public override float Calories => 200;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 6, Protein = 3, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
