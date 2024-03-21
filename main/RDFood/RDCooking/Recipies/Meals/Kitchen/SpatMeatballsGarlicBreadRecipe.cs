namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Kitchen
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDCooking.Items.Meals.CastIronStove;
    using RD.Framework.main.RDFood.RDCooking.Items.Meals.Kitchen;

    [RequiresSkill(typeof(CookingSkill), 5)]
    [Ecopedia("Food", "RDFoods", subPageName: "Spaghetti, Meatballs, and Garlic Bread")]
    public partial class SpaghettiMeatballsGarlicBreadRecipe : RecipeFamily
    {
        public SpaghettiMeatballsGarlicBreadRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SpaghettiMeatballsandGarlicBread",
                displayName: Localizer.DoStr("Spaghetti, Meatballs, and Garlic Bread"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SpaghettiandMeatballsItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(BreadItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(InfusedOilItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SpaghettiMeatballsAndGarlicBreadItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3f;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SpaghettiMeatballsGarlicBreadRecipe), start: 3.0f, skillType: typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Spaghetti, Meatballs, and Garlic Bread"), recipeType: typeof(SpaghettiMeatballsGarlicBreadRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(KitchenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
