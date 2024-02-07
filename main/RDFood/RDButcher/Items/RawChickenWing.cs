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
    [LocDisplayName("Raw Chicken Wings")] 
    [Weight(150)] 
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Fresh raw meat from a Chicken. It should definitly be cooked before being consumed.")]
    public partial class RawChickenWingItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Chicken Wings");
        public override float Calories => 250;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 1, Protein = 2, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
