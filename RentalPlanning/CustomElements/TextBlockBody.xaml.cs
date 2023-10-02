namespace RentalPlanning.CustomElements
{
	public sealed partial class TextBlockBody : UserControl
	{
		public TextBlockBody()
		{
			this.InitializeComponent();
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(TextBlockBody), new PropertyMetadata("", OnLabelPropertyChanged));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        private static void OnLabelPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBlockBody? control = d as TextBlockBody;
            control?.SetLabel((string)e.NewValue);
        }

        private void SetLabel(string labelText)
        {
            HeaderText.Text = labelText;
        }
    }
}
