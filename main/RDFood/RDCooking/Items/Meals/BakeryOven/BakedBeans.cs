namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.BakeryOven
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
    [LocDisplayName("Baked Beans")]
    [Weight(1)]
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("Baked Beans in a savoury-sweet sauce with chopped Bacon. (Caution) Consumption May Lead to Excessive Amounts of Farting.")]
    public partial class BakedBeansItem : FoodItem
    {
        public override float Calories => 2100;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 6, Fat = 12, Protein = 8, Vitamins = 2 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
