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
using RD.Framework.main.RDRanching.Items.Animals.Carcass;
using RD.Framework.main.RDRanching.Items.obj;
using RD.Framework.main.RDSkills.Ranching;

namespace RD.Framework.main.RDRanching.Recipies.Slaughtery
{
    [RequiresSkill(typeof(RancherSkill), 4)]
    [Ecopedia("Items", "Products", subPageName: "Slaughter Chicken")]
    public partial class SlaughterChickenRecipe : RecipeFamily
    {
        public SlaughterChickenRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SlaughterChicken",  
                displayName: Localizer.DoStr("Slaughter Chicken"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ChickenItem), 1, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ChickenCarcassItem>(1)
                });

            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SlaughterChickenRecipe), start: 0.5f, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Slaughter Chicken"), recipeType: typeof(SlaughterChickenRecipe));
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
