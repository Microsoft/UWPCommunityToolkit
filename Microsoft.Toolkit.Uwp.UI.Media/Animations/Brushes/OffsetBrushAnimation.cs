﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Toolkit.Uwp.UI.Media;
using System.Numerics;
using Windows.UI.Composition;

namespace Microsoft.Toolkit.Uwp.UI.Animations
{
    /// <summary>
    /// An offset animation working on the composition layer.
    /// </summary>
    public sealed class OffsetBrushAnimation : EffectAnimation<SurfaceBrushFactory, string, Vector2>
    {
        /// <inheritdoc/>
        protected override string ExplicitTarget => nameof(CompositionSurfaceBrush.Offset);

        /// <inheritdoc/>
        protected override (Vector2?, Vector2?) GetParsedValues()
        {
            return (To?.ToVector2(), From?.ToVector2());
        }
    }
}