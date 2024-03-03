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
    [LocDisplayName("Sheep Carcass")] 
    [Weight(3500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("MediumCarcass")]
    [Tag("MediumWoolyCarcass")]
    [LocDescription("A Dead Sheep.")] 
    public partial class SheepCarcassItem : Item
    {
    }
}
