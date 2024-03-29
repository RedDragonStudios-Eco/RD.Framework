namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.CastIronStove
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
    [LocDisplayName("Pulled Pork")] 
    [Weight(250)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Stringy and Fatty.")] 
    public partial class PulledPorkItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Pulled Pork");
        public override float Calories => 1000;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 8, Protein = 12, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}