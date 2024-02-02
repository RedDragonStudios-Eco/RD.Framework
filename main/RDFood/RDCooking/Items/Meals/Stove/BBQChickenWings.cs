
using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Stove
{
    [Serialized] 
    [LocDisplayName("BBQ Chicken Wing")] 
    [Weight(1)] 
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("Some Good Ole Tasty Chicken Wings")] 
    public partial class BBQChickenWingItem : FoodItem
    {
        public override float Calories => 470;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 16, Protein = 3, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
