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
    using RD.Framework.main.RDRanching.Items.obj;
    using RD.Framework.main.RDRanching.Items;
    using RD.Framework.main.RDSkills.Ranching;
    using RD.Framework.main.RDFood.RDRanching.Ingredients;

    [RequiresSkill(typeof(RancherSkill), 2)]
    [Ecopedia("Food", "Ingredients", subPageName: "Dairy Milk")]
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
                    new IngredientElement(typeof(BucketItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 5, true)
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CowMilkItem>(1),
                    new CraftingElement<CowItem>(1)
                });

            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5;
            LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MilkTheCowRecipe), start: 5.0f, skillType: typeof(RancherSkill));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Milking A Cow"), recipeType: typeof(MilkTheCowRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
