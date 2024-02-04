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

namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.Stove
{
    [Serialized] 
    [LocDisplayName("Beet Falafel")] 
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("A collection of colors that realy shout 'I have all the carbs and fat your desire'!")] 
    public partial class BeetFalafelItem : FoodItem
    {
        public override float Calories => 1500;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 39, Fat = 39, Protein = 13, Vitamins = 12 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
