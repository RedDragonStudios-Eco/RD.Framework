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
    [LocDisplayName("Pig")] 
    [Weight(4000)] 
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Pig")]
    [Tag("Pig")]
    [LocDescription("A Pig you can breed purely for meat production")] 
    public partial class PigItem : Item
    {


    }
}
