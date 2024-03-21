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
    [LocDisplayName("Spaghetti and Meatballs")] 
    [Weight(1)] 
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("Mom's Spaghetti")] 
    public partial class SpaghettiandMeatballsItem : FoodItem
    {
        public override float Calories                  => 1000;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 15, Fat = 10, Protein = 13, Vitamins = 2};
        protected override float BaseShelfLife            => (float)TimeUtil.HoursToSeconds(72);
    }
}