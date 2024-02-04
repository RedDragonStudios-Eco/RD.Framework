using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using RD.Framework.main.RDFood.RDButcher.Items;

namespace RD.Framework.main.RDFood.RDButcher.Recipies.PreparedMeats
{
    [RequiresSkill(typeof(ButcherySkill), 2)]
    public partial class RawChickenNuggetRecipe : RecipeFamily
    {
        public RawChickenNuggetRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PrepareRawChickenNugget",
                displayName: Localizer.DoStr("Prepare Raw Chicken Nugget"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawChickenBreastItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent))
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawChickenNuggetItem>(4)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RawChickenNuggetRecipe), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Raw Chicken Nugget"), recipeType: typeof(RawChickenNuggetRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
