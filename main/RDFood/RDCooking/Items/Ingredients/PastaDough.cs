namespace RD.Framework.main.RDFood.RDCooking.Items.Ingredients
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;

    [Serialized]
    [LocDisplayName("Pasta Dough")]
    [Weight(400)]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true)]
    [LocDescription("A Pasta Dough Made from Eggs and Flour")]
    public partial class PastaDoughItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Pasta Dough");

        public override float Calories => 500;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 12, Fat = 0, Protein = 8, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
