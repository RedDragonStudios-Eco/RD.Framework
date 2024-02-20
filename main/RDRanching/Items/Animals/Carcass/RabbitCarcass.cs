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
    [LocDisplayName("Slaughter Rabbit")]
    [Weight(100)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Slaughter Rabbit")]
    [Tag("Rabbit Carcass")]
    [LocDescription("A Dead Rabbit.")]
    public partial class RabbitCarcassItem : Item
    {
    }
}
