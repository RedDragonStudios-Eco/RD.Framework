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
    [LocDisplayName("Slaughter Sheep")] 
    [Weight(3500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Slaughter Sheep")]
    [Tag("Sheep Carcass")]
    [LocDescription("A Dead Sheep Body")] 
    public partial class SheepCarcassItem : Item
    {
    }
}
