using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
using RD.Framework.main.RDRanching.Items.obj;
using RD.Framework.main.RDRanching.Items;
using RD.Framework.main.RDSkills.Ranching;
using RD.Framework.main.RDFood.Items.Foods.Ingredients;

namespace RD.Framework.main.RDFood.Recipies.IngredientRecipies
{
    [RequiresSkill(typeof(RancherSkill), 2)]
    [Ecopedia("Items", "Products", createAsSubPage: true)]
    public partial class MilkTheCowRecipe : RecipeFamily
    {
        public MilkTheCowRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Milking A Cow",
                displayName: Localizer.DoStr("Milking A Cow"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(DairyCowItem), 1, true),
                    new IngredientElement(typeof(BucketItem), 5, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CowMilkItem>(5)
                });

            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MilkTheCowRecipe), start: 5, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Milking A Cow"), recipeType: typeof(MilkTheCowRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
