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

namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.CastIronStove
{

[Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Spaghetti and Meatballs")] // Defines the localized name of the item.
    [Weight(1)] // Defines how heavy the BakedBeans is.
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("Mom's Spaghetti")] //The tooltip description for the food item.
    public partial class SpaghettiandMeatballsItem : FoodItem
    {


        /// <summary>The amount of calories awarded for eating the food item.</summary>
        public override float Calories                  => 840;
        /// <summary>The nutritional value of the food item.</summary>
        public override Nutrients Nutrition             => new Nutrients() { Carbs = 15, Fat = 10, Protein = 13, Vitamins = 2};

        /// <summary>Defines the default time it takes for this item to spoil. This value can be modified by the inventory this item currently resides in.</summary>
        protected override float BaseShelfLife            => (float)TimeUtil.HoursToSeconds(72);
    }
}