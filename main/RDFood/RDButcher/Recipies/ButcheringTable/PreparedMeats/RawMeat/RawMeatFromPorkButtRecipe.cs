namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcheringTable.PreparedMeats.RawMeat
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
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;
    using Eco.Core.Items;

    [RequiresSkill(typeof(ButcherySkill), 3)]
    public partial class RawMeatFromPorkButtRecipe : Recipe
    {
        public RawMeatFromPorkButtRecipe()
        {
            this.Init(
                name: "RawMeatFromPorkButt",
                displayName: Localizer.DoStr("Raw Meat From Pork Butt"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawPorkButtItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawMeatItem>(3),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(RawMeatFromRanchingRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}
