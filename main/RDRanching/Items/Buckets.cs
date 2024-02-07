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
    [LocDisplayName("Bucket")] 
    [Weight(500)]
    [Ecopedia("Item", "Product", createAsSubPage: true)]
    [LocDescription("A Bucket to collect Milk.")]
    public partial class BucketItem : Item
    {
    }
}
