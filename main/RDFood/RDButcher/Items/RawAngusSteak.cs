using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

namespace RD.Framework.main.RDFood.RDButcher.Items
{
    [Serialized] 
    [LocDisplayName("Raw Angus Steak")]
    [Weight(500)] 
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Fresh raw steak From an Angus Cow. It should probably be cooked before being consumed.")] 
    public partial class RawAngusSteakItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Angus Steaks");
        public override float Calories => 600;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 3, Protein = 9, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
