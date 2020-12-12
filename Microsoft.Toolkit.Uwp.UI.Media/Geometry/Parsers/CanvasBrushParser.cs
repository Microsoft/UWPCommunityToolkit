﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Brushes;
using Microsoft.Toolkit.Uwp.UI.Media.Geometry.Core;
using Microsoft.Toolkit.Uwp.UI.Media.Geometry.Elements.Brush;

namespace Microsoft.Toolkit.Uwp.UI.Media.Geometry.Parsers
{
    /// <summary>
    /// Parser for ICanvasBrush
    /// </summary>
    internal static class CanvasBrushParser
    {
        /// <summary>
        /// Parses the Brush data string and converts it into ICanvasBrushElement
        /// </summary>
        /// <param name="brushData">Brush data</param>
        /// <returns>ICanvasBrushElement</returns>
        internal static ICanvasBrushElement Parse(string brushData)
        {
            var matches = RegexFactory.CanvasBrushRegex.Matches(brushData);

            // If no match is found or no captures in the match, then it means
            // that the brush data is invalid.
            if ((matches == null) || (matches.Count == 0))
            {
                throw new ArgumentException($"Invalid Brush data!\nBrush Data: {brushData}", nameof(brushData));
            }

            // If the match contains more than one captures, it means that there
            // are multiple brushes present in the brush data. There should
            // be only one brush defined in the brush data.
            if (matches.Count > 1)
            {
                throw new ArgumentException("Multiple Brushes defined in Brush Data! " +
                                            "There should be only one Brush definition within the Brush Data. " +
                                            "You can either remove Brush definitions or split the Brush Data " +
                                            "into multiple Brush Data and call the CanvasPathGeometry.CreateBrush() method on each of them." +
                                            $"\nBrush Data: {brushData}");
            }

            // There should be only one match
            var match = matches[0];
            AbstractCanvasBrushElement brushElement = null;
            if (match.Groups["SolidColorBrush"].Success)
            {
                brushElement = new SolidColorBrushElement(match.Groups["SolidColorBrush"].Captures[0]);
            }
            else if (match.Groups["LinearGradient"].Success)
            {
                brushElement = new LinearGradientBrushElement(match.Groups["LinearGradient"].Captures[0]);
            }
            else if (match.Groups["LinearGradientHdr"].Success)
            {
                brushElement = new LinearGradientHdrBrushElement(match.Groups["LinearGradientHdr"].Captures[0]);
            }
            else if (match.Groups["RadialGradient"].Success)
            {
                brushElement = new RadialGradientBrushElement(match.Groups["RadialGradient"].Captures[0]);
            }
            else if (match.Groups["RadialGradientHdr"].Success)
            {
                brushElement = new RadialGradientHdrBrushElement(match.Groups["RadialGradientHdr"].Captures[0]);
            }

            if (brushElement == null)
            {
                return null;
            }

            // Perform validation to check if there are any invalid characters in the brush data that were not captured
            var preValidationCount = RegexFactory.ValidationRegex.Replace(brushData, string.Empty).Length;

            var postValidationCount = brushElement.ValidationCount;

            if (preValidationCount != postValidationCount)
            {
                throw new ArgumentException($"Brush data contains invalid characters!\nBrush Data: {brushData}", nameof(brushData));
            }

            return brushElement;
        }

        /// <summary>
        /// Parses the Brush data string and converts it into ICanvasBrush
        /// </summary>
        /// <param name="resourceCreator">ICanvasResourceCreator</param>
        /// <param name="brushData">Brush data string</param>
        /// <returns>ICanvasBrush</returns>
        internal static ICanvasBrush Parse(ICanvasResourceCreator resourceCreator, string brushData)
        {
            // Parse the brush data to get the ICanvasBrushElement
            var brushElement = Parse(brushData);

            // Create ICanvasBrush from the brushElement
            return brushElement.CreateBrush(resourceCreator);
        }
    }
}