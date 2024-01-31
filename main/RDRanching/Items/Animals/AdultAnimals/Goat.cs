using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items.Animals.AdultAnimals
{
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Goat")] // Defines the localized name of the item.
    [Weight(250)] // Defines how heavy BabyBison is.
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [LocDescription("A Goat")] //The tooltip description for the item.
    public partial class GoatItem : Item
    {


    }
}
