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

    [RequiresSkill(typeof(RancherSkill), 2)]
    [Ecopedia("Items", "Products", subPageName: "Breed Sheep")]
    public partial class BreedSheepRecipe : RecipeFamily
    {
        public BreedSheepRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BreedSheep", 
                displayName: Localizer.DoStr("Breed Sheep"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SheepItem), 2, true),
                    new IngredientElement(typeof(AnimalFeedItem), 6, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SheepItem>(3)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BreedSheepRecipe), start: 5.0f, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Breed Sheep"), recipeType: typeof(BreedSheepRecipe));
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
