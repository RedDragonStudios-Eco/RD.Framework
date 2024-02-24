namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.CastIronStove
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
    [LocDisplayName("Meatball")]
    [Weight(50)]
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("A Meataball")] 
    public partial class MeatballItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Meatballs");
        public override float Calories => 50;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 8, Protein = 8, Vitamins = 0};
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}