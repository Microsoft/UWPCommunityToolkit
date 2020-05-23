﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.Toolkit.Uwp.UI.Media.Effects.Abstract
{
    /// <summary>
    /// An image based effect that loads an image at the specified location
    /// </summary>
    public abstract class ImageEffectBase : IPipelineEffect
    {
        /// <summary>
        /// Gets or sets the <see cref="System.Uri"/> for the image to load
        /// </summary>
        public Uri Uri { get; set; }

        /// <summary>
        /// Gets or sets the DPI mode used to render the image (the default is <see cref="Media.DpiMode.DisplayDpiWith96AsLowerBound"/>)
        /// </summary>
        public DpiMode DpiMode { get; set; } = DpiMode.DisplayDpiWith96AsLowerBound;

        /// <summary>
        /// Gets or sets the cache mode to use when loading the image (the default is <see cref="Media.CacheMode.Default"/>)
        /// </summary>
        public CacheMode CacheMode { get; set; } = CacheMode.Default;
    }
}
