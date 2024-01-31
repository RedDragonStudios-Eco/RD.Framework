using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items
{
    [Serialized] 
    [LocDisplayName("Hay Bale")] 
    [Weight(250)] 
    [Fuel(20000)]
    [Tag("Bedding")] 
    [Ecopedia("Items", "Products", createAsSubPage: true)]
    [Tag("Bale")]
    [LocDescription("A bale that can be used in the barn for bedding.")] 
    public partial class HayBaleItem : Item
    {
    }
}
