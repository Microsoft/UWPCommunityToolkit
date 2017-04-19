﻿namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    using Windows.UI.Xaml;

    /// <summary>
    /// Toolbar for Editing Text attached to a RichEditBox
    /// </summary>
    public partial class TextToolbar
    {
        // Using a DependencyProperty as the backing store for BoldLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BoldLabelProperty =
            DependencyProperty.Register(nameof(BoldLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Bold"));

        // Using a DependencyProperty as the backing store for ItalicsLahel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItalicsLabelProperty =
            DependencyProperty.Register(nameof(ItalicsLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Italics"));

        // Using a DependencyProperty as the backing store for StrikethroughLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StrikethroughLabelProperty =
            DependencyProperty.Register(nameof(StrikethroughLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Strikethrough"));

        // Using a DependencyProperty as the backing store for QuoteLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QuoteLabelProperty =
            DependencyProperty.Register(nameof(QuoteLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Quote"));

        // Using a DependencyProperty as the backing store for CodeLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CodeLabelProperty =
            DependencyProperty.Register(nameof(CodeLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Code"));

        // Using a DependencyProperty as the backing store for ListLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ListLabelProperty =
            DependencyProperty.Register(nameof(ListLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("List"));

        // Using a DependencyProperty as the backing store for OrderedListLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrderedListLabelProperty =
            DependencyProperty.Register(nameof(OrderedListLabel), typeof(int), typeof(TextToolbar), new PropertyMetadata("Ordered List"));

        // Using a DependencyProperty as the backing store for LinkLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LinkLabelProperty =
            DependencyProperty.Register(nameof(LinkLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Link"));

        // Using a DependencyProperty as the backing store for CreateLinkLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CreateLinkLabelProperty =
            DependencyProperty.Register(nameof(CreateLinkLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Create Link"));

        // Using a DependencyProperty as the backing store for UrlLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UrlLabelProperty =
            DependencyProperty.Register(nameof(UrlLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Url"));

        // Using a DependencyProperty as the backing store for LabelLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelLabelProperty =
            DependencyProperty.Register(nameof(LabelLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Label"));

        // Using a DependencyProperty as the backing store for OkLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OkLabelProperty =
            DependencyProperty.Register(nameof(OkLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Ok"));

        // Using a DependencyProperty as the backing store for CancelLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CancelLabelProperty =
            DependencyProperty.Register(nameof(CancelLabel), typeof(string), typeof(TextToolbar), new PropertyMetadata("Cancel"));

        public string BoldLabel
        {
            get { return (string)GetValue(BoldLabelProperty); }
            set { SetValue(BoldLabelProperty, value); }
        }

        public string ItalicsLabel
        {
            get { return (string)GetValue(ItalicsLabelProperty); }
            set { SetValue(ItalicsLabelProperty, value); }
        }

        public string StrikethroughLabel
        {
            get { return (string)GetValue(StrikethroughLabelProperty); }
            set { SetValue(StrikethroughLabelProperty, value); }
        }

        public string QuoteLabel
        {
            get { return (string)GetValue(QuoteLabelProperty); }
            set { SetValue(QuoteLabelProperty, value); }
        }

        public string CodeLabel
        {
            get { return (string)GetValue(CodeLabelProperty); }
            set { SetValue(CodeLabelProperty, value); }
        }

        public string ListLabel
        {
            get { return (string)GetValue(ListLabelProperty); }
            set { SetValue(ListLabelProperty, value); }
        }

        public int OrderedListLabel
        {
            get { return (int)GetValue(OrderedListLabelProperty); }
            set { SetValue(OrderedListLabelProperty, value); }
        }

        public string LinkLabel
        {
            get { return (string)GetValue(LinkLabelProperty); }
            set { SetValue(LinkLabelProperty, value); }
        }

        public string CreateLinkLabel
        {
            get { return (string)GetValue(CreateLinkLabelProperty); }
            set { SetValue(CreateLinkLabelProperty, value); }
        }

        public string UrlLabel
        {
            get { return (string)GetValue(UrlLabelProperty); }
            set { SetValue(UrlLabelProperty, value); }
        }

        public string LabelLabel
        {
            get { return (string)GetValue(LabelLabelProperty); }
            set { SetValue(LabelLabelProperty, value); }
        }

        public string OkLabel
        {
            get { return (string)GetValue(OkLabelProperty); }
            set { SetValue(OkLabelProperty, value); }
        }

        public string CancelLabel
        {
            get { return (string)GetValue(CancelLabelProperty); }
            set { SetValue(CancelLabelProperty, value); }
        }
    }
}