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

namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Kitchen
{
    [Serialized] 
    [LocDisplayName("Beef Stroganoff")] 
    [Weight(1)] 
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("Just because Beef is in the name, doesn't mean it's just a collection of red meat thrown in with mushrooms. Enjoy!")]
    public partial class BeefStroganoffItem : FoodItem
    {
        public override float Calories => 1500;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 15, Fat = 15, Protein = 20, Vitamins = 0 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
