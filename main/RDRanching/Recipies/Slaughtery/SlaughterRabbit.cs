using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
using RD.Framework.main.RDRanching.Items.Animals.Carcass;
using RD.Framework.main.RDRanching.Items.obj;
using RD.Framework.main.RDSkills.Ranching;

namespace RD.Framework.main.RDRanching.Recipies.Slaughtery
{
    [RequiresSkill(typeof(RancherSkill), 3)]
    [Ecopedia("Items", "Products", subPageName: "Slaughter Rabbit")]
    public partial class SlaughterRabbitRecipe : RecipeFamily
    {
        public SlaughterRabbitRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SlaughterRabbit",  
                displayName: Localizer.DoStr("Slaughter Rabbit"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RabbitItem), 1, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RabbitCarcassItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SlaughterRabbitRecipe), start: 0.5f, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Slaughter Rabbit"), recipeType: typeof(SlaughterRabbitRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();

        partial void ModsPostInitialize();
    }
}
