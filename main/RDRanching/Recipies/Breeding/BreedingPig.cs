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

namespace RD.Framework.main.RDRanching.Recipies.Breeding
{
    [RequiresSkill(typeof(HunterSkill), 3)]
    [Ecopedia("Items", "Animal", subPageName: "Pig")]
    public partial class PigRecipe : RecipeFamily
    {
        public PigRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Pig",
                displayName: Localizer.DoStr("Pig"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BabyAgoutiItem), 1, true),
                    new IngredientElement(typeof(BabyPrairieDogItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 3, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PigItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(HuntingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(PigRecipe), start: 5, skillType: typeof(HuntingSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Pig"), recipeType: typeof(PigRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
