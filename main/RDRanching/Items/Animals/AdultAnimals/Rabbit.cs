namespace RD.Framework.main.RDRanching.Items.Animals.AdultAnimals
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
    [LocDisplayName("Rabbit")]
    [Weight(1000)]
    [Ecopedia("Animals", "Mammals", createAsSubPage: true)]
    [LocDescription("A Rabbit")]
    public partial class RabbitItem : Item
    {
    }
}
