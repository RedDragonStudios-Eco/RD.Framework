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
    using RD.Framework.main.RDSkills.Ranching;
    using RD.Framework.main.RDRanching.Items.Objects;

    [RequiresSkill(typeof(RancherSkill), 1)]
    [Ecopedia("Items", "Products", subPageName: "Pig")]
    public partial class BreedPigRecipe : RecipeFamily
    {
        public BreedPigRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BreedPig",
                displayName: Localizer.DoStr("Breed Pig"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PigItem), 2, true),
                    new IngredientElement(typeof(AnimalFeedItem), 2, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PigItem>(3),
                });

            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5f;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BreedPigRecipe), start: 0.5f, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Breed Pig"), recipeType: typeof(BreedPigRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
