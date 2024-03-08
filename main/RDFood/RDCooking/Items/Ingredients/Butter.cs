namespace RD.Framework.main.RDFood.RDCooking.Items.Ingredients
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;

    [Serialized]
    [LocDisplayName("Butter")]
    [Weight(100)]
    [Tag("Fat")]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true)]
    [LocDescription("Made from the milk of a cow.")]
    public partial class ButterStickItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Butter");

        public override float Calories => 200;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 8, Protein = 0, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }

}
 