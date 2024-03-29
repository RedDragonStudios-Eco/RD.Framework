﻿namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Stove
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;

    [Serialized]
    [LocDisplayName("Sea Urchin Pasta")] 
    [Weight(1)] 
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("We had to figure out something to do with urchins, and this is what we came up with! Enjoy!!")] 
    public partial class SeaUrchinPastaItem : FoodItem
    {
        public override float Calories => 1800;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 16, Fat = 27, Protein = 6, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
