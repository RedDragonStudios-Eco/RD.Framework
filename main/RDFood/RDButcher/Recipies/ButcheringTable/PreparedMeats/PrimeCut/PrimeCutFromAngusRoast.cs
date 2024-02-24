﻿namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcheringTable.PreparedMeats.PrimeCut
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

    [RequiresSkill(typeof(ButcherySkill), 6)]
    public partial class PrimeCutFromAngusRoastRecipe : Recipe
    {
        public PrimeCutFromAngusRoastRecipe()
        {
            this.Init(
                name: "PrimeCutAngusRoast",
                displayName: Localizer.DoStr("Prime Cut From Angus Roast"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawAngusRoastItem), 8, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PrimeCutItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(PrimeCutRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}
