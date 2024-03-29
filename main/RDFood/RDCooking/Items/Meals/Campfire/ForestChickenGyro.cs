﻿namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Campfire
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
    [LocDisplayName("Forest Chicken Gyro")]
    [Weight(250)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Gyro or Gyro?.")]
    public partial class ForestChickenGyroItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Forest Chicken Gyro");
        public override float Calories => 1550;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 17, Fat = 8, Protein = 12, Vitamins = 5 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
