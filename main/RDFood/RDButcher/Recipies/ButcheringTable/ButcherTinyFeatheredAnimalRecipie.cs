namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcheringTable
{
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDUtil.Items;

    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class ButcherTinyFurAnimalRecipe : RecipeFamily
    {
        public ButcherTinyFurAnimalRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ButcherTinyFeatheredAnimal",
                displayName: Localizer.DoStr("Butcher Tiny Feathered Animal"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("TinyFeatheredCarcass", 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawMeatItem>(1),
                    new CraftingElement<FeathersItem>(2),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2;
            this.LaborInCalories = CreateLaborInCaloriesValue(25, typeof(ButcherySkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherTinyFurAnimalRecipe), start: 0.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Butcher Tiny Feathered Animal"), recipeType: typeof(ButcherTinyFurAnimalRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
