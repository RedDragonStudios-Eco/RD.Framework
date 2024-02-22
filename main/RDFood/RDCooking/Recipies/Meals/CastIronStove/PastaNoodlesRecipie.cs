namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.CastIronStove
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDCooking.Items.Ingredients;
    using RD.Framework.main.RDFood.RDCooking.Items.Ingredients.CastIronStove;
    [RequiresSkill(typeof(CookingSkill), 3)]
    [Ecopedia("Food", "RDFoods", subPageName: "Pasta Noodle")]
    public partial class PastaNoodleRecipe : RecipeFamily
    {
        public PastaNoodleRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PastaNoodle",
                displayName: Localizer.DoStr("Pasta Noodle"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(PastaDoughItem), 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PastaNoodleItem>(4)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2f;
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(PastaNoodleRecipe), start: 1.0f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Pasta Noodle"), recipeType: typeof(PastaNoodleRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
