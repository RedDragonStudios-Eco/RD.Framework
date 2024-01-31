using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using RD.Framework.main.RDFood.Items.Foods.Ingredients;
using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
using RD.Framework.main.RDRanching.Items.obj;
using RD.Framework.main.RDRanching.Items;
using RD.Framework.main.RDSkills.Ranching;

namespace RD.Framework.main.RDRanching.Recipies
{
    [RequiresSkill(typeof(RancherSkill), 4)]
    [Ecopedia("Items", "Products", subPageName: "Milk Goat")]
    public partial class MilkGoatRecipe : RecipeFamily
    {
        public MilkGoatRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MilkGoat",
                displayName: Localizer.DoStr("Milk Goat"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoatItem), 1, true),
                    new IngredientElement(typeof(BucketItem), 3, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GoatMilkItem>(3)
                });

            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5; 
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));

            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MilkGoatRecipe), start: 2, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Milk Goat"), recipeType: typeof(MilkGoatRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
