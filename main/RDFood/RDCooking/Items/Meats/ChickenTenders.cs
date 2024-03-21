namespace RD.Framework.main.RDFood.RDCooking.Items.Meats
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;

    [Serialized]
    [LocDisplayName("Chicken Tenders")]
    [Weight(100)]
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("Fried Chicken Tenders")]
    public partial class ChickenTendersItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Chichen Tenders");

        public override float Calories => 250;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 4, Fat = 9, Protein = 7, Vitamins =3 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(110);
    }
}
