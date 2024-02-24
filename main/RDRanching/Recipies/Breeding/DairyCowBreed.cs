namespace RD.Framework.main.RDRanching.Recipies.Breeding
{
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items.obj;
    using RD.Framework.main.RDRanching.Items;
    using RD.Framework.main.RDSkills.Ranching;
    using Eco.Core.Items;
    using Eco.Gameplay.Skills;

    [RequiresSkill(typeof(RancherSkill), 1)]
    [Ecopedia("Items", "Products", subPageName: "Dairy Cow")]
    public partial class DairyCowRecipe : RecipeFamily
    {
        public DairyCowRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BreedDairyCow",
                displayName: Localizer.DoStr("Breed Dairy Cow"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(CowItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 20, true),
                },
                items: new List<CraftingElement>
                { 
                    new CraftingElement<DairyCowItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5;

            LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));

            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(DairyCowRecipe), start: 5.0f, skillType: typeof(RancherSkill));

            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Breed Dairy Cow"), recipeType: typeof(DairyCowRecipe));
            ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
