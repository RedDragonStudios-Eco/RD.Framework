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
    [LocDisplayName("Pulled Pork Sandwich")] 
    [Weight(250)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Pulled pork and cheese on two slices of bread.")] 
    public partial class PulledPorkSandwichItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Pulled Pork Sandwich");
        public override float Calories => 2000;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 25, Fat = 24, Protein = 24, Vitamins = 2 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}