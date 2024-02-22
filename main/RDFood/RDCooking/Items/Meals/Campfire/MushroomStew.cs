namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Campfire
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
    [LocDisplayName("Mushroom Stew")] 
    [Weight(250)]
    [Ecopedia("Food", "RDFoods", createAsSubPage: true)]
    [LocDescription("Vegan stew alternative.")] 
    public partial class MushroomStewItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Mushroom Stew");
        public override float Calories => 950;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 8, Fat = 10, Protein = 9, Vitamins = 9 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}