namespace RentalPlanning.CustomElements
{
	public sealed partial class TextBox : UserControl
	{
		public TextBox()
		{
			this.InitializeComponent();
        }

        public static readonly DependencyProperty PlaceholderLabelProperty =
            DependencyProperty.Register("PlaceholderLabel", typeof(string), typeof(TextBox), new PropertyMetadata("", OnPlaceholderLabelPropertyChanged));
        public string PlaceholderLabel
        {
            get { return (string)GetValue(PlaceholderLabelProperty); }
            set { SetValue(PlaceholderLabelProperty, value); }
        }
        private static void OnPlaceholderLabelPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBox? control = d as TextBox;
            control?.SetPlaceholderLabel((string)e.NewValue);
        }
        private void SetPlaceholderLabel(string labelText)
        {
            CustomTextBox.PlaceholderText = labelText;
        }

        public static readonly DependencyProperty WrapProperty =
            DependencyProperty.Register("Wrap", typeof(TextWrapping), typeof(TextBox), new PropertyMetadata("", OnWrapPropertyChanged));
        public TextWrapping Wrap
        {
            get { return (TextWrapping)GetValue(WrapProperty); }
            set { SetValue(WrapProperty, value); }
        }
        private static void OnWrapPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBox? control = d as TextBox;
            control?.SetWrap((TextWrapping)e.NewValue);
        }
        private void SetWrap(TextWrapping wrapValue)
        {
            CustomTextBox.TextWrapping = wrapValue;
        }
    }
}
