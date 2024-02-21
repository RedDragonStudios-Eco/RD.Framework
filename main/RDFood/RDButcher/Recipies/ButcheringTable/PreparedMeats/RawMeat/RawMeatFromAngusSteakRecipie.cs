namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcheringTable.PreparedMeats.RawMeat
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
    public partial class RawMeatFromAngusSteakRecipe : RecipeFamily
    {
        public RawMeatFromAngusSteakRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PrepareRawMeatFromAngusSteak",
                displayName: Localizer.DoStr("Prepare Raw Meat From Angus Steak"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawAngusSteakItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent))
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawMeatItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(15, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RawMeatFromAngusSteakRecipe), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Prepare Raw Meat From Angus Steak"), recipeType: typeof(RawMeatFromAngusSteakRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
