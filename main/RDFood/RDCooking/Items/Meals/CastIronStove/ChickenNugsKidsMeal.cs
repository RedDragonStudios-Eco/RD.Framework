﻿namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.CastIronStove
{
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;

    [Serialized]
    [LocDisplayName("Chicken Nuggets Kids Meal")]
    [Weight(100)]
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("A Plate Of Chicken Nuggets and Fries")]
    public partial class ChickenNuggetsKidsMealItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Chichen Nuggets Kids Meal");

        public override float Calories => 1250;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 13, Fat = 15, Protein = 12, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(110);
    }
}
