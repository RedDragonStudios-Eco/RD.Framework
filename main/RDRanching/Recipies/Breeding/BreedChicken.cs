namespace RD.Framework.main.RDRanching.Recipies.Breeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDRanching.Items;
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items.obj;
    using RD.Framework.main.RDSkills.Ranching;

    [RequiresSkill(typeof(RancherSkill), 1)]
    [Ecopedia("Items", "Products", subPageName: "Breed Chicken")]
    public partial class BreedChickenRecipe : RecipeFamily
    {
        public BreedChickenRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BreedChicken",  //noloc
                displayName: Localizer.DoStr("Breed Chicken"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ChickenItem), 2, true),
                    new IngredientElement(typeof(AnimalFeedItem), 2, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ChickenItem>(3),
                });

            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BreedChickenRecipe), start: 0.5f, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Breed Chicken"), recipeType: typeof(BreedChickenRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
