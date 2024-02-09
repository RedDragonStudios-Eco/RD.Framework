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
    [LocDisplayName("Falafel")] // Defines the localized name of the item.
    [Weight(1)]
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("A simple combination of Beans, herbs, spices, blended together and shaped into balls.")] 
    public partial class FalafelItem : FoodItem
    {
        public override float Calories => 600;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 16, Fat = 18, Protein = 4, Vitamins = 0 };

        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
