﻿using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDRanching.Items
{
    [Serialized]
    [LocDisplayName("Animal Feed")]
    [LocDescription("Hunters And Ranchers Use Animal Feed, to Breed and Domesticate animals")]
    [Weight(250)]
    [Tag("Animal Feed")]
    [Ecopedia("Items", "Products", createAsSubPage: true)]
    public partial class AnimalFeedItem : Item
    {
    }

}
