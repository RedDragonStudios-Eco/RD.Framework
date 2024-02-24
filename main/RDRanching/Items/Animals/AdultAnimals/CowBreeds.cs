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
    [LocDisplayName("Cow")]
    [Weight(5500)]
    [Ecopedia("Animals", "Mammals", createAsSubPage: true)]
    [LocDescription("A Cow")]
    public partial class CowItem : Item
    {
    }

    [Serialized]
    [LocDisplayName("Angus Cow")]
    [Weight(8000)]
    [Ecopedia("Animals", "Mammals", subPageName: "Cow")]
    [Tag("Angus Cow")]
    [LocDescription("A Cow you can breed purely for butchery")]
    public partial class AngusCowItem : Item
    {
    }
    [Serialized]
    [LocDisplayName("Dairy Cow")]
    [Weight(8000)]
    [Ecopedia("Animals", "Mammals", subPageName: "Cow")]
    [Tag("Dairy Cow")]
    [LocDescription("A Cow you can breed purely for Dairy products")]
    public partial class DairyCowItem : Item
    {
    }
}
