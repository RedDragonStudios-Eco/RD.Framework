
namespace RD.Framework.main.RDFood.RDButcher.Items
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
    [LocDisplayName("Raw Beef Ribs")] 
    [Weight(500)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Fresh raw meat from an Angus Cow. It should probably be cooked before being consumed.")] //The tooltip description for the food item.
    public partial class RawBeefRibsItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Beef Ribs");
        public override float Calories => 600;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 8, Protein = 6, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
