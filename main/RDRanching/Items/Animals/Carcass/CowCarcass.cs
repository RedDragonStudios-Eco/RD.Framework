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
    [LocDisplayName("Angus Cow Carcass")] 
    [Weight(7500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Large Animal Carcass")]
    [LocDescription("A Dead Angus Cow.")] 
    public partial class AngusCowCarcassItem : Item
    {
    }

    [Serialized]
    [LocDisplayName("Dairy Cow Carcass")]
    [Weight(7500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Large Animal Carcass")]
    [LocDescription("A Dead Dariy Cow.")]
    public partial class DairyCowCarcassItem : Item
    {
    }
}
