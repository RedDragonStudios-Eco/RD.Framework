namespace RD.Framework.main.RDFood.RDButcher.Items.RDFood
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
    [LocDisplayName("Raw Chicken Tender")]
    [Weight(125)]
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Prepared Raw Chicken Tenders. It should definitly be cooked before being consumed.")]
    public partial class RawChickenTenderItem : FoodItem
    {

        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Chicken Tenders");
        public override float Calories => 150;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 2, Protein = 5, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
