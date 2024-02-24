namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.BakeryOven
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;

    [RequiresSkill(typeof(BakingSkill), 3)]
    public partial class BakedAngusRoastRecipe : Recipe
    {
        public BakedAngusRoastRecipe()
        {
            this.Init(
                name: "BakedAngusRoast",
                displayName: Localizer.DoStr("Baked Roast From Angus Roast"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawAngusRoastItem), 1, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BakedRoastItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(BakeryOvenObject), typeof(BakedRoastRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(BakingSkill), 3)]
    public partial class BakedPorkRoastRecipe : Recipe
    {
        public BakedPorkRoastRecipe()
        {
            this.Init(
                name: "BakedPorkRoast",
                displayName: Localizer.DoStr("Baked Roast From Pork Roast"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawPorkRoastItem), 1, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BakedRoastItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(BakeryOvenObject), typeof(BakedRoastRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}
