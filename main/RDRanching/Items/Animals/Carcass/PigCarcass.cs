
using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items.Animals.Carcass
{
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Slaughter Pig")] // Defines the localized name of the item.
    [Weight(500)] // Defines how heavy Board is.
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [Tag("Slaughter Pig")]
    [Tag("Pig Carcass")]
    [LocDescription("A Pig you can bread purely for meat production")] 
    public partial class PigCarcassItem : Item
    {
    }
}
