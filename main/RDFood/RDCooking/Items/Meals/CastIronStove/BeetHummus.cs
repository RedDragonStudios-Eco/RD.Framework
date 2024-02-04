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

namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.CastIronStove
{
    [Serialized]
    [LocDisplayName("Beet Hummus")]
    [Weight(1)]
    [Ecopedia("Food", "Cooking", createAsSubPage: true)]
    [LocDescription("Who needs chickpeas when you have beets! The superfood with a touch of oil to make it really out of this world!")]
    public partial class BeetHummusItem : FoodItem
    {
        public override float Calories => 470;
        public override Nutrients Nutrition => new Nutrients() { Carbs = 3, Fat = 18, Protein = 0, Vitamins = 6 };
        protected override float BaseShelfLife => (float)TimeUtil.HoursToSeconds(72);
    }
}
