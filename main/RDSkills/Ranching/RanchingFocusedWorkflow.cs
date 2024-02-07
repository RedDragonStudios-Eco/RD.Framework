namespace RD.Framework.main.RDSkills.Ranching
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;

    [Serialized]
    [LocDisplayName("Focused Workflow: Rancher")]
    public partial class RancherFocusedWorkflowTalentGroup : TalentGroup
    {
        public LocString DisplayDescription { get; } = Localizer.DoStr("Doubles the speed of related tables when alone.");

        public RancherFocusedWorkflowTalentGroup()
        {
            Talents = new Type[]
            {
            typeof(RancherFocusedSpeedTalent),
            };

            this.OwningSkill = typeof(RancherSkill);
            this.Level = 3;
        }
    }


    [Serialized]
    public partial class RancherFocusedSpeedTalent : FocusedWorkflowTalent
    {
        public override bool Base { get { return false; } }
        public override Type TalentGroupType { get { return typeof(RancherFocusedWorkflowTalentGroup); } }
        public RancherFocusedSpeedTalent()
        {
            this.Value = 0.5f;
        }
    }
}
