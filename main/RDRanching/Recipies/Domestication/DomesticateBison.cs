namespace RD.Framework.main.RDRanching.Recipies.Domestication
{
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items.Animals.BabyAnimals;
    using RD.Framework.main.RDRanching.Items.obj;
    using RD.Framework.main.RDRanching.Items;


    [RequiresSkill(typeof(HuntingSkill), 3)]
    public partial class DomesticateBisonRecipe : RecipeFamily
    {
        public DomesticateBisonRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "DomesticateBison",
                displayName: Localizer.DoStr("Domesticate Bison"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BabyBisonItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 5, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CowItem>(1),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 10f; 
            this.LaborInCalories = CreateLaborInCaloriesValue(120, typeof(HuntingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(DomesticateBisonRecipe), start: 1.75f, skillType: typeof(HuntingSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Domesticate Bison"), recipeType: typeof(DomesticateBisonRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
