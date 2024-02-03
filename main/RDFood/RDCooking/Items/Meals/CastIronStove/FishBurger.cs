
using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.CastIronStove
{
    [Serialized] 
    [LocDisplayName("Fish Burger")] 
    [Weight(1)] 
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("Fish Burger, Please Enjoy!")] 
    public partial class FishBurgerItem : FoodItem
    {
        public override float Calories => 1800;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 12, Fat = 15, Protein = 18, Vitamins = 13 };
        protected override float BaseLivingTime => (float)TimeUtil.HoursToSeconds(72);
    }
}
