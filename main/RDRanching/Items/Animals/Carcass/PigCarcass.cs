﻿
using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items.Animals.Carcass
{
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