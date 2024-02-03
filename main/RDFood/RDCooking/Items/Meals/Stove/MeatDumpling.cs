using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Stove
{
    [Serialized]
    [LocDisplayName("Meat & Dumplings")] 
    [Weight(1)] 
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("It's in the name. Just don't ask about what kind of meat it is!")] 
    public partial class MeatDumplingsItem : FoodItem
    {
        public override float Calories => 2800;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 37, Fat = 13, Protein = 9, Vitamins = 15 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
