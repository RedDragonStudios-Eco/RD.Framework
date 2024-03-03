namespace RD.Framework.main.RDFood.RDRanching.Recipies.IngredientRecipies
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
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items;
    using RD.Framework.main.RDSkills.Ranching;
    using RD.Framework.main.RDFood.RDRanching.Ingredients;
    using RD.Framework.main.RDRanching.Items.Objects;

    [RequiresSkill(typeof(RancherSkill), 3)]
    [Ecopedia("Food", "Ingredients", subPageName: "Egg")]
    public partial class ChickenLaysEggsRecipe : RecipeFamily
    {
        public ChickenLaysEggsRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ChickenLayingEggs",
                displayName: Localizer.DoStr("Chicken Laying Eggs"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ChickenItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 2, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<EggItem>(1),
                    new CraftingElement<ChickenItem>(1)
                });

            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ChickenLaysEggsRecipe), start: 2.0f, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Chicken Laying Eggs"), recipeType: typeof(ChickenLaysEggsRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
