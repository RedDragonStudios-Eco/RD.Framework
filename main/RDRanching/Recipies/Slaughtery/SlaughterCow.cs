
namespace RD.Framework.main.RDRanching.Recipies.Slaughtery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items.Animals.Carcass;
    using RD.Framework.main.RDRanching.Items.obj;
    using RD.Framework.main.RDSkills.Ranching;

    [RequiresSkill(typeof(RancherSkill), 5)]
    [Ecopedia("Items", "Products", subPageName: "Slaughter Angus Cow")]
    public partial class SlaughterAngusCowRecipe : RecipeFamily
    {
        public SlaughterAngusCowRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SlaughterAngusCow",
                displayName: Localizer.DoStr("Slaughter Angus Cow"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(AngusCowItem), 1, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<AngusCowCarcassItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5;
            LaborInCalories = CreateLaborInCaloriesValue(100, typeof(RancherSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SlaughterAngusCowRecipe), start: 1.0f, skillType: typeof(RancherSkill));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Slaughter Angus Cow"), recipeType: typeof(SlaughterAngusCowRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(RancherSkill), 5)]
    [Ecopedia("Items", "Products", subPageName: "Slaughter Dairy Cow")]
    public partial class SlaughterDairyCowRecipe : RecipeFamily
    {
        public SlaughterDairyCowRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SlaughterDairyCow",
                displayName: Localizer.DoStr("Slaughter Dairy Cow"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(DairyCowItem), 1, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<DairyCowCarcassItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5; 
            LaborInCalories = CreateLaborInCaloriesValue(100, typeof(RancherSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SlaughterDairyCowRecipe), start: 2, skillType: typeof(RancherSkill));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Slaughter Dairy Cow"), recipeType: typeof(SlaughterDairyCowRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
