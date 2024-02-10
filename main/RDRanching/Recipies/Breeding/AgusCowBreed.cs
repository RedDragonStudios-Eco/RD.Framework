namespace RD.Framework.main.RDRanching.Recipies.Breeding
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items.obj;
    using RD.Framework.main.RDRanching.Items;
    using RD.Framework.main.RDSkills.Ranching;

    [RequiresSkill(typeof(RancherSkill), 1)]
    [Ecopedia("Items", "Products", subPageName: "Angu Cow")]
    public partial class AngusCowRecipe : RecipeFamily
    {
        public AngusCowRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "AngusCow",
                displayName: Localizer.DoStr("Angus Cow"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CowItem), 2, true),
                    new IngredientElement(typeof(AnimalFeedItem), 6, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<AngusCowItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5f;

            LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));

            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AngusCowRecipe), start: 5.0f, skillType: typeof(RancherSkill));

            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Angus Cow"), recipeType: typeof(AngusCowRecipe));
            ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
