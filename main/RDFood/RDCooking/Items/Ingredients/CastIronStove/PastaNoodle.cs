namespace RD.Framework.main.RDFood.RDCooking.Items.Ingredients.CastIronStove
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Utils;

    [LocDisplayName("Pasta Noodle")]
    [Weight(100)]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true)]
    [LocDescription("Pasta Noodles Made From Pasta Dough")]
    public partial class PastaNoodleItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Pasta Noodles");

        public override float Calories => 400;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 8, Fat = 0, Protein = 7, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
