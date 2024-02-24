namespace RD.Framework.main.RDRanching.Recipies.Domestication
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
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDRanching.Items;
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items.Animals.BabyAnimals;
    using RD.Framework.main.RDRanching.Items.obj;

    [RequiresSkill(typeof(HuntingSkill), 3)]
    [Ecopedia("Items", "Animal", subPageName: "Pig")]
    public partial class CrossBreedingPigRecipe : RecipeFamily
    {
        public CrossBreedingPigRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CrossBreedPig",
                displayName: Localizer.DoStr("CrossBreed Pig"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BabyAgoutiItem), 1, true),
                    new IngredientElement(typeof(BabyPrairieDogItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 5, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PigItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5;
            LaborInCalories = CreateLaborInCaloriesValue(120, typeof(HuntingSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CrossBreedingPigRecipe), start: 5, skillType: typeof(HuntingSkill));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("CrossBreed Pig"), recipeType: typeof(CrossBreedingPigRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
