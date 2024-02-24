namespace RD.Framework.main.RDFood.RDButcher.Items.RDFood
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;

    [Serialized]
    [LocDisplayName("Raw Meatball")]
    [Weight(50)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Raw Meatball, It should probably be cooked before being consumed.")]
    public partial class RawMeatballItem : FoodItem
    {

        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Meatballs");
        public override float Calories => 50;
        public override Nutrients Nutrition => new() { Carbs = 0, Fat = 4, Protein = 6, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
