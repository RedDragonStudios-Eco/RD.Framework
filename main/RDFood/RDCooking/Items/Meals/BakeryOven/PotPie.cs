namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.BakeryOven
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
    [LocDisplayName("Pot Pie")] 
    [Weight(1)] 
    [Ecopedia("Food", "Baked Food", createAsSubPage: true)]
    [LocDescription("A melody of vegtables and meat, baked in a savory pastry crust!")] 
    public partial class PotPieItem : FoodItem
    {
        public override float Calories => 1800;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 25, Fat = 8, Protein = 7, Vitamins = 19 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
