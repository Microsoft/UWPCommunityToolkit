// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Microsoft.Toolkit.Uwp.UI.Media.Effects;
using Microsoft.Toolkit.Uwp.UI.Media.Pipelines;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Microsoft.Toolkit.Uwp.UI.Media
{
    /// <summary>
    /// A builder type for <see cref="Windows.UI.Composition.SpriteVisual"/> instance to apply to UI elements.
    /// </summary>
    [ContentProperty(Name = nameof(Effects))]
    public sealed class PipelineVisualFactory : PipelineVisualFactoryBase
    {
        /// <summary>
        /// Gets or sets the source for the current pipeline (defaults to a <see cref="BackdropSourceExtension"/> with <see cref="AcrylicBackgroundSource.Backdrop"/> source).
        /// </summary>
        public PipelineBuilder Source { get; set; }

        /// <summary>
        /// Gets or sets the collection of effects to use in the current pipeline.
        /// </summary>
        public IList<IPipelineEffect> Effects { get; set; } = new List<IPipelineEffect>();

        /// <inheritdoc/>
        protected override PipelineBuilder OnPipelineRequested()
        {
            PipelineBuilder builder = Source ?? PipelineBuilder.FromBackdrop();

            foreach (IPipelineEffect effect in Effects)
            {
                builder = effect.AppendToPipeline(builder);
            }

            return builder;
        }
    }
}