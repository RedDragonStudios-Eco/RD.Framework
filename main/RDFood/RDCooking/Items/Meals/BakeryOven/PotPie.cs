using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.BakeryOven
{
    [Serialized] 
    [LocDisplayName("Pot Pie")] 
    [Weight(1)] 
    [Ecopedia("Food", "Baking", createAsSubPage: true)]
    [LocDescription("A melody of vegtables and meat, baked in a savory pastry crust!")] 
    public partial class PotPieItem : FoodItem
    {
        public override float Calories => 1800;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 25, Fat = 8, Protein = 7, Vitamins = 19 };
        protected override float BaseLivingTime => (float)TimeUtil.HoursToSeconds(72);
    }
}
