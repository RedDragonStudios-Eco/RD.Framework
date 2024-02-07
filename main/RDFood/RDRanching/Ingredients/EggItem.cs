namespace RD.Framework.main.RDFood.RDRanching.Ingredients
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
    [LocDisplayName("Egg")]
    [Weight(10)]
    [Ecopedia("Food", "Items", createAsSubPage: true)]
    [LocDescription("An egg From a Chicken")]
    public partial class EggItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Eggs");
        public override float Calories => 50;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 0, Protein = 2, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);

    }
}
