
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDSkills.Ranching
{
    [Serialized]
    [LocDisplayName("Lavish Workspace: Rancher")]
    public partial class RancherLavishWorkspaceTalentGroup : TalentGroup
    {
        public LocString DisplayDescription { get; } = Localizer.DoStr("Increases the tier requirement of tables by 0.2, but reduces the resources needed by 5 percent.");
        public RancherLavishWorkspaceTalentGroup()
        {
            Talents = new Type[]
            {
            typeof(RancherLavishResourcesTalent),
            typeof(RancherLavishReqTalent),
            };

            this.OwningSkill = typeof(RancherSkill);
            this.Level = 6;
        }
    }


    [Serialized]
    public partial class RancherLavishResourcesTalent : LavishWorkspaceTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(RancherLavishWorkspaceTalentGroup); } }
        public RancherLavishResourcesTalent()
        {
            this.Value = 0.95f;
        }
    }

    [Serialized]
    public partial class RancherLavishReqTalent : LavishWorkspaceTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(RancherLavishWorkspaceTalentGroup); } }
        public RancherLavishReqTalent()
        {
            this.Value = 0.2f;
        }
    }
}
