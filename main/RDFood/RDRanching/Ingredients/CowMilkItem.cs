namespace RD.Framework.main.RDFood.RDRanching.Ingredients
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
    [LocDisplayName("Bucket of Milk")]
    [Weight(250)]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true)]
    [Tag("Milk")]
    [LocDescription("A Bucket of Rich & Creamy Milk, From a Dairy Cow")]
    public partial class CowMilkItem : Item
    {
    }
}
