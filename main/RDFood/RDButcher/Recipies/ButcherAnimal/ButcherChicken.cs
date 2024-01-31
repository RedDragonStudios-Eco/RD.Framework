using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using RD.Framework.main.RDFood.RDButcher.Items;
using RD.Framework.main.RDRanching.Items.Animals;
using RD.Framework.main.RDRanching.Items.Animals.Carcass;

namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcherAnimal
{
    [RequiresSkill(typeof(ButcherySkill), 2)]
    public partial class ButcherChickenRecipie : RecipeFamily
    {
        public ButcherChickenRecipie()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ButcherChicken",
                displayName: Localizer.DoStr("Butcher Chicken"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ChickenCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawChickenBreastItem>(2),
                    new CraftingElement<RawChickenWingItem>(2),
                    new CraftingElement<ChickenFeathersItem>(5),
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherChickenRecipie), start: 1.25f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Butcher Chicken"), recipeType: typeof(ButcherChickenRecipie));
            ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
