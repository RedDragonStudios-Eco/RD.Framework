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

namespace RD.Framework.main.RDRanching.Items.Animals.Carcass
{
    [Serialized] 
    [LocDisplayName("Chicken Carcass")] 
    [Weight(500)]
    [Ecopedia("Items", "Food", createAsSubPage: true)]
    [Tag("Chicken Carcass")]
    [Tag("Poultry")]
    [LocDescription("A Chicken you can bread purley for meat production")] 
    public partial class ChickenCarcassItem : Item
    {
    }
}
