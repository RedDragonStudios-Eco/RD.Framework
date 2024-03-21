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
    using RD.Framework.main.RDFood.RDCooking.Items.Meats;
    using RD.Framework.main.RDFood.RDRanching.Ingredients;

    [RequiresSkill(typeof(CookingSkill), 4)]
    [Ecopedia("Food", "RDFoods", subPageName: "Chicken Tenders")]
    public partial class ChickenTendersRecipe : RecipeFamily
    {
        public ChickenTendersRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ChickenTenders",
                displayName: Localizer.DoStr("Chicken Tenders"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawChickenTenderItem), 10, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(EggItem), 2, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement(typeof(FlourItem), 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement("Oil", 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ChickenTendersItem>(10)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f;
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ChickenTendersRecipe), start: 1f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Chicken Tenders"), recipeType: typeof(ChickenTendersRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
