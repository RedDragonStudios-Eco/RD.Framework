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
    [LocDisplayName("Raw Mutton")] 
    [Weight(200)] 
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Fresh raw mutton from a sheep. It should probably be cooked before being consumed.")] 
    public partial class RawMuttonItem : FoodItem
    {

        
        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Mutton");
        public override float Calories => 150;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 3, Protein = 5, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
