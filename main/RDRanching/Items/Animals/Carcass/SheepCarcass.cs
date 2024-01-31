using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items.Animals.Carcass
{
    [Serialized]
    [LocDisplayName("Slaughter Sheep")] 
    [Weight(3500)]
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Slaughter Sheep")]
    [Tag("Sheep Carcass")]
    [LocDescription("A Cow you can bread purley for meat production")] 
    public partial class SheepCarcassItem : Item
    {
    }
}
