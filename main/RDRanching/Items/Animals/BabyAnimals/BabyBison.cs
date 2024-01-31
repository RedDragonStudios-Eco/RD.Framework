using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items.Animals.BabyAnimals
{
    [Serialized] // Tells the save/load system this object needs to be serialized. 
    [LocDisplayName("Baby Bison")] // Defines the localized name of the item.
    [Weight(2500)] // Defines how heavy BabyBison is.
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true)]
    [LocDescription("A baby bison.")] //The tooltip description for the item.
    public partial class BabyBisonItem : Item
    {


    }
}
