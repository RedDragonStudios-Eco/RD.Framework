using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using RD.Framework.main.RDFood.RDButcher.Items;
using RD.Framework.main.RDRanching.Items.Animals.Carcass;

namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcherAnimal
{
    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class RawRabbitRecipe : RecipeFamily
    {
        public RawRabbitRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ButcherRabbit",
                displayName: Localizer.DoStr("Butcher A Rabbit"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RabbitCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawRabbitMeatItem>(5),
                    new CraftingElement<FurPeltItem>(2),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RawRabbitRecipe), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Butcher A Rabbit"), recipeType: typeof(RawRabbitRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
