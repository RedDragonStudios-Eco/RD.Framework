﻿using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Stove
{
    [Serialized]  
    [LocDisplayName("Jumbalaya")] 
    [Weight(1)] 
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("Bringing Cajun cooking straight to you!")] 
    public partial class JumbalayaItem : FoodItem
    {
        public override float Calories => 2800;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 23, Fat = 23, Protein = 29, Vitamins = 2 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
