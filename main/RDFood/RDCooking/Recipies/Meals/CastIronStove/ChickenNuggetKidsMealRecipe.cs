namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.CastIronStove
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDButcher.Items.RDFood;
    using RD.Framework.main.RDFood.RDCooking.Items.Meals.CastIronStove;
    using RD.Framework.main.RDFood.RDRanching.Ingredients;

    [RequiresSkill(typeof(CookingSkill), 4)]
    [Ecopedia("Food", "RDFoods", subPageName: "Chicken Nuggets Kids Meal")]
    public partial class ChickenNugsKidsMealRecipe : RecipeFamily
    {
        public ChickenNugsKidsMealRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ChickenNuggetsKidsMeal",
                displayName: Localizer.DoStr("Chicken Nuggets Kids Meal"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawChickenNuggetItem), 10, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(EggItem), 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement("Oil", 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(TaroFriesItem), 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ChickenNuggetsKidsMealItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f;
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ChickenNugsKidsMealRecipe), start: 1f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Chicken Nuggets Kids Meal"), recipeType: typeof(ChickenNugsKidsMealRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
