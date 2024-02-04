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
using RD.Framework.main.RDRanching.Items;
using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
using RD.Framework.main.RDRanching.Items.obj;
using RD.Framework.main.RDSkills.Ranching;

namespace RD.Framework.main.RDRanching.Recipies.Breeding
{

    [RequiresSkill(typeof(RancherSkill), 1)]
    [Ecopedia("Items", "Products", subPageName: "Angus Cow")]
    public partial class AngusCowRecipe : RecipeFamily
    {
        public AngusCowRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "AngusCow",
                displayName: Localizer.DoStr("Angus Cow"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CowItem), 2, true),
                    new IngredientElement(typeof(AnimalFeedItem), 6, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<AngusCowItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5;

            LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));

            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AngusCowRecipe), start: 5.0f, skillType: typeof(RancherSkill));

            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Angus Cow"), recipeType: typeof(AngusCowRecipe));
            ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    public partial class DairyCowRecipe : RecipeFamily
    {
        public DairyCowRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "AngusCow",
                displayName: Localizer.DoStr("Angus Cow"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CowItem), 2, true),
                    new IngredientElement(typeof(AnimalFeedItem), 6, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<DairyCowItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5;

            LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));

            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(DairyCowRecipe), start: 5.0f, skillType: typeof(RancherSkill));

            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Angus Cow"), recipeType: typeof(DairyCowRecipe));
            ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
