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
    [LocDisplayName("Pig Carcass")] 
    [Weight(3500)] 
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Medium Carcass")]
    [Tag("Pig Carcass")]
    [LocDescription("A Dead Pig.")] 
    public partial class PigCarcassItem : Item
    {
    }
}
