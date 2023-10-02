namespace RentalPlanning.CustomElements
{
	public sealed partial class TextBlockBase : UserControl
	{
		public TextBlockBase()
		{
			this.InitializeComponent();
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(TextBlockBase), new PropertyMetadata("", OnLabelPropertyChanged));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        private static void OnLabelPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBlockBase? control = d as TextBlockBase;
            control?.SetLabel((string)e.NewValue);
        }

        private void SetLabel(string labelText)
        {
            HeaderText.Text = labelText;
        }
    }
}
