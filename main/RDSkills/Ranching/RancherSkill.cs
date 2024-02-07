namespace RD.Framework.main.RDSkills.Ranching
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;

    [Serialized]
    [LocDisplayName("Rancher")]
    [Ecopedia("Professions", "Hunter", createAsSubPage: true)]
    [RequiresSkill(typeof(HunterSkill), 0), Tag("Hunter Specialty"), Tier(2)]
    [Tag("Specialty")]
    [Tag("Teachable")]
    public partial class RancherSkill : Skill
    {
        public LocString DisplayDescription { get { return Localizer.DoStr("Ranching Skill allows you to breed Farm Animals, Slaugter Animals, and Produce: Eggs, Milk, etc from them."); } }

        public override void OnLevelUp(User user)
        {
            user.Skillset.AddExperience(typeof(SelfImprovementSkill), 20, Localizer.DoStr("for leveling up another specialization."));
        }


        public static MultiplicativeStrategy MultiplicativeStrategy =
            new MultiplicativeStrategy(new float[] {
                1,
                1 - 0.5f,
                1 - 0.55f,
                1 - 0.6f,
                1 - 0.65f,
                1 - 0.7f,
                1 - 0.75f,
                1 - 0.8f,
            });
        public override MultiplicativeStrategy MultiStrategy => MultiplicativeStrategy;

        public static AdditiveStrategy AdditiveStrategy =
            new AdditiveStrategy(new float[] {
                0,
                0.5f,
                0.55f,
                0.6f,
                0.65f,
                0.7f,
                0.75f,
                0.8f,
            });
        public override AdditiveStrategy AddStrategy => AdditiveStrategy;
        public override int MaxLevel { get { return 7; } }
        public override int Tier { get { return 2; } }
    }

    [Serialized]
    [LocDisplayName("Rancher Skill Book")]
    [Ecopedia("Items", "Skill Books", createAsSubPage: true)]
    public partial class RancherSkillBook : SkillBook<RancherSkill, RancherSkillScroll> { }

    [Serialized]
    [LocDisplayName("Rancher Skill Scroll")]
    public partial class RancherSkillScroll : SkillScroll<RancherSkill, RancherSkillBook> { }


    [RequiresSkill(typeof(HuntingSkill), 3)]
    public partial class RancherSkillBookRecipe : RecipeFamily
    {
        public RancherSkillBookRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                "Rancher", 
                Localizer.DoStr("Rancher Skill Book"),
                new List<IngredientElement>
                {
                    new IngredientElement("FriedVegetable", 9, true),
                    new IngredientElement("CampfireSalad", 15, true),
                    new IngredientElement(typeof(PlantFibersItem), 60, true),
                    new IngredientElement("Raw Food", 45, true),
                },
                new List<CraftingElement>
                {
                    new CraftingElement<RancherSkillBook>()
                });
            Recipes = new List<Recipe> { recipe };
            LaborInCalories = CreateLaborInCaloriesValue(1000, typeof(HuntingSkill));
            CraftMinutes = CreateCraftTimeValue(typeof(RancherSkillBookRecipe), 5, typeof(HuntingSkill));
            ModsPreInitialize();
            Initialize(Localizer.DoStr("Rancher Skill Book"), typeof(RancherSkillBookRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(ResearchTableObject), this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}