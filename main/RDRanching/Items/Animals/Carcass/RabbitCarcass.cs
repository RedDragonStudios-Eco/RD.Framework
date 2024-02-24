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
    [LocDisplayName("Rabbit Carcass")]
    [Weight(750)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("TinyCarcass")]
    [Tag("TinyFurCarcass")]
    [LocDescription("A Dead Rabbit.")]
    public partial class RabbitCarcassItem : Item
    {
    }
}
