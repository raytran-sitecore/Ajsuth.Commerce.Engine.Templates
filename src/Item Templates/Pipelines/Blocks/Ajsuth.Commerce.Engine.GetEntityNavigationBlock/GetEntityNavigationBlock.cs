﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="$safeitemname$.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-$year$
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace $rootnamespace$
{
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.EntityViews;
    using Sitecore.Framework.Conditions;
    using Sitecore.Framework.Pipelines;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a get navigation view pipeline block
    /// </summary>
    /// <seealso>
    ///     <cref>
    ///         Sitecore.Framework.Pipelines.PipelineBlock{Sitecore.Commerce.EntityViews.EntityView,
    ///         Sitecore.Commerce.EntityViews.EntityView, Sitecore.Commerce.Core.CommercePipelineExecutionContext}
    ///     </cref>
    /// </seealso>
    [PipelineDisplayName("Change to <Project>Constants.Pipelines.Blocks.Get$entity$NavigationView")]
    public class $safeitemname$ : PipelineBlock<EntityView, EntityView, CommercePipelineExecutionContext>
    {
        /// <inheritdoc />
        /// <summary>Initializes a new instance of the <see cref="T:$rootnamespace$.$safeitemname$" /> class.</summary>
        public $safeitemname$()
            : base(null)
        {
        }

        /// <summary>
        /// The execute.
        /// </summary>
        /// <param name="entityView">
        /// The current <see cref="Sitecore.Commerce.EntityViews.EntityView"/>.
        /// </param>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The current <see cref="Sitecore.Commerce.EntityViews.EntityView"/>.
        /// </returns>
        public override Task<EntityView> Run(EntityView entityView, CommercePipelineExecutionContext context)
        {
            Condition.Requires(entityView).IsNotNull($"{Name}: The argument cannot be null.");

            var dashboardName = context.GetPolicy<Known$entity$ViewsPolicy>().$entity$Dashboard;

            entityView.ChildViews.Add(new EntityView
            {
                Name = dashboardName,
                ItemId = dashboardName,
                Icon = "about",
                DisplayRank = 100
            });

            return Task.FromResult(entityView);
        }
    }
}