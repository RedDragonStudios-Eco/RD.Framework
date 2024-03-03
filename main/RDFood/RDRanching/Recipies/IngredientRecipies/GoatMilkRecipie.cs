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

    [RequiresSkill(typeof(RancherSkill), 4)]
    [Ecopedia("Food", "Ingredients", subPageName:"Goat's Milk")]
    public partial class MilkGoatRecipe : RecipeFamily
    {
        public MilkGoatRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Milking A Goat",
                displayName: Localizer.DoStr("Milking a Goat"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoatItem), 1, true),
                    new IngredientElement(typeof(BucketItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 3, true)
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GoatMilkItem>(1),
                    new CraftingElement<GoatItem>(1)
                });

            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5;
            LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MilkGoatRecipe), start: 2.0f, skillType: typeof(RancherSkill));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Milking a Goat"), recipeType: typeof(MilkGoatRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
