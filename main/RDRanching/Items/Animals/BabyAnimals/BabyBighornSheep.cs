namespace RD.Framework.main.RDRanching.Items.Animals.BabyAnimals
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
    [LocDisplayName("Baby Bighorn Sheep")] 
    [Weight(1500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [LocDescription("A Baby Bighorn Sheep.")]
    public partial class BabyBighornSheepItem : Item
    {
    }
}
