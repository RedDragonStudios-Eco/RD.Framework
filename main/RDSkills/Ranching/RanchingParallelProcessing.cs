using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDSkills.Ranching
{
    [Serialized]
    [LocDisplayName("Parallel Processing: Rancher")]
    public partial class RancherParallelProcessingTalentGroup : TalentGroup
    {
        public LocString DisplayDescription { get; } = Localizer.DoStr("Increases the crafting speed of related tables when they share a room with the same tables by 20 percent.");

        public RancherParallelProcessingTalentGroup()
        {
            Talents = new Type[]
            {
            typeof(RancherParallelSpeedTalent),
            };

            this.OwningSkill = typeof(RancherSkill);
            this.Level = 3;
        }
    }


    [Serialized]
    public partial class RancherParallelSpeedTalent : ParallelProcessingTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(RancherParallelProcessingTalentGroup); } }
        public RancherParallelSpeedTalent()
        {
            this.Value = 0.8f;
        }
    }
}
