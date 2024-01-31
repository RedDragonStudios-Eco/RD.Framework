using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items.Animals.Carcass
{
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Goat Carcass")] // Defines the localized name of the item.
    [Weight(250)] // Defines how heavy Board is.
    [Ecopedia("Items", "Food", createAsSubPage: true)]
    [Tag("Carcass")]
    [Tag("Goat Carcass")]
    [LocDescription("A Cow you can bread purley for meat production")] //The tooltip description for the item.
    public partial class GoatCarcassItem : Item
    {


    }
}
