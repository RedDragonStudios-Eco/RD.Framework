namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Stove
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Core.Items;
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;
    using RD.Framework.main.RDFood.RDRanching.Ingredients;

    [RequiresSkill(typeof(AdvancedCookingSkill), 2)]
    public partial class FriendHareHaunchesFromRabbitRecipe : Recipe
    {
        public FriendHareHaunchesFromRabbitRecipe()
        {
            this.Init(
                name: "FriedHareHaunchesFromRabbitMeat",
                displayName: Localizer.DoStr("Fried Hare Haunches From Rabbit Meat"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawRabbitMeatItem), 10, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                    new IngredientElement(typeof(FlourItem), 4, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                    new IngredientElement("Oil", 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                    new IngredientElement(typeof(EggItem), 4, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FriedHareHaunchesItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(StoveObject), typeof(FriedHareHaunchesRecipe), this);
        }
        partial void ModsPostInitialize();
    }
} 
