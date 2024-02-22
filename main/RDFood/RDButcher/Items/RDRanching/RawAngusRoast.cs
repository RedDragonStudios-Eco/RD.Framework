namespace RD.Framework.main.RDFood.RDButcher.Items.RDFood
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
    [LocDisplayName("Raw Angus Roast")]
    [Weight(500)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Fresh raw roast from an Angus Cow. It should probably be cooked before being consumed.")]
    public partial class RawAngusRoastItem : FoodItem
    {

        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Angus Roasts");
        public override float Calories => 600;
        public override Nutrients Nutrition => new() { Carbs = 0, Fat = 4, Protein = 8, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
