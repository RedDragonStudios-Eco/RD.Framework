using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD.Framework.main.RDFood.RDCooking.Recipies.Ingredients
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDCooking.Items.Ingredients;
    using RD.Framework.main.RDFood.RDRanching.Ingredients;

    [RequiresSkill(typeof(CookingSkill), 3)]
    [Ecopedia("Food", "RDFoods", subPageName: "Pasta Dough")]
    public partial class PastaDoughRecipe : RecipeFamily
    {
        public PastaDoughRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PastaDough",
                displayName: Localizer.DoStr("Pasta Dough"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(EggItem), 3, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(FlourItem), 4, typeof(CookingSkill), typeof(CookingLavishResourcesTalent))
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PastaDoughItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 2f;
            LaborInCalories = CreateLaborInCaloriesValue(30, typeof(CookingSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(PastaDoughRecipe), start: 1.2f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Pasta Dough"), recipeType: typeof(PastaDoughRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(KitchenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
