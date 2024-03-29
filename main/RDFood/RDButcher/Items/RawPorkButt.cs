﻿
namespace RD.Framework.main.RDFood.RDButcher.Items
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
    [LocDisplayName("Raw Pork Butt")]
    [Weight(250)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Fresh raw ham from a Pig. It should probably be Cured and Cooked before being consumed.")]
    public partial class RawPorkButtItem : FoodItem
    {

        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Pork Butt");
        public override float Calories => 500;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 4, Protein = 10, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
