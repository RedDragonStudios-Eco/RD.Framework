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

    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Meatball")] // Defines the localized name of the item.
    [Weight(1)] // Defines how heavy the BakedBeans is.
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("That's a spicy meataball!")] 
    public partial class MeatballItem : FoodItem
    {
        public override float Calories                  => 300;
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 0, Fat = 9, Protein = 13, Vitamins = 0};
        protected override float BaseShelfLife            => (float)TimeUtil.HoursToSeconds(72);
    }
}