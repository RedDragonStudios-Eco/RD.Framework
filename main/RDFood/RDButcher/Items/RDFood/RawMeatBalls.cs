namespace RD.Framework.main.RDFood.RDButcher.Items.RDFood
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;

    [Serialized]
    [LocDisplayName("Raw MeatBall")]
    [Weight(500)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Raw Meatballs, It should probably be cooked before being consumed.")]
    public partial class RawMeatballItem : FoodItem
    {

        public override LocString DisplayNamePlural => Localizer.DoStr("Raw MeatBalls");
        public override float Calories => 400;
        public override Nutrients Nutrition => new() { Carbs = 0, Fat = 3, Protein = 6, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
