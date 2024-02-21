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
    [LocDisplayName("Baby Mountain Goat")]
    [Weight(1000)] 
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Baby Animals")]
    [LocDescription("A Baby Mountain Goat.")]
    public partial class BabyMountainGoatItem : Item
    {


    }
}
