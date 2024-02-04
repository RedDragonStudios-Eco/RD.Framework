using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using RD.Framework.main.RDFood.RDCooking.Items.Ingredients;
using RD.Framework.main.RDFood.RDRanching.Ingredients;
using RD.Framework.main.RDFood.RDRanching.Objects;
using RD.Framework.main.RDSkills.Ranching;

namespace RD.Framework.main.RDFood.RDRanching.Recipies.IngredientRecipies
{
    [RequiresSkill(typeof(RancherSkill), 4)]
    public partial class ChurnButterRecipe : RecipeFamily
    {
        public ChurnButterRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ChurnButter",
                displayName: Localizer.DoStr("Churn Butter"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CowMilkItem), 1, typeof(RancherSkill), typeof(RancherLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ButterItem>(4),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ChurnButterRecipe), start: 0.8f, skillType: typeof(RancherSkill), typeof(RancherFocusedSpeedTalent), typeof(RancherParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Churn Butter"), recipeType: typeof(ChurnButterRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButterChurnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
