using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDFood.Items.Foods.Ingredients
{
    [Serialized]
    [LocDisplayName("Bucket of Goat's Milk")]
    [Weight(250)]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true)]
    [Tag("Goat Milk")]
    [Tag("Animal Milk")]
    [LocDescription("A Bucket of Rich & Creamy Milk, From a Goat")]
    public partial class GoatMilkItem : Item
    {
    }
}
