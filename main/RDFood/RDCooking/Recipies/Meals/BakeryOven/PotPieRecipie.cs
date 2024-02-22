namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.BakeryOven
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
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDCooking.Items.Meals.BakeryOven;

    [RequiresSkill(typeof(BakingSkill), 3)]
    [Ecopedia("Food", "RDFoods", subPageName: "Pot Pie Item")]
    public partial class PotPieRecipe : RecipeFamily
    {
        public PotPieRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PotPie",
                displayName: Localizer.DoStr("Pot Pie"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(VegetableStockItem), 2, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                   new IngredientElement(typeof(PastryDoughItem), 3, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                   new IngredientElement(typeof(PreparedMeatItem), 5, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                   new IngredientElement(typeof(CornItem), 5, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                   new IngredientElement(typeof(TaroRootItem), 10, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PotPieItem>(3)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(45, typeof(BakingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(PotPieRecipe), start: 2.0f, skillType: typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Pot Pie"), recipeType: typeof(PotPieRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BakeryOvenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
