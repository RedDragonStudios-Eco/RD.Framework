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
using Eco.Shared.Utils;

namespace RD.Framework.main.RDFood.RDCooking.Items.Ingredients
{
    [LocDisplayName("Butter")]
    [Weight(100)]
    [Tag("Fat")]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true)]
    [LocDescription("Made from the milk of a cow.")]
    public partial class ButterItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Butter");

        public override float Calories => 200;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 8, Protein = 0, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }

}
