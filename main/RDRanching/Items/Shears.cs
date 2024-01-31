using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items
{
    [Serialized] 
    [LocDisplayName("Shears")] 
    [Weight(100)]
    [Ecopedia("Natural Resources", "Tools", createAsSubPage: true)]
    [LocDescription("Shears to Shear Sheep.")] 
    public partial class ShearItem : Item
    {
    }
}
