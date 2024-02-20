namespace RD.Framework.main.RDRanching.Items
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;

    [Serialized] 
    [LocDisplayName("Shears")] 
    [Weight(100)]
    [Ecopedia("Items", "Tools", createAsSubPage: true)]
    [LocDescription("Shears to Shear Sheep.")] 
    public partial class ShearItem : Item
    {
    }
}
