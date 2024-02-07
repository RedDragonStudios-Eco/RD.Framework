
namespace RD.Framework.main.RDFood.RDCooking.Items.Meals.BakeryOven
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
    using RD.Framework.main.RDFood.RDCooking.Items.Meals.Bakery_Oven;

    [RequiresSkill(typeof(BakingSkill), 2)]
    [Ecopedia("Food", "Baking", subPageName: "Baked Beans Item")]
    public partial class BakedBeansRecipe : RecipeFamily
    {
        public BakedBeansRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BakedBeans",
                displayName: Localizer.DoStr("Baked Beans"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(RawBaconItem), 5, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                   new IngredientElement(typeof(BeansItem), 20, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                   new IngredientElement(typeof(TomatoItem), 10, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BakedBeansItem>(2)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3;
            this.LaborInCalories = CreateLaborInCaloriesValue(45, typeof(BakingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BakedBeansRecipe), start: 2.0f, skillType: typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Baked Beans"), recipeType: typeof(BakedBeansRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BakeryOvenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
