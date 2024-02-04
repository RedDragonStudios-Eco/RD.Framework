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

namespace RD.Framework.main.RDFood.RDButcher.Items
{
    [Serialized] 
    [LocDisplayName("Raw Rabbit Meat")] 
    [Weight(150)] 
    [Ecopedia("Food", "Raw Meat", createAsSubPage: true)]
    [LocDescription("Fresh raw rabbit meat. It should probably be cooked before being consumed.")] 
    public partial class RawRabbitMeatItem : FoodItem
    {
        public override LocString DisplayNamePlural => Localizer.DoStr("Raw Rabbit Meat");
        public override float Calories => 125;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 0, Fat = 1, Protein = 2, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(96);
    }
}
