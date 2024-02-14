/**namespace RD.Framework.main.RDRanching.Items.Animals.AdultAnimals
{
    using Eco.Gameplay.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using RD.Framework.API.Helpers;
    using System.ComponentModel;

    [Serialized]
    [LocDisplayName("Test Animal")]
    [Weight(1)]
    [Category("Hidden")]
    [LocDescription("Testing Death Cycle of Animals")]
    public partial class TestAnimalItem : LivingItem
    {
        protected override float BaseLivingTime => (float)TimeUtil.HoursToSeconds(48);
    }
}*/
