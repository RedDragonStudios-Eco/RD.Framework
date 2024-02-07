namespace RD.Framework.main.RDRanching.Items.Animals.Carcass
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
    [LocDisplayName("Goat Carcass")] 
    [Weight(250)] 
    [Ecopedia("Items", "Food", createAsSubPage: true)]
    [Tag("Carcass")]
    [Tag("Goat Carcass")]
    [LocDescription("A Dead Goat")] 
    public partial class GoatCarcassItem : Item
    {


    }
}
