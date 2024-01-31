using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items.Animals.AdultAnimals
{
    [Serialized]
    [LocDisplayName("Cow")]
    [Weight(5500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [LocDescription("A Cow")]
    public partial class CowItem : Item
    {
    }

    [Serialized]
    [LocDisplayName("Angus Cow")]
    [Weight(8000)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Angus Cow")]
    [LocDescription("A Cow you can breed purely for butchery")]
    public partial class AngusCowItem : Item
    {
    }
    [Serialized]
    [LocDisplayName("Dairy Cow")]
    [Weight(8000)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Dairy Cow")]
    [Tag("Dairy Cow")]
    [LocDescription("A Cow you can breed purely for Dairy products")]
    public partial class DairyCowItem : Item
    {
    }
}
