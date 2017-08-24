﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using Windows.UI.Xaml;

namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    /// <summary>
    /// The HamburgerMenu is based on a SplitView control. By default it contains a HamburgerButton and a ListView to display menu items.
    /// </summary>
    public partial class HamburgerMenu
    {
        /// <summary>
        /// Identifies the <see cref="HamburgerWidth"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty HamburgerWidthProperty = DependencyProperty.Register(nameof(HamburgerWidth), typeof(double), typeof(HamburgerMenu), new PropertyMetadata(48.0));

        /// <summary>
        /// Identifies the <see cref="HamburgerHeight"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty HamburgerHeightProperty = DependencyProperty.Register(nameof(HamburgerHeight), typeof(double), typeof(HamburgerMenu), new PropertyMetadata(48.0));

        /// <summary>
        /// Identifies the <see cref="HamburgerMargin"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty HamburgerMarginProperty = DependencyProperty.Register(nameof(HamburgerMargin), typeof(Thickness), typeof(HamburgerMenu), new PropertyMetadata(null));

        /// <summary>
        /// Identifies the <see cref="HamburgerVisibility"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty HamburgerVisibilityProperty = DependencyProperty.Register(nameof(HamburgerVisibility), typeof(Visibility), typeof(HamburgerMenu), new PropertyMetadata(Visibility.Visible));

        /// <summary>
        /// Identifies the <see cref="HamburgerMenuTemplate"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty HamburgerMenuTemplateProperty = DependencyProperty.Register(nameof(HamburgerMenuTemplate), typeof(DataTemplate), typeof(HamburgerMenu), new PropertyMetadata(null));

        /// <summary>
        /// Identifies the <see cref="HamburgerMenuAutomationPropertyName"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty HamburgerMenuAutomationPropertyNameProperty = DependencyProperty.Register(nameof(HamburgerMenuAutomationPropertyName), typeof(string), typeof(HamburgerMenu), new PropertyMetadata("Main button"));

        /// <summary>
        /// Gets or sets the automation property name for the hamburger icon.
        /// </summary>
        public string HamburgerMenuAutomationPropertyName
        {
            get { return (string)GetValue(HamburgerMenuAutomationPropertyNameProperty); }
            set { SetValue(HamburgerMenuAutomationPropertyNameProperty, value); }
        }

        /// <summary>
        /// Gets or sets a template for the hamburger icon.
        /// </summary>
        public DataTemplate HamburgerMenuTemplate
        {
            get { return (DataTemplate)GetValue(HamburgerMenuTemplateProperty); }
            set { SetValue(HamburgerMenuTemplateProperty, value); }
        }

        /// <summary>
        /// Gets or sets main button's width.
        /// </summary>
        public double HamburgerWidth
        {
            get { return (double)GetValue(HamburgerWidthProperty); }
            set { SetValue(HamburgerWidthProperty, value); }
        }

        /// <summary>
        /// Gets or sets main button's height.
        /// </summary>
        public double HamburgerHeight
        {
            get { return (double)GetValue(HamburgerHeightProperty); }
            set { SetValue(HamburgerHeightProperty, value); }
        }

        /// <summary>
        /// Gets or sets main button's margin.
        /// </summary>
        public Thickness HamburgerMargin
        {
            get { return (Thickness)GetValue(HamburgerMarginProperty); }
            set { SetValue(HamburgerMarginProperty, value); }
        }

        /// <summary>
        /// Gets or sets main button's visibility.
        /// </summary>
        public Visibility HamburgerVisibility
        {
            get { return (Visibility)GetValue(HamburgerVisibilityProperty); }
            set { SetValue(HamburgerVisibilityProperty, value); }
        }
    }
}
