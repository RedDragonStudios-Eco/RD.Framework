namespace RD.Framework.main.RDFood.RDButcher.Recipies.PreparedMeats
{
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

    [RequiresSkill(typeof(ButcherySkill), 2)]
    public partial class RawMeatFromPorkRoastRecipe : RecipeFamily
    {
        public RawMeatFromPorkRoastRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PrepareRawMeatFromPorkRoast",
                displayName: Localizer.DoStr("Prepare Raw Meat From Pork Roast"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawPorkRoastItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent))
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawMeatItem>(2)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4;
            this.LaborInCalories = CreateLaborInCaloriesValue(15, typeof(ButcherySkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RawMeatFromPorkRoastRecipe), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Prepare Raw Meat From Pork Roast"), recipeType: typeof(RawMeatFromPorkRoastRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
