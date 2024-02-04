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

namespace RD.Framework.main.RDRanching.Items.Animals.Carcass
{
    [Serialized] 
    [LocDisplayName("Angus Cow Carcass")] 
    [Weight(7500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [LocDescription("A Cow Body.")] 
    public partial class AngusCowCarcassItem : Item
    {
    }

    [Serialized]
    [LocDisplayName("Dairy Cow Carcass")]
    [Weight(7500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [LocDescription("A Cow Body.")]
    public partial class DairyCowCarcassItem : Item
    {
    }
}
