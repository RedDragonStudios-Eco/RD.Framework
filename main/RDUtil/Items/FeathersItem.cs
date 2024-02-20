namespace RD.Framework.main.RDUtil.Items
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
    [LocDisplayName("Feathers")]
    [Weight(50)]
    [Ecopedia("Items", "Products", createAsSubPage: true)]
    [Tag("Feathers")]
    [LocDescription("A By-Product of Bird Carcasses")]
    public partial class FeathersItem : Item
    {
    }
}
