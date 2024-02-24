namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Campfire
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
    [LocDisplayName("Grilled Chicken")] 
    [Weight(250)]
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("Winner winner chicken dinner.")] 
    public partial class GrilledChickenItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Grilled Chicken");
        public override float Calories => 600;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 2, Protein = 8, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}