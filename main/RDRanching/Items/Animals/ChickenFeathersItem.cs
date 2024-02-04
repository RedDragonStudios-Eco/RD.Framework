using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items.Animals
{
    [Serialized]
    [LocDisplayName("Chicken Feather")]
    [Weight(50)]
    [Ecopedia("Items", "Products", createAsSubPage: true)]
    [Tag("Chicken Carcass")]
    [Tag("Chicken Feathers")]
    [LocDescription("A By-Product of Butchering A Chicken")]
    public partial class ChickenFeathersItem : Item
    {
    }
}
