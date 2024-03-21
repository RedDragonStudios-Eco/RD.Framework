namespace RD.Framework.main.RDFood.RDCooking.Items.Meats
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
    using Eco.Shared.Utils;

    [LocDisplayName("Ham")]
    [Weight(100)]
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("Cured Pork Butt Turned into a Ham")]
    public partial class HamItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Ham");

        public override float Calories => 1500;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 3, Fat = 7, Protein = 12, Vitamins = 5 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(110);
    }
}
