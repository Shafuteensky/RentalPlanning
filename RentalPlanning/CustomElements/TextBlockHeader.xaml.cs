namespace RentalPlanning.CustomElements
{
	public sealed partial class TextBlockHeader : UserControl
	{
		public TextBlockHeader()
		{
			this.InitializeComponent();
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(TextBlockHeader), new PropertyMetadata("", OnLabelPropertyChanged));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        private static void OnLabelPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBlockHeader? control = d as TextBlockHeader;
            control?.SetLabel((string)e.NewValue);
        }

        private void SetLabel(string labelText)
        {
            HeaderText.Text = labelText;
        }
    }
}
