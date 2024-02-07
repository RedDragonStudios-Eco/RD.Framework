
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
    [LocDisplayName("Raw Pork Chop")]
    [Weight(50)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Fresh raw chops' from a Pig. It should probably be cooked before being consumed.")]
    public partial class RawPorkChopItem : FoodItem
    {

        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Pork Chops");
        public override float Calories => 120;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 2, Protein = 3, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
