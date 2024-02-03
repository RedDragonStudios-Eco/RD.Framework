﻿using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Kitchen
{
    [Serialized]
    [LocDisplayName("Beet Dip")]
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("A light snack to tide you over till your next meal.")]
    public partial class BeetDipItem : FoodItem
    {
        public override float Calories => 1500;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 23, Fat = 18, Protein = 12, Vitamins = 8 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}