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

namespace RD.Framework.main.RDRanching.Items.Animals.AdultAnimals
{
    [Serialized] 
    [LocDisplayName("Chicken")] 
    [Weight(1500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [LocDescription("A Chicken")] 
    public partial class ChickenItem : Item
    {
    }
}
