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
    [LocDisplayName("Chicken Carcass")] 
    [Weight(500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Chicken Carcass")]
    [Tag("Poultry")]
    [LocDescription("A Dead Chicken")] 
    public partial class ChickenCarcassItem : Item
    {
    }
}
