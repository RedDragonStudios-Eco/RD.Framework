using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items
{
    [Serialized]
    [LocDisplayName("Bucket")] 
    [Weight(500)]
    [Ecopedia("Item", "Product", createAsSubPage: true)]
    [LocDescription("A Bucket to collect Milk.")]
    public partial class BucketItem : Item
    {
    }
}
