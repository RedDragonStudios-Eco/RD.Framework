namespace RD.Framework.main.RDRanching.Items.Animals.Carcass
{
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

    [Serialized]
    [LocDisplayName("Slaughter Pig")] 
    [Weight(3500)] 
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Slaughter Pig")]
    [Tag("Pig Carcass")]
    [LocDescription("A Pig you can bread purely for meat production")] 
    public partial class PigCarcassItem : Item
    {
    }
}
