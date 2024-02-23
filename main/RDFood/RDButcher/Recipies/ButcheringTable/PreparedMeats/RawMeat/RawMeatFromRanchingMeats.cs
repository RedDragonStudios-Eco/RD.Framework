namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcheringTable.PreparedMeats.RawMeat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;
    using Eco.Gameplay.Components;
    using Eco.Core.Items;

    [RequiresSkill(typeof(ButcherySkill), 3)]
    [Ecopedia("Food", "Raw Meat", subPageName:"RawMeat")]
    public partial class RawMeatFromRanchingRecipe : RecipeFamily
    {
        public RawMeatFromRanchingRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PrepareRawMeatRanchingMeats",
                displayName: Localizer.DoStr("Prepare Raw Meat From Ranching Meats"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawAngusSteakItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent))
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawMeatItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 0.1f;
            LaborInCalories = CreateLaborInCaloriesValue(15, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RawMeatFromRanchingRecipe), start: 0.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Prepare Raw Meat From Ranching Meats"), recipeType: typeof(RawMeatFromRanchingRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
