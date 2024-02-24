namespace RD.Framework.main.RDFood.RDButcher.Items.RDRanching
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
    [LocDisplayName("Raw Pork Roast")]
    [Weight(250)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Fresh raw roast from a Pig. It should probably be cooked before being consumed.")]
    public partial class RawPorkRoastItem : FoodItem
    {

        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Pork Roasts");
        public override float Calories => 600;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 2, Protein = 6, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
