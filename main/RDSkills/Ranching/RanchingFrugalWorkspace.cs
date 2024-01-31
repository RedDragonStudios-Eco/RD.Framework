
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDSkills.Ranching
{
    [Serialized]
    [LocDisplayName("Frugal Workspace: Rancher")]
    public class RancherFrugalWorkspaceTalentGroup : TalentGroup
    {
        public LocString DisplayDescription { get; } = Localizer.DoStr("Lowers the tier requirement of related tables by 0.2");
        public RancherFrugalWorkspaceTalentGroup()
        {
            this.Talents = new Type[1]
            {
        typeof (RancherFrugalReqTalent)
            };
            this.OwningSkill = typeof(RancherSkill);
            this.Level = 6;
        }
    }

    [Serialized]
    public class RancherFrugalReqTalent : FrugalWorkspaceTalent
    {
        public override bool Base
        {
            get
            {
                return false;
            }
        }

        public override Type TalentGroupType
        {
            get
            {
                return typeof(RancherFrugalWorkspaceTalentGroup);
            }
        }

        public RancherFrugalReqTalent()
        {
            this.Value = -0.2f;
        }
    }
}
